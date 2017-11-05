using System;
using System.Collections.Generic;
using UseOfInterface.Interfaces;

namespace UseOfInterface.Implementations
{
    class Department : IBasicInfo
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string Location { set; get; }

        //Use of interface all are useing same method name: GetBasicInfo : All are in same page
        public string GetBasicInfo()
        {
            return Location + " " + Name;
        }



        //Without Use of interface all are not useing same method name?? They are doing individually?
        //Effects: Method name chnage, return type chnage....
        public List<Department> MainInfo()
        {
            List<Department> _Course = new List<Department>()
            {
                new Department { Code = "CSE101", Name = "Shamim", Location = "NY" },
                new Department { Code = "CSE102", Name = "Hasan", Location = "LA" }
            };

            return _Course;
        }
    }
}
