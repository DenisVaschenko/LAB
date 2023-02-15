namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participants = new List<Participant>();
            participants.Add(new OrdinarParticipant("name1","6","school6","2"));
            participants.Add(new OrdinarParticipant("name2", "7", "school4", "1"));
            participants[1].GetDocument();
        }
        
    }
}
