using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace weekly_planer
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        public string EventName { get; private set; }
        public int EventStartHour { get; private set; }
        public int EventEndHour { get; private set; }
        public int EventStartMin { get; private set; }
        public int EventEndMin { get; private set; }
        public int EventDay { get; private set; }
        public string EventDescr { get; private set; }
        public string EventLoc { get; private set; }
        public string EventDet { get; private set; }



        private void Form2_Load(object sender, EventArgs e)
        {
            DayChange.Value = DateTime.Now.Day;
            DayChange.Minimum = DayChange.Value;

            hourStartChange.Value = DateTime.Now.Hour;
            hourEndChange.Value = hourStartChange.Value + 1;
            hourStartChange.Minimum = hourStartChange.Value;
            hourEndChange.Minimum = hourStartChange.Value;

            minStartChange.Value = DateTime.Now.Minute;
            minEndChange.Value = minStartChange.Value;
            minStartChange.Minimum = minStartChange.Value;






        }

        private void hourEndChange_ValueChanged(object sender, EventArgs e)
        {
            if (hourStartChange.Value == hourEndChange.Value && minStartChange.Value + 30 < 60)
            {
                minEndChange.Minimum = minStartChange.Value + 30;
                minEndChange.Value = minEndChange.Minimum;
            }
            else if (hourStartChange.Value == hourEndChange.Value)
            {
                hourEndChange.Minimum = hourStartChange.Value + 1;
                hourEndChange.Value = hourEndChange.Minimum;
                minEndChange.Minimum = (minStartChange.Value + 30) - 60;
                minEndChange.Value = minEndChange.Minimum;
            }

        }









        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        // нужно разделить создание нового ивента и ред старого чтоб подставлять предыдущ значения
        // бмля тут же еще нужно знать какой ивент ред



        // ok button
        public void event_edit_btn_ok_Click(object sender, EventArgs e)
        {
            // Сохраняем данные из полей формы
            EventName = NameChange.Text;
            EventDescr = DescriptionChange.Text;
            EventLoc = loc.Text;
            EventDet = DetailsChange.Text;
            EventDay = (int)DayChange.Value;
            EventStartHour = (int)hourStartChange.Value;
            EventEndHour = (int)hourEndChange.Value;
            EventStartMin = (int)minStartChange.Value;
            EventEndMin = (int)minEndChange.Value;

            MyEvent newEvent = null;
            try
            {
                newEvent = new MyEvent(EventName, EventDay, EventStartHour, EventStartMin, EventEndHour, EventEndMin, EventDescr, EventLoc, EventDet);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DurationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EventsOverlapseException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ReservedNameException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ReservedTimeException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
