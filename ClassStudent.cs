using System;

namespace Practical4
{
    internal class ClassStudent
    {
       public string FullName {
            get;
            set;
        }
      public   int ID{
         get;
        set;   
        }
     public   DateTime DateofBirth  {
            set;
            get;

        }
     public   string Native{
            get;
            set;
        }
     public   string Class {
            get;
            set;
        }
     public   string PhoneNo{
            get;
            set;
        }
     public   int Mobile{
            set;
            get;
        }
        public ClassStudent(string Fullname,int Id,DateTime Dateofbirth,string Native,string Class,string Phoneno,int Mobile){
            this.FullName = FullName;
            this.ID = ID;
            this.DateofBirth = DateofBirth;
            this.Native = Native;
            this.Class = Class;
            this.PhoneNo = PhoneNo;
            this.Mobile = Mobile;
        }

        public ClassStudent()
        {
        }

        public void Display()
        {
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("FullName:" + FullName);
            Console.WriteLine("DateofBith:" + DateofBirth);
            Console.WriteLine("Native:" + Native);
            Console.WriteLine("Class:" + Class);
            Console.WriteLine("PhoneNo:" + PhoneNo);
            Console.WriteLine("MoNile:" + Mobile);

        }
    }
}