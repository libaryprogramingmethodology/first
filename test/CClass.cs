using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class CClass  //  //这个部分的任务由宋仪完成，班级 我们默认每一行就是一个班级
    {
        private String nameOfClass; //班级
        private List<Course> listOfCourses;  //每节课程
        private int sumOfCourse;
        private String idOfClass;

        public string NameOfClass { get => nameOfClass; set => nameOfClass = value; }
        public int SumOfCourse { get => sumOfCourse; set => sumOfCourse = value; }
        public string IdOfClass { get => idOfClass; set => idOfClass = value; }

        public void AddCourse()
        {

        }
        public Course GetCourse(int index)
        {
            //...
            return new Course();
        }


        public bool IsInClass(DateTime T)   //根据时间判断是否有课正在上的方法
        {

            //...
            return false;
        }
    }
}
