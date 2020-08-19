using System;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile profile1 = new DatingProfile("Brad", "Johnson", 22, "male");
            profile1.WriteBio("I Like Dogs.");

            DatingProfile profile2 = new DatingProfile("Erica", "Bennet", 24, "female");
            profile2.WriteBio("I Like Cats.");
            profile1.SendMessage("Hello", "How are you?", profile2);
            profile2.ReadMessage();
        }
    }
}
