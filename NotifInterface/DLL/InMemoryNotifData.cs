using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationInterface.DLL
{
    public class InMemoryNotifData
    {
        public class UserRepository
        {
            public List<User> _users;

            public UserRepository()
            {
                _users = new List<User>
        {
            
        };
            }

            public User GetUserByName(string name)
            {
#pragma warning disable CS8603 
                return _users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
#pragma warning restore CS8603 
            }
        }

        public class NotificationRepository
        {
          
            public List<Notification> _notifications;

            public NotificationRepository()
            {
                _notifications = new List<Notification>();

                
            }

            public void SaveNotification(Notification notification)
            {
                _notifications.Add(notification);
            }
            
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public User()
            {
                Name = string.Empty;
            }
        }

        public class Notification
        {
            public int StudentId { get; set; }
            public User senderName { get; set; }
            public User receiverName { get; set; }
            public string Content { get; set; }
            public DateTime DateTime { get; set; }
            public bool IsRead { get; set; }
            public Notification()
            {
                senderName = new User();
                receiverName = new User();
                Content = string.Empty;
                DateTime = DateTime.MinValue;
            }
        }
    }
}
