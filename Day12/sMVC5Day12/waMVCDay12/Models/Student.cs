using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waMVCDay12.Models
{
    public class Student
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public string Gender { get; set; }
        public int Ages { get; set; }

        public static List<Student> AmbilData()
        {
            List<Student> paket = new List<Student>();
            paket.Add(new Student() { Student_ID = 1, Student_Name = "Fuja", Ages = 24, Gender = "Male" });
            paket.Add(new Student() { Student_ID = 2, Student_Name = "Fuji", Ages = 25, Gender = "Male" });
            paket.Add(new Student() { Student_ID = 3, Student_Name = "Fujo", Ages = 26, Gender = "Male" });
            paket.Add(new Student() { Student_ID = 4, Student_Name = "Fuja", Ages = 27, Gender = "Male" });

            return paket;
        }
    }
}