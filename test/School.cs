using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class School     //学校 这个部分由宋仪完成，需要做的事情是把xls的所以信息读取进来，并存到listOfClass中
    {
        public  List<CClass> listOfClass;  //每个班级
        private int sumOfClass;

        public List<VIP> listOfVIP;   //所有的学生，这里宋仪不要写！！！我来写这一块 这是整合的时候需要用的，整个系统会构造这一个School，学生个数和学生所属专业我们到时候需要随机生成

        public int SumOfClass { get => sumOfClass; set => sumOfClass = value; }

        public void ReadClass()  //为了程序的可移植性，读取的xls必须是当前路径，不能额外更改路径我已经拷贝到项目中去了 这里很复杂  辛苦宋仪了！
        {

            //...

        }
    }
}
