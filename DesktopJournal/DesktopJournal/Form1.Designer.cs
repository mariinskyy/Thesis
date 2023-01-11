namespace DesktopJournal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button CalendarButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.NotebookButton = new System.Windows.Forms.Button();
            this.GoalButton = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowCalendarPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MonthTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonJanuary = new System.Windows.Forms.Button();
            this.ButtonFebruary = new System.Windows.Forms.Button();
            this.ButtonMarch = new System.Windows.Forms.Button();
            this.ButtonMay = new System.Windows.Forms.Button();
            this.ButtonJune = new System.Windows.Forms.Button();
            this.ButtonJuly = new System.Windows.Forms.Button();
            this.ButtonAugust = new System.Windows.Forms.Button();
            this.ButtonSeptember = new System.Windows.Forms.Button();
            this.ButtonOctober = new System.Windows.Forms.Button();
            this.ButtonNovember = new System.Windows.Forms.Button();
            this.ButtonDecember = new System.Windows.Forms.Button();
            this.ButtonApril = new System.Windows.Forms.Button();
            this.AppointmentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.YearPanel = new System.Windows.Forms.Panel();
            this.YearButton = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            CalendarButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowCalendarPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MonthTablePanel.SuspendLayout();
            this.YearPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarButton
            // 
            CalendarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            CalendarButton.FlatAppearance.BorderSize = 0;
            CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CalendarButton.Image = global::DesktopJournal.Properties.Resources.icons8_planner_48;
            CalendarButton.Location = new System.Drawing.Point(3, 3);
            CalendarButton.Name = "CalendarButton";
            CalendarButton.Size = new System.Drawing.Size(299, 63);
            CalendarButton.TabIndex = 0;
            CalendarButton.UseVisualStyleBackColor = false;
            CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 209);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChallengeButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NotebookButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoalButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(CalendarButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimerButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::DesktopJournal.Properties.Resources.icons8_account_48;
            this.button6.Location = new System.Drawing.Point(1040, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 63);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Image = ((System.Drawing.Image)(resources.GetObject("ChallengeButton.Image")));
            this.ChallengeButton.Location = new System.Drawing.Point(857, 3);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(177, 63);
            this.ChallengeButton.TabIndex = 4;
            this.ChallengeButton.UseVisualStyleBackColor = true;
            // 
            // NotebookButton
            // 
            this.NotebookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotebookButton.FlatAppearance.BorderSize = 0;
            this.NotebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotebookButton.Image = global::DesktopJournal.Properties.Resources.icons8_study_481;
            this.NotebookButton.Location = new System.Drawing.Point(674, 3);
            this.NotebookButton.Name = "NotebookButton";
            this.NotebookButton.Size = new System.Drawing.Size(177, 63);
            this.NotebookButton.TabIndex = 3;
            this.NotebookButton.UseVisualStyleBackColor = true;
            // 
            // GoalButton
            // 
            this.GoalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalButton.FlatAppearance.BorderSize = 0;
            this.GoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButton.Image = global::DesktopJournal.Properties.Resources.icons8_tasks_48__1_;
            this.GoalButton.Location = new System.Drawing.Point(491, 3);
            this.GoalButton.Name = "GoalButton";
            this.GoalButton.Size = new System.Drawing.Size(177, 63);
            this.GoalButton.TabIndex = 2;
            this.GoalButton.UseVisualStyleBackColor = true;
            // 
            // TimerButton
            // 
            this.TimerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerButton.FlatAppearance.BorderSize = 0;
            this.TimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimerButton.Image = global::DesktopJournal.Properties.Resources.icons8_timer_48__1_;
            this.TimerButton.Location = new System.Drawing.Point(308, 3);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(177, 63);
            this.TimerButton.TabIndex = 1;
            this.TimerButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 641);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Linen;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.flowCalendarPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1223, 641);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowCalendarPanel
            // 
            this.flowCalendarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowCalendarPanel.Controls.Add(this.panel3);
            this.flowCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCalendarPanel.Location = new System.Drawing.Point(3, 3);
            this.flowCalendarPanel.Name = "flowCalendarPanel";
            this.flowCalendarPanel.Size = new System.Drawing.Size(299, 635);
            this.flowCalendarPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.MonthTablePanel);
            this.panel3.Controls.Add(this.AppointmentPanel);
            this.panel3.Controls.Add(this.YearPanel);
            this.panel3.Location = new System.Drawing.Point(2, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 358);
            this.panel3.TabIndex = 0;
            // 
            // MonthTablePanel
            // 
            this.MonthTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MonthTablePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MonthTablePanel.ColumnCount = 1;
            this.MonthTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MonthTablePanel.Controls.Add(this.ButtonJanuary, 0, 0);
            this.MonthTablePanel.Controls.Add(this.ButtonFebruary, 0, 1);
            this.MonthTablePanel.Controls.Add(this.ButtonMarch, 0, 2);
            this.MonthTablePanel.Controls.Add(this.ButtonMay, 0, 4);
            this.MonthTablePanel.Controls.Add(this.ButtonJune, 0, 5);
            this.MonthTablePanel.Controls.Add(this.ButtonJuly, 0, 6);
            this.MonthTablePanel.Controls.Add(this.ButtonAugust, 0, 7);
            this.MonthTablePanel.Controls.Add(this.ButtonSeptember, 0, 8);
            this.MonthTablePanel.Controls.Add(this.ButtonOctober, 0, 9);
            this.MonthTablePanel.Controls.Add(this.ButtonNovember, 0, 10);
            this.MonthTablePanel.Controls.Add(this.ButtonDecember, 0, 11);
            this.MonthTablePanel.Controls.Add(this.ButtonApril, 0, 3);
            this.MonthTablePanel.Location = new System.Drawing.Point(4, 36);
            this.MonthTablePanel.Name = "MonthTablePanel";
            this.MonthTablePanel.RowCount = 12;
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.331108F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.331233F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.331814F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332443F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332443F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332443F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334753F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthTablePanel.Size = new System.Drawing.Size(99, 319);
            this.MonthTablePanel.TabIndex = 3;
            // 
            // ButtonJanuary
            // 
            this.ButtonJanuary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonJanuary.FlatAppearance.BorderSize = 0;
            this.ButtonJanuary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJanuary.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonJanuary.Location = new System.Drawing.Point(3, 3);
            this.ButtonJanuary.Name = "ButtonJanuary";
            this.ButtonJanuary.Size = new System.Drawing.Size(93, 20);
            this.ButtonJanuary.TabIndex = 1;
            this.ButtonJanuary.Text = "JANUARY";
            this.ButtonJanuary.UseVisualStyleBackColor = true;
            // 
            // ButtonFebruary
            // 
            this.ButtonFebruary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFebruary.FlatAppearance.BorderSize = 0;
            this.ButtonFebruary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFebruary.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFebruary.Location = new System.Drawing.Point(3, 29);
            this.ButtonFebruary.Name = "ButtonFebruary";
            this.ButtonFebruary.Size = new System.Drawing.Size(93, 20);
            this.ButtonFebruary.TabIndex = 2;
            this.ButtonFebruary.Text = "FEBRUARY";
            this.ButtonFebruary.UseVisualStyleBackColor = true;
            // 
            // ButtonMarch
            // 
            this.ButtonMarch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMarch.FlatAppearance.BorderSize = 0;
            this.ButtonMarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMarch.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMarch.Location = new System.Drawing.Point(3, 55);
            this.ButtonMarch.Name = "ButtonMarch";
            this.ButtonMarch.Size = new System.Drawing.Size(93, 20);
            this.ButtonMarch.TabIndex = 3;
            this.ButtonMarch.Text = "MARCH";
            this.ButtonMarch.UseVisualStyleBackColor = true;
            // 
            // ButtonMay
            // 
            this.ButtonMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMay.FlatAppearance.BorderSize = 0;
            this.ButtonMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMay.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMay.Location = new System.Drawing.Point(3, 107);
            this.ButtonMay.Name = "ButtonMay";
            this.ButtonMay.Size = new System.Drawing.Size(93, 20);
            this.ButtonMay.TabIndex = 5;
            this.ButtonMay.Text = "MAY";
            this.ButtonMay.UseVisualStyleBackColor = true;
            // 
            // ButtonJune
            // 
            this.ButtonJune.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonJune.FlatAppearance.BorderSize = 0;
            this.ButtonJune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJune.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonJune.Location = new System.Drawing.Point(3, 133);
            this.ButtonJune.Name = "ButtonJune";
            this.ButtonJune.Size = new System.Drawing.Size(93, 20);
            this.ButtonJune.TabIndex = 6;
            this.ButtonJune.Text = "JUNE";
            this.ButtonJune.UseVisualStyleBackColor = true;
            // 
            // ButtonJuly
            // 
            this.ButtonJuly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonJuly.FlatAppearance.BorderSize = 0;
            this.ButtonJuly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJuly.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonJuly.Location = new System.Drawing.Point(3, 159);
            this.ButtonJuly.Name = "ButtonJuly";
            this.ButtonJuly.Size = new System.Drawing.Size(93, 20);
            this.ButtonJuly.TabIndex = 7;
            this.ButtonJuly.Text = "JULY";
            this.ButtonJuly.UseVisualStyleBackColor = true;
            // 
            // ButtonAugust
            // 
            this.ButtonAugust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAugust.FlatAppearance.BorderSize = 0;
            this.ButtonAugust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAugust.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAugust.Location = new System.Drawing.Point(3, 185);
            this.ButtonAugust.Name = "ButtonAugust";
            this.ButtonAugust.Size = new System.Drawing.Size(93, 20);
            this.ButtonAugust.TabIndex = 8;
            this.ButtonAugust.Text = "AUGUST";
            this.ButtonAugust.UseVisualStyleBackColor = true;
            // 
            // ButtonSeptember
            // 
            this.ButtonSeptember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSeptember.FlatAppearance.BorderSize = 0;
            this.ButtonSeptember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSeptember.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSeptember.Location = new System.Drawing.Point(3, 211);
            this.ButtonSeptember.Name = "ButtonSeptember";
            this.ButtonSeptember.Size = new System.Drawing.Size(93, 20);
            this.ButtonSeptember.TabIndex = 9;
            this.ButtonSeptember.Text = "SEPTEMBER";
            this.ButtonSeptember.UseVisualStyleBackColor = true;
            // 
            // ButtonOctober
            // 
            this.ButtonOctober.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOctober.FlatAppearance.BorderSize = 0;
            this.ButtonOctober.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOctober.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOctober.Location = new System.Drawing.Point(3, 237);
            this.ButtonOctober.Name = "ButtonOctober";
            this.ButtonOctober.Size = new System.Drawing.Size(93, 20);
            this.ButtonOctober.TabIndex = 10;
            this.ButtonOctober.Text = "OCTOBER";
            this.ButtonOctober.UseVisualStyleBackColor = true;
            // 
            // ButtonNovember
            // 
            this.ButtonNovember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNovember.FlatAppearance.BorderSize = 0;
            this.ButtonNovember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovember.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNovember.Location = new System.Drawing.Point(3, 263);
            this.ButtonNovember.Name = "ButtonNovember";
            this.ButtonNovember.Size = new System.Drawing.Size(93, 20);
            this.ButtonNovember.TabIndex = 11;
            this.ButtonNovember.Text = "NOVEMBER";
            this.ButtonNovember.UseVisualStyleBackColor = true;
            // 
            // ButtonDecember
            // 
            this.ButtonDecember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDecember.FlatAppearance.BorderSize = 0;
            this.ButtonDecember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDecember.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDecember.Location = new System.Drawing.Point(3, 289);
            this.ButtonDecember.Name = "ButtonDecember";
            this.ButtonDecember.Size = new System.Drawing.Size(93, 27);
            this.ButtonDecember.TabIndex = 12;
            this.ButtonDecember.Text = "DECEMBER";
            this.ButtonDecember.UseVisualStyleBackColor = true;
            // 
            // ButtonApril
            // 
            this.ButtonApril.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonApril.FlatAppearance.BorderSize = 0;
            this.ButtonApril.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApril.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApril.Location = new System.Drawing.Point(3, 81);
            this.ButtonApril.Name = "ButtonApril";
            this.ButtonApril.Size = new System.Drawing.Size(93, 20);
            this.ButtonApril.TabIndex = 4;
            this.ButtonApril.Text = "APRIL";
            this.ButtonApril.UseVisualStyleBackColor = true;
            // 
            // AppointmentPanel
            // 
            this.AppointmentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AppointmentPanel.Location = new System.Drawing.Point(109, 36);
            this.AppointmentPanel.Name = "AppointmentPanel";
            this.AppointmentPanel.Size = new System.Drawing.Size(184, 319);
            this.AppointmentPanel.TabIndex = 2;
            // 
            // YearPanel
            // 
            this.YearPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YearPanel.Controls.Add(this.YearButton);
            this.YearPanel.Controls.Add(this.ButtonPrevious);
            this.YearPanel.Controls.Add(this.ButtonNext);
            this.YearPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearPanel.Location = new System.Drawing.Point(0, 0);
            this.YearPanel.Name = "YearPanel";
            this.YearPanel.Size = new System.Drawing.Size(293, 36);
            this.YearPanel.TabIndex = 0;
            // 
            // YearButton
            // 
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Location = new System.Drawing.Point(103, 0);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(87, 36);
            this.YearButton.TabIndex = 2;
            this.YearButton.Text = "YEAR";
            this.YearButton.UseVisualStyleBackColor = true;
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPrevious.FlatAppearance.BorderSize = 0;
            this.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevious.Location = new System.Drawing.Point(0, 0);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(103, 36);
            this.ButtonPrevious.TabIndex = 1;
            this.ButtonPrevious.Text = "<";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Location = new System.Drawing.Point(190, 0);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(103, 36);
            this.ButtonNext.TabIndex = 0;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowCalendarPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MonthTablePanel.ResumeLayout(false);
            this.YearPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button6;
        private Button ChallengeButton;
        private Button NotebookButton;
        private Button GoalButton;
        private Button CalendarButton;
        private Button TimerButton;
        private System.Windows.Forms.Timer timer1;
        public TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel YearPanel;
        private FlowLayoutPanel AppointmentPanel;
        private Button YearButton;
        private Button ButtonPrevious;
        private Button ButtonNext;
        private TableLayoutPanel MonthTablePanel;
        private Button ButtonJanuary;
        private Button ButtonFebruary;
        private Button ButtonMarch;
        private Button ButtonMay;
        private Button ButtonJune;
        private Button ButtonJuly;
        private Button ButtonAugust;
        private Button ButtonSeptember;
        private Button ButtonOctober;
        private Button ButtonNovember;
        private Button ButtonDecember;
        private Button ButtonApril;
        public Panel flowCalendarPanel;
    }
}