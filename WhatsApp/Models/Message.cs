using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Services;

namespace WhatsApp.Models
{
    public class Message : NotificationService
    {
        private int messageID;
        private int senderID;
        private int receiverID;
        private string content;
        private DateTime timestamp;
        private User sender;
        private User receiver;

        public int MessageID { get => messageID; set { messageID = value; OnPropertyChanged(); } }
        public int SenderID { get => senderID; set { senderID = value; OnPropertyChanged(); } }
        public int ReceiverID { get => receiverID; set { receiverID = value; OnPropertyChanged(); } }
        public string Content { get => content; set { content = value; OnPropertyChanged(); } }
        public DateTime Timestamp { get => timestamp; set { timestamp = value; OnPropertyChanged(); } }
        public User Sender { get => sender; set { sender = value; OnPropertyChanged(); } }
        public User Receiver { get => receiver; set { receiver = value; OnPropertyChanged(); } }
    }
}
