using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
                new Student {ClassName = "软工一班", StudentName = "康巴一", StuId = 1},
                new Student {ClassName = "软工一班", StudentName = "康巴二", StuId = 2},
                new Student {ClassName = "软工一班", StudentName = "康巴三", StuId = 3},
                new Student {ClassName = "软工二班", StudentName = "康定一", StuId = 4},
                new Student {ClassName = "软工二班", StudentName = "康定二", StuId = 5},
                new Student {ClassName = "软工二班", StudentName = "康定三", StuId = 6},
            };
           var studentGroup = studentList.GroupBy(s => s.ClassName);
            foreach (var item in studentGroup)
            {
                var list = studentList.Where(t => t.ClassName == item.Key).ToList();
                Base.Log.Log4Net.GetLog4Net().WriteLog("DEBUG", "FileURL:"+item.Key);
            }
        }
    }
    public class Student
    {
        public int StuId { get; set; }

        public string ClassName { get; set; }

        public string StudentName { get; set; }
    }
}
