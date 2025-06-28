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
        public MyEvent newEvent { get; private set; } = null;
        public MyEvent EditingEvent { get; private set; } = null;
        public int[] prevTime = new int[5];
        public string prevName;
        public string prevDescr;
        public bool isEditMode = false;
        public bool nameChanged = false;
        public bool timeChanged = false;
        public bool descrChanged = false;

        // конструктор для створення події
        public EventForm()
        {
            InitializeComponent();
        }

        // для редагування
        public EventForm(MyEvent eventToEdit)
        {
            isEditMode = true;
            EditingEvent = eventToEdit;
            // збереження попередніх значень щоб відслідковувати зміни імені і дати
            prevName = EditingEvent.Name;
            prevTime = new int[] { EditingEvent.Day, EditingEvent.startHour, EditingEvent.startMin, EditingEvent.endHour, EditingEvent.endMin };

            InitializeComponent();
        }

        private void EventForm_Load(object sender1, EventArgs e1)
        {
            if (isEditMode && EditingEvent != null)
            {
                // заповнення полів значеннями з івенту
                Name_Change.DataBindings.Add("Text", EditingEvent, "Name");
                Descr_Change.DataBindings.Add("Text", EditingEvent, "Description");
                Loc_Change.DataBindings.Add("Text", EditingEvent, "Location");
                Details_Change.DataBindings.Add("Text", EditingEvent, "Details");

                Day_Change.DataBindings.Add("Value", EditingEvent, "Day");
                hourStart_Change.DataBindings.Add("Value", EditingEvent, "startHour");
                minStart_Change.DataBindings.Add("Value", EditingEvent, "startMin");
                hourEnd_Change.DataBindings.Add("Value", EditingEvent, "endHour");
                minEnd_Change.DataBindings.Add("Value", EditingEvent, "endMin");
            }
            else
            {
                Form2_Load(sender1, e1);
            }
        }

        // для ствроення
        private void Form2_Load(object sender, EventArgs e)
        {
            if (isEditMode == true)
            {
                EventForm_Load(sender, e);
            }
            else
            {
                try
                {
                    // Используем время из GlobalData только если оно было установлено вручную
                    if (GlobalData.IsTimeManuallySet)
                    {
                        Day_Change.Value = GlobalData.Current_Time1.setTimeDay;
                        hourStart_Change.Value = GlobalData.Current_Time1.setTimeHour;
                        minStart_Change.Value = GlobalData.Current_Time1.setTimeMin;
                    }
                    else
                    {
                        // Иначе используем текущее системное время
                        Day_Change.Value = DateTime.Now.Day;
                        hourStart_Change.Value = DateTime.Now.Hour;
                        minStart_Change.Value = DateTime.Now.Minute;
                    }

                    Day_Change.Minimum = Day_Change.Value;
                    hourStart_Change.Minimum = hourStart_Change.Value;
                    minStart_Change.Minimum = minStart_Change.Value;

                    if (hourStart_Change.Value == 23)
                    {
                        minEnd_Change.Value = 59;
                        hourEnd_Change.Value = 23;
                    }
                    else
                    {
                        hourEnd_Change.Value = hourStart_Change.Value + 1;
                        hourEnd_Change.Minimum = hourStart_Change.Value;

                        minEnd_Change.Value = minStart_Change.Value;
                        if (minStart_Change.Value + 30 > 59)
                        {

                        }
                        else if (minStart_Change.Value + 30 < 59)
                        {
                            minEnd_Change.Minimum = minStart_Change.Value + 30;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // якщо поточний час виходить за межі часу в який можна створити подію, використано мінімальні значення
                    if (ex != null)
                    {
                        Day_Change.Value = 23; // перший день тижня
                        hourStart_Change.Value = 4;
                        hourEnd_Change.Value = 5;
                        hourEnd_Change.Minimum = 4;
                        minStart_Change.Value = 0;
                        minEnd_Change.Value = 0;
                        minEnd_Change.Minimum = minStart_Change.Value;
                    }
                }
            }
        }

        private void hourEndChange_ValueChanged(object sender, EventArgs e)
        {
            // щоб можна було встановити тривалість меньше години
            if (hourStart_Change.Value == hourEnd_Change.Value && minStart_Change.Value + 30 < 59)
            {
                minEnd_Change.Minimum = minStart_Change.Value + 30;
                minEnd_Change.Value = minEnd_Change.Minimum;
            }
            else if (hourStart_Change.Value == hourEnd_Change.Value && hourStart_Change.Value != 23) // випадок переходу на наступну годину при доданні 30хв
            {
                hourEnd_Change.Minimum = hourStart_Change.Value + 1;
                hourEnd_Change.Value = hourEnd_Change.Minimum;
                minEnd_Change.Minimum = (minStart_Change.Value + 30) - 60;
                minEnd_Change.Value = minEnd_Change.Minimum;
            }
            else if (hourEnd_Change.Value == 23 && hourEnd_Change.Value == hourStart_Change.Value)
            {
                minEnd_Change.Value = 59;
                minEnd_Change.Minimum = 30;
                minStart_Change.Minimum = 0;
            }
        }

        private void hourStartChange_ValueChanged(object sender, EventArgs e)
        {
            minStart_Change.Minimum = 0;
            if (hourStart_Change.Value == hourEnd_Change.Value && minStart_Change.Value + 30 < 60)
            {
                minEnd_Change.Minimum = minStart_Change.Value + 30;
                minEnd_Change.Value = minEnd_Change.Minimum;
            }
            else if (hourStart_Change.Value == hourEnd_Change.Value) // випадок переходу на наступну годину при доданні 30хв
            {
                hourEnd_Change.Minimum = hourStart_Change.Value + 1;
                hourEnd_Change.Value = hourEnd_Change.Minimum;
                minEnd_Change.Minimum = (minStart_Change.Value + 30) - 60;
                minEnd_Change.Value = minEnd_Change.Minimum;
            }
        }
        private void DayChange_ValueChanged(object sender, EventArgs e)
        {
            Day_Change.Minimum = Day_Change.Value;
            // при зміні дня значення годин і хвилин скидаються до мінімальних
            hourStart_Change.Minimum = 4;
            hourEnd_Change.Minimum = 4;
            minStart_Change.Minimum = 0;
            minEnd_Change.Minimum = 0;
        }

        //public event EventHandler OkButtonClicked;

        //private void okButton_Click(object sender, EventArgs e)
        //{
        //    OkButtonClicked?.Invoke(this, EventArgs.Empty);
        //}

        // ok button
        public void eventEdit_okButton_Click(object sender, EventArgs e)
        {
            if (isEditMode == false)
            {
                // зберігаємо данні з полів форми
                string EventName = Name_Change.Text;
                string EventDescr = Descr_Change.Text;
                string EventLoc = Loc_Change.Text;
                string EventDet = Details_Change.Text;
                int EventDay = (int)Day_Change.Value;
                int EventStartHour = (int)hourStart_Change.Value;
                int EventEndHour = (int)hourEnd_Change.Value;
                int EventStartMin = (int)minStart_Change.Value;
                int EventEndMin = (int)minEnd_Change.Value;

                try
                {
                    newEvent = new MyEvent(EventDay, EventStartHour, EventStartMin, EventEndHour, EventEndMin, EventName, EventDescr, EventLoc, EventDet);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (ReservedNameException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ReservedTimeException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DurationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (EventsOverlapseException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                HandleEditMode(sender, e);
            }
        }

        private void HandleEditMode(object sender1, EventArgs e1)
        {
            int day = (int)Day_Change.Value;
            int hS = (int)hourStart_Change.Value;
            int hE = (int)hourEnd_Change.Value;
            int mS = (int)minStart_Change.Value;
            int mE = (int)minEnd_Change.Value;

            if (Name_Change.Text != prevName)
            {
                EditingEvent.Rename(prevName);
                nameChanged = true; // якщо змінено ім'я то треба переіменувати блок івенту
            }
            if (day != prevTime[0] || hS != prevTime[1] || mS != prevTime[2] || hE != prevTime[3] || mE != prevTime[4])
            {
                EditingEvent.ChangeTime(day, hS, hE, mS, mE);
                timeChanged = true;
            }
            if (Descr_Change.Text != prevDescr)
            {
                descrChanged = true;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
