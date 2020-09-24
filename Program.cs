using System;
using System.Collections.Generic;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program n = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.View all student ");
                Console.WriteLine("3.Search Student ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        n.AddStudent();
                        break;
                    case 2:
                        n.ViewAllStudent();
                        break;
                    case 3:
                        n.SearchStudent();
                        break;
                    case 4:
                        return;
                        
                }
            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void AddStudent()
        {
            ClassStudent student = new ClassStudent();
            student.ID = count;
            Console.WriteLine("Nhap fullname :");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Nhap DateofBirth :");
            student.DateofBirth = DateTime.Parse(Console.ReadLine()); ;
            Console.WriteLine("Nhap Native :");
            student.Native = Console.ReadLine();
            Console.WriteLine("Nhap Class : ");
           student.Class = Console.ReadLine();
            Console.WriteLine("Nhap PhoneNo : ");
            student.PhoneNo = Console.ReadLine();
            Console.WriteLine("Nhap Mobile : ");
            student.Mobile = int.Parse(Console.ReadLine());
            ListStudent.Add(count, student);
            count++;
        }
        public void ViewAllStudent()
        {
            foreach (ClassStudent item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void SearchStudent()
        {
            Console.WriteLine("Nhap ten Student: ");
            string name = Console.ReadLine();
            foreach (ClassStudent item in ListStudent.Values)
             if (item.FullName.Equals(name))
                    item.Display();
            
                else Console.WriteLine("Khong tim thay ten");
            
        }
    }
}