using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Course  //这个部分的任务由宋仪完成，主要是关于课程的基类 属性已经在类中定义了，可能需要另外的构造函数
                        //这个其实就是xls的每个小格子的元素
    {
        
        private int numOfCourse;  //这节课是本周第几节课 由Time里的静态函数计算 每周总共25节课
       
        private String nameofCourse;  //课程名
        private int startOfWeeks;
        private int endOfWeeks;     //这节课是从第几周到第几周
        private int numOfStudents;  //学生人数
        private String idOfCourse;  //课程ID   这个属性是指的每一行的中的位置
        private String nameOfTeacher;   //老师姓名



        public int NumOfCourse { get => numOfCourse; set => numOfCourse = value; }
      
        public int StartOfWeeks { get => startOfWeeks; set => startOfWeeks = value; }
        public int EndOfWeeks { get => endOfWeeks; set => endOfWeeks = value; }
        public int NumOfStudents { get => numOfStudents; set => numOfStudents = value; }
        public string NameOfTeacher { get => nameOfTeacher; set => nameOfTeacher = value; }
        public string NameofCourse { get => nameofCourse; set => nameofCourse = value; }
        public string IdOfCourse { get => idOfCourse; set => idOfCourse = value; }

      
    }
}
