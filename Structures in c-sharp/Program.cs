using System;

namespace Structures_in_c_sharp
{
    struct Student
    {
        public int Sid;
        public string SName;
        public double SAvg;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.Sid = 1221;
            //s.SName = "Hans";
            //s.SAvg = 88.9;

            //Console.WriteLine("Sid:{0} \nName:{1} \nAverage:{2}",s.Sid,s.SName,s.SAvg);

            Student[] s = new Student[3];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Sid:");
                s[i].Sid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name:");
                s[i].SName = Console.ReadLine();
                Console.WriteLine("Enter Average:");
                s[i].SAvg = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Record:");
                Console.WriteLine("Sid:{0} \nName:{1} \nAverage:{2}", s[i].Sid, s[i].SName, s[i].SAvg);
            }




            Console.ReadLine();
        }
    }
}
