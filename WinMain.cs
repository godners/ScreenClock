using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScreenClock.Program;

namespace ScreenClock
{
    internal partial class WinMain : Form
    {
        internal WinMain() => InitializeComponent();
        private Dictionary<Int32, Button> Buttons;
        private const Int32 Deviation = 50;
        private static DateTime DTNow;
        private static Single GoldenSection = (Single)((Math.Sqrt(5) - 1) / 2);

        private void WinMain_Load(object sender, EventArgs e)
        {
            Buttons = new Dictionary<Int32, Button> { { 0, Button0 }, { 1, Button1 }, { 2, Button2 }, { 3, Button3 } };
            InitButtons();

        }
        private static String StrTime => $"{DTNow:HH:mm:ss}";
        private static String StrDate => $"{DTNow:yy-MM-dd}";
        private static Color ColorDate => DTNow.Minute.Equals(0) ? Color.Red : Color.White;
        private static Color ColorTime => DTNow.Second.Equals(0) ? Color.Red : Color.White;
        private void FlushLabel() 
        {
            DTNow = DateTime.Now; LabelDate.Text = StrDate; LabelTime.Text = StrTime;
            LabelDate.ForeColor = ColorDate; LabelTime.ForeColor = ColorTime;
        }
        private void TimerInit_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now.Millisecond + Deviation ) % 1000 <= Deviation)
            { FlushLabel(); TimerInit.Enabled = false; TimerMain.Enabled = true; }
        }
        private void TimerMain_Tick(object sender, EventArgs e) => FlushLabel();
        private static Dictionary<Int32, Size> Sizes = new Dictionary<Int32, Size> { { 0, new Size(624, 50) }, { 1, new Size(308, 60) }, { 2, new Size(202, 50) }, { 3, new Size(150, 50) } };
        private static Dictionary<Int32, Int32> LocationOffsets = new Dictionary<Int32, Int32> { { 0, 0 }, { 1, 316 }, { 2, 211 }, { 3, 158 } };
        private static Point Locations(Int32 Screens, Int32 ButtonNumber) => new Point(8 + ButtonNumber * LocationOffsets[Screens], 8);
        private void InitButtons()
        {
            Int32 Screens = Screen.AllScreens.Length;
            for (Int32 i = 0; i < 4; i++)
            {
                Buttons[i].Visible = i < Screens; Buttons[i].Enabled = i <= Screens;
                Buttons[i].Size = Sizes[i]; Buttons[i].Location = Locations(Screens, i); 
            }          
        }        
        private void Button_Click(object sender, EventArgs e)
        {
            Screen ScreenNow = Screen.AllScreens[((Button)sender).TabIndex];
            foreach (Button B in Buttons.Values) B.Visible = false;
            FormMain.Bounds = ScreenNow.Bounds;
            FormMain.Location = ScreenNow.WorkingArea.Location;
            Size LabelSize = new Size(ScreenNow.Bounds.Width - 16, (ScreenNow.Bounds.Height - 24) / 2);
            LabelDate.Size = LabelSize; LabelTime.Size = LabelSize;
            LabelDate.Location = new Point(8, 8); LabelTime.Location = new Point(8, 16 + LabelSize.Height);
            Single FontHeight = LabelDate.Height * GoldenSection;
            Single FontWidth = (Single)((LabelDate.Width - LabelDate.Height) /
                Math.Pow(1 + GoldenSection, 4) * (1 - GoldenSection + GoldenSection * GoldenSection));
            Font LabelFont = new Font(LabelDate.Font.FontFamily, Math.Min(FontHeight,FontWidth), LabelDate.Font.Style, GraphicsUnit.Point);
            LabelDate.Font = LabelFont; LabelTime.Font=LabelFont;            
        }
        private void WinMain_DoubleClick(object sender, EventArgs e) => Application.Exit();
    }
}