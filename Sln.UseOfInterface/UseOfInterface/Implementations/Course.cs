using System;
using UseOfInterface.Interfaces;

namespace UseOfInterface.Implementations
{
    class Course : IBasicInfo,IPrinting
    {
        public string Title { set; get; }
        public string Code { set; get; }
        public double Credit { set; get; }


        //Use of interface all are useing same method name: GetBasicInfo: All are in same page
        public string GetBasicInfo()
        {
            return Title + " " + Code + " " + Credit.ToString();
        }


        //Without Use of interface all are not useing same method name?? They are doing individually?
        //Effects: Method name chnage, return type chnage....
        public Course BasicInfo()
        {
            Course _Course = new Course();
            return _Course;
        }


        public void Print()
        {
            throw new NotImplementedException();
        }

        public void CancelPrinting(int jobNo)
        {
            throw new NotImplementedException();
        }
    }
}
