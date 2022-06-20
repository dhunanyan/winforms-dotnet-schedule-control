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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customSchedule1 = new CustomCalendar.CustomControls.CustomSchedule.CustomSchedule();
            this.SuspendLayout();
            // 
            // customSchedule1
            // 
            this.customSchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.customSchedule1.Location = new System.Drawing.Point(147, 44);
            this.customSchedule1.Margin = new System.Windows.Forms.Padding(0);
            this.customSchedule1.MaximumSize = new System.Drawing.Size(780, 680);
            this.customSchedule1.MinimumSize = new System.Drawing.Size(780, 680);
            this.customSchedule1.Name = "customSchedule1";
            this.customSchedule1.Size = new System.Drawing.Size(780, 680);
            this.customSchedule1.TabIndex = 0;
            this.customSchedule1.Time = new System.DateTime(2022, 6, 20, 22, 58, 43, 50);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1075, 778);
            this.Controls.Add(this.customSchedule1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomSchedule.CustomSchedule customSchedule1;
    }
}

