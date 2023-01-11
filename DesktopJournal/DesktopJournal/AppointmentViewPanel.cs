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
    public partial class AppointmentViewPanel : UserControl
    {
        public AppointmentViewPanel()
        {
            InitializeComponent();
        }

        public void FillView(List<Appointment> appointments)
        {
            panel1.Controls.Clear();
            foreach (var item in appointments)
            {
                var appointment = new AppointmentView(item);
                appointment.Dock = DockStyle.Top;
                panel1.Controls.Add(appointment);
            }
            dateTimePicker1.Value = appointments[0].EndDate;
        }
    }
}
