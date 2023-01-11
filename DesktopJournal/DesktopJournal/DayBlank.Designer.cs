namespace DesktopJournal
{
    partial class DayBlank
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
            this.dayNumber = new System.Windows.Forms.Label();
            this.ActiveAppointmentPanel = new System.Windows.Forms.Panel();
            this.ActiveAppointmentLabel = new System.Windows.Forms.Label();
            this.CompletedAppointmentPanel = new System.Windows.Forms.Panel();
            this.CompletedAppointmentLabel = new System.Windows.Forms.Label();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.ActiveAppointmentPanel.SuspendLayout();
            this.CompletedAppointmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayNumber
            // 
            this.dayNumber.BackColor = System.Drawing.Color.Transparent;
            this.dayNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayNumber.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayNumber.Location = new System.Drawing.Point(0, 0);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(24, 27);
            this.dayNumber.TabIndex = 0;
            this.dayNumber.Text = "01";
            this.dayNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dayNumber.Click += new System.EventHandler(this.dayNumber_Click);
            // 
            // ActiveAppointmentPanel
            // 
            this.ActiveAppointmentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ActiveAppointmentPanel.Controls.Add(this.ActiveAppointmentLabel);
            this.ActiveAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveAppointmentPanel.Location = new System.Drawing.Point(24, 0);
            this.ActiveAppointmentPanel.Name = "ActiveAppointmentPanel";
            this.ActiveAppointmentPanel.Size = new System.Drawing.Size(12, 13);
            this.ActiveAppointmentPanel.TabIndex = 1;
            // 
            // ActiveAppointmentLabel
            // 
            this.ActiveAppointmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.ActiveAppointmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveAppointmentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActiveAppointmentLabel.Location = new System.Drawing.Point(0, 0);
            this.ActiveAppointmentLabel.Name = "ActiveAppointmentLabel";
            this.ActiveAppointmentLabel.Size = new System.Drawing.Size(12, 13);
            this.ActiveAppointmentLabel.TabIndex = 0;
            this.ActiveAppointmentLabel.Text = "01";
            this.ActiveAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedAppointmentPanel
            // 
            this.CompletedAppointmentPanel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedAppointmentPanel.Controls.Add(this.CompletedAppointmentLabel);
            this.CompletedAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompletedAppointmentPanel.Location = new System.Drawing.Point(24, 13);
            this.CompletedAppointmentPanel.Name = "CompletedAppointmentPanel";
            this.CompletedAppointmentPanel.Size = new System.Drawing.Size(12, 13);
            this.CompletedAppointmentPanel.TabIndex = 2;
            // 
            // CompletedAppointmentLabel
            // 
            this.CompletedAppointmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedAppointmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompletedAppointmentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CompletedAppointmentLabel.Location = new System.Drawing.Point(0, 0);
            this.CompletedAppointmentLabel.Name = "CompletedAppointmentLabel";
            this.CompletedAppointmentLabel.Size = new System.Drawing.Size(12, 13);
            this.CompletedAppointmentLabel.TabIndex = 1;
            this.CompletedAppointmentLabel.Text = "01";
            this.CompletedAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.BackColor = System.Drawing.Color.Transparent;
            this.AddAppointmentButton.FlatAppearance.BorderSize = 0;
            this.AddAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddAppointmentButton.Location = new System.Drawing.Point(0, 19);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(25, 10);
            this.AddAppointmentButton.TabIndex = 2;
            this.AddAppointmentButton.Text = "button1";
            this.AddAppointmentButton.UseVisualStyleBackColor = false;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.CompletedAppointmentPanel);
            this.Controls.Add(this.ActiveAppointmentPanel);
            this.Controls.Add(this.dayNumber);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(36, 27);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.ActiveAppointmentPanel.ResumeLayout(false);
            this.CompletedAppointmentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Label dayNumber;
        private Panel ActiveAppointmentPanel;
        private Label ActiveAppointmentLabel;
        private Panel CompletedAppointmentPanel;
        private Label CompletedAppointmentLabel;
        private Button AddAppointmentButton;
    }
}
