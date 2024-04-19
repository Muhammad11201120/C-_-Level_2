namespace Events
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
            this.ctrPersonAge1 = new Events.ctrPersonAge();
            this.SuspendLayout();
            // 
            // ctrPersonAge1
            // 
            this.ctrPersonAge1.Location = new System.Drawing.Point(138, 12);
            this.ctrPersonAge1.Name = "ctrPersonAge1";
            this.ctrPersonAge1.Size = new System.Drawing.Size(525, 115);
            this.ctrPersonAge1.TabIndex = 0;
            this.ctrPersonAge1.OnAgeChanged += new System.Action<int>(this.ctrPersonAge1_OnAgeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.ctrPersonAge1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonAge ctrPersonAge1;
    }
}

