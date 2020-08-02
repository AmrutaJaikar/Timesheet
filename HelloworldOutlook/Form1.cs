using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace HelloworldOutlook
{
    public partial class Form1 : Form
    {
        private String currentDate;
        public Form1(AppointmentItem appointmentItem)
        {
            InitializeComponent();
            dateTimePickerDate.Text = $"{appointmentItem.Start.Day}/{appointmentItem.Start.Month.ToString()}/{appointmentItem.Start.Year.ToString()}"; ;
            textBoxTaskDescription.Text = appointmentItem.Subject;
            dateTimePickerFromTime.Text= appointmentItem.Start.TimeOfDay.ToString();
            dateTimePickerToTime.Text = appointmentItem.End.TimeOfDay.ToString();
            int hours = (appointmentItem.End.TimeOfDay.Hours - appointmentItem.Start.TimeOfDay.Hours);
            int minutes= (appointmentItem.End.TimeOfDay.Minutes - appointmentItem.Start.TimeOfDay.Minutes);
            int seconds= (appointmentItem.End.TimeOfDay.Seconds - appointmentItem.Start.TimeOfDay.Seconds);
            labelHours.Text = hours + " : " + minutes + " : " + seconds;

        }
       

        private void dateTimePickerFromTime_ValueChanged(object sender, EventArgs e)
        {
            
            DateTimePicker picker = (DateTimePicker)sender;
            var ts = picker.Value;
            int hours = dateTimePickerToTime.Value.Hour - ts.Hour;
            int minutes = dateTimePickerToTime.Value.Minute - ts.Minute;
            int seconds = dateTimePickerToTime.Value.Second-ts.Second ;
            if (hours < 0 || minutes < 0 || seconds < 0 )
                MessageBox.Show("Meeting cannot end before its start time");
            else
            labelHours.Text = hours + " : " + minutes + " : " + seconds;
        }

        private void dateTimePickerToTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            if (picker == null) return;
            var ts = picker.Value;
            int hours = ts.Hour-dateTimePickerFromTime.Value.Hour ;
            int minutes =ts.Minute - dateTimePickerFromTime.Value.Minute;
            int seconds = ts.Second-dateTimePickerFromTime.Value.Second;
            if (hours < 0 || minutes < 0 || seconds < 0)
                MessageBox.Show("Meeting cannot end before its start time");
            else
            labelHours.Text = hours + " : " + minutes + " : " + seconds;
        }

      

       
        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void textBoxTaskDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBillable_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int flag = 1;

            if (dateTimePickerDate.Text == "" || dateTimePickerDate == null)
            {
                flag = 0;
                MessageBox.Show("Please enter a valid date");
            }
            if (comboBoxProject.Text == "" || comboBoxProject == null)
            {
                flag = 0;
                MessageBox.Show("Please choose a project");
            }
            if (textBoxTaskDescription.Text == "" || textBoxTaskDescription == null)
            {
                flag = 0;
                MessageBox.Show("Task Description cannot be empty");
            }
            if (dateTimePickerFromTime.Text == "" || dateTimePickerFromTime == null)
            {
                flag = 0;
                MessageBox.Show("Please enter a start time of meeting");
            }
            if (dateTimePickerToTime.Text == "" || dateTimePickerToTime == null)
            {
                flag = 0;
                MessageBox.Show("Please enter a start time of meeting");
            }

            if (flag == 1)
            {
                this.Close();
                MessageBox.Show("Timesheet entry successfully registered");
            }
        }
    }
}
