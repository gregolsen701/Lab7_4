using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab7_4
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        public List<Messages> myMessages;

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void ReadMessage()
        {
            foreach(Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }

        public void AddToMessages(Messages message)
        {
            myMessages.Add(message);
        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile toProfile)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            toProfile.AddToMessages(message);
        }
    }
}
