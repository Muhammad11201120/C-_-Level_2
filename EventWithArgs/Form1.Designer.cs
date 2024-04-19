namespace EventWithArgs
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
            this.ctrCalculator1 = new EventWithArgs.ctrCalculator();
            this.SuspendLayout();
            // 
            // ctrCalculator1
            // 
            this.ctrCalculator1.Location = new System.Drawing.Point(74, 65);
            this.ctrCalculator1.Name = "ctrCalculator1";
            this.ctrCalculator1.Size = new System.Drawing.Size(630, 204);
            this.ctrCalculator1.TabIndex = 0;
            this.ctrCalculator1.OnCalculatorComplete += new System.EventHandler<EventWithArgs.ctrCalculator.CalculatorEventArgs>(this.ctrCalculator1_OnCalculatorComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrCalculator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrCalculator ctrCalculator1;
    }
}

