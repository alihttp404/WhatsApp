using WhatsApp.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatsApp.Models
{
    public class User : NotificationService
    {
        private ICollection<Conversation> conversations;
        private int userID;
        private string username;
        private string password;

        public ICollection<Conversation> Conversations { get => conversations; set { conversations = value; OnPropertyChanged(); } }
        public int UserID { get => userID; set { userID = value; OnPropertyChanged(); } }
        public string Username { get => username; set { username = value; OnPropertyChanged(); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }
    }
}
