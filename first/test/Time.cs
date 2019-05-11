using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Time  //这个部分的任务由宋仪完成，主要是关于时间的静态方法在这里。供外部调用
    {
        private int week;//该时间在在该学期第几周，WeekOfYear的返回值为该日期在这一年的第几周，需要经过转化
        //week的值可能为WeekOfYear的返回值-10，该值我还没有进行调试，不知道是不是对的
        //本学期第一周为3月4日
        public static int Translate(DateTime T)  //根据输入时间获取这节课是每周的第几节课
        {
            Course C = new Course();

           

            //...
            return -1;
        }

        public static DateTime GetCurrentTime() //获取当前时间
        {
            //...
            return new DateTime();
        }
        public static DateTime StringToTime(String s)  //根据字符串输入转化为时间
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            return new DateTime();
        }


        // 求当前日期是一年的中第几周
        
        public static int WeekOfYear(DateTime curDay)
        {
            int firstdayofweek = Convert.ToInt32(Convert.ToDateTime(curDay.Year.ToString() + "-" + "1 - 1 ").DayOfWeek);
            int days = curDay.DayOfYear;
            int daysOutOneWeek = days - (7 - firstdayofweek);
            if (daysOutOneWeek <= 0)
            {
                return 1;
            }
            else
            {
                int weeks = daysOutOneWeek / 7;
                if (daysOutOneWeek % 7 != 0)
                    weeks++;
                return weeks + 1;
            }
        }

        //根据当前日期判断星期几
        public static int CalculateTime(System.Data.DataTable dt,int goalRow,DateTime curDay,string time)
        {
            //当前日期为星期几
            int week = Convert.ToInt32(curDay.DayOfWeek);
            if (week == 6 || week == 0)//星期六，星期天没有课，返回0（星期一,二,三,四,五,六,天的返回值分别为1,2,3,4,5,6,0）
                return 0;//占用直接返回0
            //周内我想的是根据计算，直接返回空闲时间，比如返回40，表示空闲40分钟，但是我卡在这儿了
           
            //...


        }
    }
}
