namespace CustomCalendar
{
    partial class CustomScheduleDayPopup
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
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEvent.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxEvent.Location = new System.Drawing.Point(30, 141);
            this.textBoxEvent.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEvent.Multiline = true;
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(470, 85);
            this.textBoxEvent.TabIndex = 1;
            this.textBoxEvent.TextChanged += new System.EventHandler(this.textBoxEvent_TextChanged);
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelEvent.Location = new System.Drawing.Point(25, 110);
            this.labelEvent.Margin = new System.Windows.Forms.Padding(0);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(61, 28);
            this.labelEvent.TabIndex = 2;
            this.labelEvent.Text = "Event";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelDate.Location = new System.Drawing.Point(25, 25);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 28);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.comboBoxFrom.DropDownHeight = 180;
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFrom.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.5F, System.Drawing.FontStyle.Bold);
            this.comboBoxFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.IntegralHeight = false;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.comboBoxFrom.Location = new System.Drawing.Point(280, 56);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(100, 33);
            this.comboBoxFrom.TabIndex = 4;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.comboBoxTo.DropDownHeight = 180;
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.5F, System.Drawing.FontStyle.Bold);
            this.comboBoxTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.IntegralHeight = false;
            this.comboBoxTo.Location = new System.Drawing.Point(400, 56);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(100, 33);
            this.comboBoxTo.TabIndex = 5;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelFrom.Location = new System.Drawing.Point(275, 25);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(55, 28);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelTo.Location = new System.Drawing.Point(395, 25);
            this.labelTo.Margin = new System.Windows.Forms.Padding(0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(32, 28);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "To";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.comboBoxPriority.DropDownHeight = 180;
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPriority.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.5F, System.Drawing.FontStyle.Bold);
            this.comboBoxPriority.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.IntegralHeight = false;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Yellow",
            "Green",
            "Orange",
            "Blue",
            "Red",
            "Purple"});
            this.comboBoxPriority.Location = new System.Drawing.Point(30, 274);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(220, 33);
            this.comboBoxPriority.TabIndex = 8;
            this.comboBoxPriority.SelectedIndexChanged += new System.EventHandler(this.comboBoxPriority_SelectedIndexChanged);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelPriority.Location = new System.Drawing.Point(25, 243);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(57, 28);
            this.labelPriority.TabIndex = 9;
            this.labelPriority.Text = "Color";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.buttonAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEvent.FlatAppearance.BorderSize = 0;
            this.buttonAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEvent.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAddEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEvent.Location = new System.Drawing.Point(280, 274);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(220, 33);
            this.buttonAddEvent.TabIndex = 10;
            this.buttonAddEvent.Text = "Add Event";
            this.buttonAddEvent.UseVisualStyleBackColor = false;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // CustomScheduleDayPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.textBoxEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 380);
            this.Name = "CustomScheduleDayPopup";
            this.Text = "FormDayPopup";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Button buttonAddEvent;
    }
}