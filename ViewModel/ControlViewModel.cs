using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Graphics; // for Colors
using Syncfusion.Maui.Scheduler;

namespace Calendrier
{
    public class ControlViewModel
    {
        public ObservableCollection<SchedulerAppointment> SchedulerEvents { get; }

        public ControlViewModel()
        {
            SchedulerEvents = new ObservableCollection<SchedulerAppointment>
            {
                new SchedulerAppointment
                {
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddHours(2),
                    Subject = "Playing football",
                    Background = Colors.Red
                }
            };
        }

        public void AddAppointment(DateTime startTime, DateTime endTime, string subject)
        {
            SchedulerEvents.Add(new SchedulerAppointment
            {
                StartTime = startTime,
                EndTime = endTime,
                Subject = subject,
                Background = Colors.Red
            });
        }
    }
}
