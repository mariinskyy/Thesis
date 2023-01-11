using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopJournal
{
    public partial class DayBlank : UserControl
    {
        private DateTime _currentDate;
        private Color _backColor;
        private List<Appointment> _appointments;

        public DayBlank()
        {
            InitializeComponent();
        }

        public void Refresh(Color backColor, int day, DateTime date, Color foreColor)
        {
            BackColor = _backColor = backColor;
            dayNumber.Text = day.ToString();
            _currentDate = date;
            if (_currentDate.ToShortDateString() == DateTime.Now.ToShortDateString())
                BackColor = Color.FromArgb(255, 255, 159, 67);

            dayNumber.ForeColor = foreColor;
            _appointments = SQL.GetAppointments(date);

            int appointmentCount = _appointments.Count;
            int completedCount = _appointments.Where(x => x.IsCompleted).Count();
            int activeCount = appointmentCount - completedCount;

            // If the appointment is completed or active:
            CompletedAppointmentLabel.Text = completedCount < 10 ? '0' + completedCount.ToString() : completedCount.ToString();
            ActiveAppointmentLabel.Text = activeCount < 10 ? '0' + activeCount.ToString() : activeCount.ToString();

            CompletedAppointmentPanel.Visible = completedCount > 0 ? true : false;
            ActiveAppointmentPanel.Visible = activeCount > 0 ? true : false;
        }

        private void dayNumber_Click(object sender, EventArgs e)
        {

        }

        private void DayBlank_Load(object sender, EventArgs e)
        {
            new List<Control> { dayNumber , AddAppointmentButton, ActiveAppointmentLabel,ActiveAppointmentPanel,
            CompletedAppointmentLabel,CompletedAppointmentPanel, this}.ForEach(x =>
            {
                x.MouseClick += DayBlankControl_MouseClick;
                x.MouseClick += DayBlank_MouseEnter;
                x.MouseClick += DayBlank_MouseLeave;
                
            });
        }

        private void DayBlank_MouseLeave(object? sender, MouseEventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                AddAppointmentButton.Visible = false;
                BackColor = _backColor;
            }
        }

        private void DayBlank_MouseEnter(object? sender, MouseEventArgs e)
        {
            AddAppointmentButton.Visible = true;
            BackColor = Color.FromArgb(123, _backColor);
        }

        private void DayBlankControl_MouseClick(object? sender, MouseEventArgs e)
        {
            //ActiveAppointmentPanel.Visible = true;
            //ActiveAppointmentLabel.Text = (int.Parse(ActiveAppointmentLabel.Text) + 1).ToString();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointmentButton.Visible = false;
            BackColor = _backColor;
            new NewAppointmentForm(_currentDate, null).ShowDialog();

        }
    }
}
