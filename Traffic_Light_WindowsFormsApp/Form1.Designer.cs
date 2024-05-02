namespace Traffic_Light_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new Traffic_Light_WindowsFormsApp.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.CurrentColor = Traffic_Light_WindowsFormsApp.UserControl1.TrafficLightColor.Red;
            this.userControl11.GreenTime = 10;
            this.userControl11.Location = new System.Drawing.Point(33, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.OrangeTime = 3;
            this.userControl11.RedTime = 10;
            this.userControl11.Size = new System.Drawing.Size(241, 540);
            this.userControl11.TabIndex = 0;
            this.userControl11.RedLightOn += new System.EventHandler<Traffic_Light_WindowsFormsApp.UserControl1.TrafficLightEventArgs>(this.userControl11_RedLightOn);
            this.userControl11.YellowLightOn += new System.EventHandler<Traffic_Light_WindowsFormsApp.UserControl1.TrafficLightEventArgs>(this.userControl11_YellowLightOn);
            this.userControl11.GreenLightOn += new System.EventHandler<Traffic_Light_WindowsFormsApp.UserControl1.TrafficLightEventArgs>(this.userControl11_GreenLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(317, 636);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
    }
}

