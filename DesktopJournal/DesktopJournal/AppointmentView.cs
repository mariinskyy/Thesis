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
    public partial class AppointmentView : UserControl
    {
        private Appointment _appointment;
        public AppointmentView(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            FillAppointment(appointment.Title, appointment.Description);
            ContextMenuStrip = CreateMenu();
        }

        private ContextMenuStrip CreateMenu()
        {
            var contextMenuStrip = new ContextMenuStrip();

            var editAppointment = new ToolStripMenuItem();
            editAppointment.Text = "Edit";
            editAppointment.Click += EditAppointment_Click;

            var deleteAppointment = new ToolStripMenuItem();
            deleteAppointment.Text = "Delete";
            deleteAppointment.Click += DeleteAppointment_Click;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editAppointment, deleteAppointment });
            return contextMenuStrip;
        }

        private void DeleteAppointment_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the appointment?", "Important!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                SQL.ExecuteQuery("delete from Appointments where ID =" + _appointment.ID);
                Singleton.Instance.Form1.RefreshCalendar(_appointment.EndDate.Year, _appointment.EndDate.Month);
            }
        }

        private void EditAppointment_Click(object? sender, EventArgs e)
        {
            var editAppointment = new NewAppointmentForm(_appointment.EndDate, _appointment);
            editAppointment.ShowDialog();
        }

        public void FillAppointment(string title, string description)
        {
            label1.Text = title;
            label2.Text = description;

            if(_appointment.IsCompleted)
            {
                label1.ForeColor = Color.MediumSpringGreen;
                label1.Text = "Done: " + _appointment.Result + Environment.NewLine + label1.Text;
            }

            var titleHeight = TextRenderer.MeasureText(title, new Font("Bahnschrift", 13f), new Size(210, 30), 
                TextFormatFlags.WordBreak).Height;
            var descriptionHeight = TextRenderer.MeasureText(description, new Font("Bahnschrift", 10f), 
                new Size(210, 60), TextFormatFlags.WordBreak).Height;

            descriptionHeight = descriptionHeight > 100 ? descriptionHeight + 60 : descriptionHeight + 30;
            titleHeight = titleHeight > 20 ? titleHeight + 40 : titleHeight + 20;
            titleHeight = titleHeight > 100 ? titleHeight + 60 : titleHeight + 30;

            label1.Height = titleHeight;

            Height = label1.Height + descriptionHeight;
        }
    }
}
