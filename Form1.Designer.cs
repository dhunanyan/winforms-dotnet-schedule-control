namespace CustomCalendar
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customSchedule1 = new CustomCalendar.CustomControls.CustomSchedule();
            this.SuspendLayout();
            // 
            // customSchedule1
            // 
            this.customSchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.customSchedule1.Location = new System.Drawing.Point(205, 35);
            this.customSchedule1.Margin = new System.Windows.Forms.Padding(0);
            this.customSchedule1.MinimumSize = new System.Drawing.Size(710, 680);
            this.customSchedule1.Name = "customSchedule1";
            this.customSchedule1.Size = new System.Drawing.Size(710, 680);
            this.customSchedule1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(106)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1075, 778);
            this.Controls.Add(this.customSchedule1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomSchedule customSchedule1;
    }
}

