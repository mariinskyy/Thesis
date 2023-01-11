using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopJournal
{
    public partial class Form1 : Form
    {
        
        public CustomCalander _calendar;
        private int _selectedMonth;
        //public AppointmentViewPanel _appointmentViewPanel;

        private Color ACTIVE_BUTTON_COLOR = Color.FromArgb(85, 238, 82, 83);
        private Color NOT_ACTIVE_COLOR = Color.FromKnownColor(KnownColor.InactiveCaption);

        public Form1()
        {
            InitializeComponent();
            new List<Control> { panel1 }.ForEach(x => x.MouseDown += (s, a) =>
            {
                x.Capture = false; Capture = false;
                Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                base.WndProc(ref m);
            });
        }


        // For sliding calendar panel:
        bool isShow;


        // When clicking CalendarButton it will open the sliding panel, which shows calendar and to-do list
        public void CalendarButton_Click(object sender, EventArgs e)
        {
            
            if (flowCalendarPanel.Visible)
            {
                isShow = false;
                flowCalendarPanel.Hide();
                timer1.Start();
            }
            else
            {
                isShow = true;
                flowCalendarPanel.Show();
                timer1.Start();
            }
        }


        // For sliding calendar panel
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (flowCalendarPanel.Height >= 492)
                    timer1.Stop();

                flowCalendarPanel.Height += 25;
            }
            else
            {
                if (flowCalendarPanel.Height <= 0)
                {
                    flowCalendarPanel.Hide();
                    timer1.Stop();
                }

                flowCalendarPanel.Height -= 25;
            }
        }

        
        public void Form1_Load(object sender, EventArgs e)
        {
            // Adding calendar to panel and localizing
            _calendar = new CustomCalander();
            _calendar.Dock = DockStyle.Top;
            _calendar.DisplayDays(DateTime.Now);

            //_appointmentViewPanel = new AppointmentViewPanel();
            //_appointmentViewPanel.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom);
            //AppointmentPanel.Controls.Add(_appointmentViewPanel);
            //_appointmentViewPanel.Dock = DockStyle.Fill;
            //_appointmentViewPanel.Visible = true;

            flowCalendarPanel.Controls.Add(_calendar);
            YearButton.Text = DateTime.Now.Year.ToString();
            _selectedMonth = DateTime.Now.Month;
            ChooseActiveButton(_selectedMonth).BackColor = ACTIVE_BUTTON_COLOR;

            flowCalendarPanel.Height -= 492;
            flowCalendarPanel.Hide();

            // To activate month buttons
            new List<Control> { ButtonJanuary, ButtonFebruary, ButtonMarch, ButtonApril,
            ButtonMay, ButtonJune, ButtonJuly, ButtonAugust, ButtonSeptember,
            ButtonOctober, ButtonNovember, ButtonDecember}.ForEach((Action<Control>)(x =>
            {
                x.Click += MonthButtonClick;
            }));

        }

        
        private void MonthButtonClick(object? sender, EventArgs e)
        {
            _selectedMonth = (sender as Button).TabIndex;
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }

        public void RefreshCalendar(int year, int month)
        { 
            var date = new DateTime(year, month, 1);
            _calendar.DisplayDays(date);
            SetMonthButtonActive(ChooseActiveButton(month));
            
        }

        private Button ChooseActiveButton(int index)
        {
            switch (index)
            {
                case 1:
                    return ButtonJanuary;
                case 2:
                    return ButtonFebruary;
                case 3:
                    return ButtonMarch;
                case 4:
                    return ButtonApril;
                case 5:
                    return ButtonMay;
                case 6:
                    return ButtonJune;
                case 7:
                    return ButtonJuly;
                case 8:
                    return ButtonAugust;
                case 9:
                    return ButtonSeptember;
                case 10:
                    return ButtonOctober;
                case 11:
                    return ButtonNovember;
                case 12:
                    return ButtonDecember;
            }
            return null;
        }

        // After clicking the month button it changes the color of selected button
        private void SetMonthButtonActive(Button activeButton)
        {
            foreach (Control item in MonthTablePanel.Controls)
            {
                if (item.GetType() == typeof(Button))
                    item.BackColor = NOT_ACTIVE_COLOR;
            }
            activeButton.BackColor = ACTIVE_BUTTON_COLOR;
        }

        //unnecessary
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        
        // For the year button to see the next years
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            
            YearButton.Text = (int.Parse(YearButton.Text) + 1).ToString();
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }

        // For the year button to see the previous years
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }

       
    }
}