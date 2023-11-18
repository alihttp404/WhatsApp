using WhatsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Models
{
    public class Conversation : NotificationService
    {
        private int conversationID;
        private int participant2ID;
        private int participant1ID;
        private int? lastMessageID;
        private User participant1;
        private User participant2;
        private ICollection<Message> messages;

        public int ConversationID { get => conversationID; set { conversationID = value;OnPropertyChanged();} }
        public int Participant2ID { get => participant2ID; set { participant2ID = value;OnPropertyChanged();} }
        public int Participant1ID { get => participant1ID; set { participant1ID = value;OnPropertyChanged();} }
        public int? LastMessageID { get => lastMessageID; set  { lastMessageID = value ;OnPropertyChanged();} }
        public User Participant1 { get => participant1; set { participant1 = value ; OnPropertyChanged(); } }
        public User Participant2 { get => participant2; set { participant2 = value; OnPropertyChanged(); } }
        public ICollection<Message> Messages { get => messages; set { messages = value; OnPropertyChanged(); } }
    }
}
