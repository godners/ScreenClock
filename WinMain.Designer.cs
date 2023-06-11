namespace ScreenClock
{
    partial class WinMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();            
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.TimerInit = new System.Windows.Forms.Timer(this.components);
            this.Button0 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDate
            // 
            this.LabelDate.Font = new System.Drawing.Font("Consolas", 84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(8, 66);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Padding = new System.Windows.Forms.Padding(4);
            this.LabelDate.Size = new System.Drawing.Size(624, 139);
            this.LabelDate.TabIndex = 10;
            this.LabelDate.Text = "88888888";
            this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDate.DoubleClick += new System.EventHandler(this.WinMain_DoubleClick);
            // 
            // LabelTime
            // 
            this.LabelTime.Font = new System.Drawing.Font("Consolas", 84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(8, 213);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Padding = new System.Windows.Forms.Padding(4);
            this.LabelTime.Size = new System.Drawing.Size(624, 139);
            this.LabelTime.TabIndex = 11;
            this.LabelTime.Text = "::::::::";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTime.DoubleClick += new System.EventHandler(this.WinMain_DoubleClick);
            // 
            // TimerMain
            // 
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // TimerInit
            // 
            this.TimerInit.Enabled = true;
            this.TimerInit.Interval = 10;
            this.TimerInit.Tick += new System.EventHandler(this.TimerInit_Tick);
            // 
            // Button0
            // 
            this.Button0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button0.BackColor = System.Drawing.Color.White;
            this.Button0.ForeColor = System.Drawing.Color.Black;
            this.Button0.Location = new System.Drawing.Point(8, 8);
            this.Button0.Margin = new System.Windows.Forms.Padding(4);
            this.Button0.Name = "Button0";
            this.Button0.Padding = new System.Windows.Forms.Padding(4);
            this.Button0.Size = new System.Drawing.Size(150, 50);
            this.Button0.TabIndex = 0;
            this.Button0.Text = "Primary";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button1
            // 
            this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(166, 8);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Padding = new System.Windows.Forms.Padding(4);
            this.Button1.Size = new System.Drawing.Size(150, 50);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Secondary";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button2
            // 
            this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(324, 8);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Padding = new System.Windows.Forms.Padding(4);
            this.Button2.Size = new System.Drawing.Size(150, 50);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Auxiliary";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button3
            // 
            this.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Location = new System.Drawing.Point(482, 8);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Padding = new System.Windows.Forms.Padding(4);
            this.Button3.Size = new System.Drawing.Size(150, 50);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Supernumerary";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // WinMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "屏幕时钟";
            this.Load += new System.EventHandler(this.WinMain_Load);
            this.DoubleClick += new System.EventHandler(this.WinMain_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Timer TimerInit;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
    }
}

