using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Code_First.Entity;

namespace EF_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "New Student" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.Write("Done");
            Console.Read();
        }
    }
}
