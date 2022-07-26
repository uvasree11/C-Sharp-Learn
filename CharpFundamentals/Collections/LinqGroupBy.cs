using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharpFundamentals.Collections
{
    public class LinqGroupBy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        


        public LinqGroupBy(int id,string name,int mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }

    }
    public class student
    {
        public List<LinqGroupBy> StdList { get; set; }
        public student()
        {
            StdList = new List<LinqGroupBy>()
            {
                new LinqGroupBy(1,"uvi",100),
                new LinqGroupBy(2,"sree",100),
                new LinqGroupBy(3,"uvi",70)
            };
        }

        public void linqGB()
        {
            var listStd = from std in StdList
                          group std by std.Name into result
                          orderby result.Key
                          select result;
            foreach (var lstd in listStd)
            {

                foreach (var student in lstd)
                {

                    Console.WriteLine(student.Name);
                }
            }


        }

        public void grpbyValue()
        {
            var lstgbv = from std in StdList
                         group std by std.Name[0];
                        
            foreach(var lst in lstgbv)
            {
                Console.WriteLine($"Key: { lst.Key}");
                foreach (var lststd in lst)
                {
                    Console.WriteLine($"Name: {lststd.Name}");
                }
            }
        }
        public void grpByComparison()
        {
            var lstgbr = from std in StdList
                         group new { std.Id, std.Name } by std.Mark > 50 into result
                         select result;
            foreach (var lst in lstgbr)
            {
                Console.WriteLine($"Key: { lst.Key}");
                foreach (var lststd in lst)
                {
                    Console.WriteLine($"Name: {lststd.Name}");
                    Console.WriteLine($"Name: {lststd.Id}");
                }
            }
        }
        public void grpByRange()
        {
            var lstgbr = from std in StdList
                         group new { std.Id, std.Name } by (double)std.Mark/3 > 0 ? (int)std.Mark/3 / 10 : 0 into result
                         select result;
            foreach (var lst in lstgbr)
            {
                Console.WriteLine($"Key: { lst.Key}");
                foreach (var lststd in lst)
                {
                    Console.WriteLine($"Name: {lststd.Name}");
                    Console.WriteLine($"id: {lststd.Id}");
                }
            }
        }
    }
}
