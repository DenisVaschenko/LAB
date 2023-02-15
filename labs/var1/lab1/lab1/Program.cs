using System;
namespace lab1 
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Worker worker = new AdministrativeWorker();
            Console.WriteLine(worker.GetDuties()[0]);
        }
    }

}
