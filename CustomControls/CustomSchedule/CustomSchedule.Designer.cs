namespace CustomCalendar.CustomControls.CustomSchedule
{
    partial class CustomSchedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelMonthYear = new System.Windows.Forms.Label();
            this.flowLayoutPanelWeekDays = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSun = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.labelTue = new System.Windows.Forms.Label();
            this.labelWed = new System.Windows.Forms.Label();
            this.labelThu = new System.Windows.Forms.Label();
            this.labelFri = new System.Windows.Forms.Label();
            this.labelSat = new System.Windows.Forms.Label();
            this.flowLayoutPanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelTime = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.flowLayoutPanelTimeLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanelWeekDays.SuspendLayout();
            this.flowLayoutPanelTime.SuspendLayout();
            this.flowLayoutPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Controls.Add(this.panelHeader);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelWeekDays);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelDays);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(70, 0);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMain.MaximumSize = new System.Drawing.Size(710, 680);
            this.flowLayoutPanelMain.MinimumSize = new System.Drawing.Size(710, 680);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(710, 680);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonChange);
            this.panelHeader.Controls.Add(this.buttonLeft);
            this.panelHeader.Controls.Add(this.buttonRight);
            this.panelHeader.Controls.Add(this.labelMonthYear);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelHeader.Size = new System.Drawing.Size(710, 35);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonChange.Location = new System.Drawing.Point(494, 2);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(135, 31);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Display Week";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::CustomCalendar.Properties.Resources.leftRight;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(635, 0);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(35, 35);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::CustomCalendar.Properties.Resources.rightArrow;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(670, 0);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(35, 35);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // labelMonthYear
            // 
            this.labelMonthYear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonthYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.labelMonthYear.Location = new System.Drawing.Point(0, 0);
            this.labelMonthYear.Margin = new System.Windows.Forms.Padding(0);
            this.labelMonthYear.Name = "labelMonthYear";
            this.labelMonthYear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelMonthYear.Size = new System.Drawing.Size(355, 35);
            this.labelMonthYear.TabIndex = 0;
            this.labelMonthYear.Text = "December 2021";
            this.labelMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelWeekDays
            // 
            this.flowLayoutPanelWeekDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelSun);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelMon);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelTue);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelWed);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelThu);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelFri);
            this.flowLayoutPanelWeekDays.Controls.Add(this.labelSat);
            this.flowLayoutPanelWeekDays.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanelWeekDays.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelWeekDays.Name = "flowLayoutPanelWeekDays";
            this.flowLayoutPanelWeekDays.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelWeekDays.Size = new System.Drawing.Size(710, 35);
            this.flowLayoutPanelWeekDays.TabIndex = 10;
            // 
            // labelSun
            // 
            this.labelSun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelSun.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSun.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSun.Location = new System.Drawing.Point(5, 5);
            this.labelSun.Margin = new System.Windows.Forms.Padding(0);
            this.labelSun.Name = "labelSun";
            this.labelSun.Size = new System.Drawing.Size(100, 25);
            this.labelSun.TabIndex = 3;
            this.labelSun.Text = "SUN";
            this.labelSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMon
            // 
            this.labelMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelMon.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMon.Location = new System.Drawing.Point(105, 5);
            this.labelMon.Margin = new System.Windows.Forms.Padding(0);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(100, 25);
            this.labelMon.TabIndex = 4;
            this.labelMon.Text = "MON";
            this.labelMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTue
            // 
            this.labelTue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelTue.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTue.Location = new System.Drawing.Point(205, 5);
            this.labelTue.Margin = new System.Windows.Forms.Padding(0);
            this.labelTue.Name = "labelTue";
            this.labelTue.Size = new System.Drawing.Size(100, 25);
            this.labelTue.TabIndex = 5;
            this.labelTue.Text = "TUE";
            this.labelTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWed
            // 
            this.labelWed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelWed.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWed.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelWed.Location = new System.Drawing.Point(305, 5);
            this.labelWed.Margin = new System.Windows.Forms.Padding(0);
            this.labelWed.Name = "labelWed";
            this.labelWed.Size = new System.Drawing.Size(100, 25);
            this.labelWed.TabIndex = 6;
            this.labelWed.Text = "WED";
            this.labelWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThu
            // 
            this.labelThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelThu.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThu.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelThu.Location = new System.Drawing.Point(405, 5);
            this.labelThu.Margin = new System.Windows.Forms.Padding(0);
            this.labelThu.Name = "labelThu";
            this.labelThu.Size = new System.Drawing.Size(100, 25);
            this.labelThu.TabIndex = 7;
            this.labelThu.Text = "THU";
            this.labelThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFri
            // 
            this.labelFri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelFri.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFri.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFri.Location = new System.Drawing.Point(505, 5);
            this.labelFri.Margin = new System.Windows.Forms.Padding(0);
            this.labelFri.Name = "labelFri";
            this.labelFri.Size = new System.Drawing.Size(100, 25);
            this.labelFri.TabIndex = 8;
            this.labelFri.Text = "FRI";
            this.labelFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSat
            // 
            this.labelSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.labelSat.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSat.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSat.Location = new System.Drawing.Point(605, 5);
            this.labelSat.Margin = new System.Windows.Forms.Padding(0);
            this.labelSat.Name = "labelSat";
            this.labelSat.Size = new System.Drawing.Size(100, 25);
            this.labelSat.TabIndex = 9;
            this.labelSat.Text = "SAT";
            this.labelSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelDays
            // 
            this.flowLayoutPanelDays.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanelDays.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDays.Name = "flowLayoutPanelDays";
            this.flowLayoutPanelDays.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelDays.Size = new System.Drawing.Size(710, 610);
            this.flowLayoutPanelDays.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tag = "0";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanelTime
            // 
            this.flowLayoutPanelTime.Controls.Add(this.panel1);
            this.flowLayoutPanelTime.Controls.Add(this.labelTime);
            this.flowLayoutPanelTime.Controls.Add(this.flowLayoutPanelTimeLabels);
            this.flowLayoutPanelTime.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTime.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTime.Name = "flowLayoutPanelTime";
            this.flowLayoutPanelTime.Size = new System.Drawing.Size(70, 680);
            this.flowLayoutPanelTime.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 35);
            this.panel1.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.labelTime.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(0, 35);
            this.labelTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(70, 35);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Week";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelTimeLabels
            // 
            this.flowLayoutPanelTimeLabels.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanelTimeLabels.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTimeLabels.Name = "flowLayoutPanelTimeLabels";
            this.flowLayoutPanelTimeLabels.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanelTimeLabels.Size = new System.Drawing.Size(70, 610);
            this.flowLayoutPanelTimeLabels.TabIndex = 6;
            // 
            // flowLayoutPanelContainer
            // 
            this.flowLayoutPanelContainer.Controls.Add(this.flowLayoutPanelTime);
            this.flowLayoutPanelContainer.Controls.Add(this.flowLayoutPanelMain);
            this.flowLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContainer.Name = "flowLayoutPanelContainer";
            this.flowLayoutPanelContainer.Size = new System.Drawing.Size(780, 680);
            this.flowLayoutPanelContainer.TabIndex = 2;
            // 
            // CustomSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.flowLayoutPanelContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(780, 680);
            this.MinimumSize = new System.Drawing.Size(780, 680);
            this.Name = "CustomSchedule";
            this.Size = new System.Drawing.Size(780, 680);
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.flowLayoutPanelWeekDays.ResumeLayout(false);
            this.flowLayoutPanelTime.ResumeLayout(false);
            this.flowLayoutPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelMonthYear;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelSat;
        private System.Windows.Forms.Label labelFri;
        private System.Windows.Forms.Label labelWed;
        private System.Windows.Forms.Label labelThu;
        private System.Windows.Forms.Label labelTue;
        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWeekDays;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelSun;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTimeLabels;
    }
}
