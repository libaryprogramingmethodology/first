using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class CClass  //  //这个部分的任务由宋仪完成，班级 我们默认每一行就是一个班级
    {
        private String nameOfClass; //班级的信息，如：旅行社151105
        private List<Course> listOfCourses;  //每节课程
        private int sumOfCourse;
        //private String idOfClass;
        private int GoalRow;//目标在dt中的行数

        public string NameOfClass { get => nameOfClass; set => nameOfClass = value; }
        public int SumOfCourse { get => sumOfCourse; set => sumOfCourse = value; }
        //public string IdOfClass { get => idOfClass; set => idOfClass = value; }


        //判断该班级的课表在dt中的位置，从第三行开始（表格中编号为5），前两行为表头，如：旅行社151105在dt的第三行
        public int GoalRow(string nameofClass)//返回目标行数
        {          
            for (goalRow = 3; goalRow <= dt.Rows.Count; goalRow++)//从dt的第一个班级开始遍历，直到找到编码，如旅行社151105，goalRow=3，
            {
                string temp = System.Text.RegularExpressions.Regex.Replace((string)dt.Rows[goalRow][0], @"[^0-9]+", "");
                if (goal == temp)
                    break;
            }
            return goalRow;

        }

        
        //所有信息都在dt表中，我觉得可以直接查询计算，这块我不知道怎么写比较合适
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
