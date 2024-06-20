using Microsoft.Maui.Controls;
using Syncfusion.Maui.Scheduler;

namespace Calendrier
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void AddEvent_Clicked(object sender, EventArgs e)
        {
            // Retrieve user inputs for start time
            DateTime startDate = startDatePicker.Date;
            TimeSpan startTime = startTimePicker.Time;
            DateTime eventStartTime = startDate.Date + startTime;

            // Retrieve user inputs for end time
            DateTime endDate = endDatePicker.Date;
            TimeSpan endTime = endTimePicker.Time;
            DateTime eventEndTime = endDate.Date + endTime;

            string subject = subjectEntry.Text;

            // Create new appointment and send it as a message
            var newAppointment = new SchedulerAppointment
            {
                StartTime = eventStartTime,
                EndTime = eventEndTime,
                Subject = subject,
                Background = Colors.Blue // Example color, adjust as needed
            };

            MessagingCenter.Send(this, "AddAppointment", newAppointment);
            Navigation.PopModalAsync();
        }
    }
}
