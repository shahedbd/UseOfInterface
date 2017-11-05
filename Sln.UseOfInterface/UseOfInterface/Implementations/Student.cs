using System;
using System.Collections.Generic;
using UseOfInterface.Interfaces;

namespace UseOfInterface.Implementations
{
    class Student : IBasicInfo
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string RegNo { set; get; }


        //Use of interface all are useing same method name: GetBasicInfo : All are in same page
        public string GetBasicInfo()
        {
            return Name + " " + Email + " " + RegNo;
        }



        //Without Use of interface all are not useing same method name?? They are doing individually?
        //Effects: Method name chnage, return type chnage....
        public IEnumerable<Student> Infos()
        {
            List<Student> _Student = new List<Student>()
            {
                new Student { Name = "Jamal", Email = "e1@gmail.com", RegNo = "R-105" },
                new Student { Name = "Kamal", Email = "e2@gmail.com", RegNo = "R-106" },
                new Student { Name = "Rahim", Email = "e3@gmail.com", RegNo = "R-107" }
            };

            return _Student;
        }

    }
}
