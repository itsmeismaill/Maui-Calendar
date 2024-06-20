using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics; // for Color
using Syncfusion.Maui.Scheduler; // Ensure you have the correct namespace for SchedulerAppointment

namespace Calendrier
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddEvent_Clicked(object sender, EventArgs e)
        {
            var modalPage = new ModalPage();
            modalPage.BindingContext = BindingContext; // Pass the same binding context

            // Subscribe to the message sent from ModalPage
            MessagingCenter.Subscribe<ModalPage, SchedulerAppointment>(this, "AddAppointment", (sender, arg) =>
            {
                if (arg != null)
                {
                    var viewModel = (ControlViewModel)BindingContext;
                    viewModel.AddAppointment(arg.StartTime, arg.EndTime, arg.Subject);
                }
            });

            Navigation.PushModalAsync(modalPage);
        }
    }
}
