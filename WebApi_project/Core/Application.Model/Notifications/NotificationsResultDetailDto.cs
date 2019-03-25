using System.Collections.Generic;

namespace Application.Model.Notifications
{
    public class NotificationsResultDetailDto
    {
        public IList<NotificationDto> notifications { get; set; }
        public string responseDesc { get; set; }
        public string responseCode { get; set; }
    }
}
