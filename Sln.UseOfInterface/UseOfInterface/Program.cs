using System;
using UseOfInterface.Implementations;
using UseOfInterface.Interfaces;

namespace UseOfInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student _Student1 = new Student()
            {
                Name = "Rahim",
                Email = "e1@mail.com",
                RegNo = "R-205"
            };


            string info = _Student1.GetBasicInfo();

            Department _Department = new Department();
            info = _Department.GetBasicInfo();

            Course _Course = new Course();
            info = _Course.GetBasicInfo();


            IBasicInfo i = _Course;
            i.GetBasicInfo();

           

            DisplayBasicInfo(_Student1);
            DisplayBasicInfo(_Course);
            DisplayBasicInfo(_Department);

            Console.ReadLine();
        }

        public static void DisplayBasicInfo(IBasicInfo _IBasicInfo)
        {
            Console.WriteLine(_IBasicInfo.GetBasicInfo());
        }


    }
}
