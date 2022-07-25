using System;
using System.Collections.Generic;
using System.Text;

namespace CharpFundamentals.Collections
{
    class LinqGroupBy
    {
        public class Student{
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<int> ExamScores { get; set; }

            public Student(int id,string firstname,string lastname,List<int> examscores)
            {
                this.ID = id;
                this.FirstName = firstname;
                this.LastName = lastname;
                this.ExamScores = examscores;
            }
            List<Student> student = new List<Student>()
            {
                new Student(1, "Raja", "Raj",new List<int>{24,10,35}),
                new Student(2, "Kumar","Kum", new List<int>{20,15,20 })
            };
    }
    }
}
