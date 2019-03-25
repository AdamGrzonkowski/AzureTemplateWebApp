using System;
using System.Collections.Generic;

namespace Application.Model.Notifications
{
    /// <summary>
    /// Represents response gotten from https://api.um.warszawa.pl/api.
    /// </summary>
    public class NotificationDto
    {
        public string siebelEventId { get; set; }
        public string deviceType { get; set; }
        public string street { get; set; }
        public string street2 { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string apartmentNumber { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public string Event { get; set; }
        public DateTime? createDate { get; set; }
        public string notificationNumber { get; set; }
        public double? xCoordWGS84 { get; set; }
        public double? yCoordWGS84 { get; set; }
        public double? xCoordOracle { get; set; }
        public double? yCoordOracle { get; set; }
        public string notificationType { get; set; }
        public string source { get; set; }

        private IList<NotificationStatusDto> statuses { get; set; }
    }
}
