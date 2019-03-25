using System;

namespace Application.Model.Notifications
{
    /// <summary>
    /// Represents response gotten from https://api.um.warszawa.pl/api regarding notification's status.
    /// </summary>
    public class NotificationStatusDto
    {
        public DateTime? changeDate { get; set; }
        public string status { get; set; }
        public string description { get; set; }
    }
}
