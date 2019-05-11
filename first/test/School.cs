using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace test
{
    class School     //把xls的所以信息读取进来，并存到dt中
    {
        //public  List<CClass> listOfClass;  //每个班级
        private int sumOfClass;

        public List<VIP> listOfVIP;   //所有的学生，这里宋仪不要写！！！我来写这一块 这是整合的时候需要用的，整个系统会构造这一个School，学生个数和学生所属专业我们到时候需要随机生成

        public int SumOfClass { get => sumOfClass; set => sumOfClass = value; }

        

        public void ReadClass()  
        {
            //读取excel表
            string dir = Path.GetFullPath("../..");//课程总表所在目录为执行文件其上上一级
            string FileName =dir+ "\\课程总表.xls";//实际目录   
            System.Data.DataTable dt =COMImpExcel(FileName);//将excel表中数据存储到DataTable中           
            

        }

        //读取excel表格，将数据存储在DataTable dt中，返回dt
        public static System.Data.DataTable COMImpExcel(string fileName)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                Microsoft.Office.Interop.Excel.Application app;
                Microsoft.Office.Interop.Excel.Workbooks wbs;
                Microsoft.Office.Interop.Excel.Worksheet ws;
                object oMissiong = System.Reflection.Missing.Value;
                app = new Microsoft.Office.Interop.Excel.Application();  //lauch excel application
                wbs = app.Workbooks;
                wbs.Open(fileName, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                ws = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);    //取得第一个工作薄
                int rows = ws.UsedRange.Rows.Count;
                int columns = ws.UsedRange.Columns.Count;
                dt.TableName = ws.Name;

                for (int i = 1; i <= rows; i++)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    for (int j = 1; j <= columns; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range range = ws.Range[app.Cells[i, j], app.Cells[i, j]];
                        range.Select();
                        if (i == 1)                                  //读取列头
                        {
                            string colName = app.ActiveCell.Text.ToString();
                            if (dt.Columns.Contains(colName))                      //是否存在重复列名
                            {
                                dt.Columns.Add(colName + j);
                            }
                            else { dt.Columns.Add(colName); }
                        }
                        dr[j - 1] = app.ActiveCell.Text.ToString();
                    }
                    dt.Rows.Add(dr);
                }

                app.Quit(); app = null;
                System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("excel");
                foreach (System.Diagnostics.Process pro in procs)
                {
                    pro.Kill();    //没有更好的方法,只有杀掉进程
                }
                GC.Collect();
                dt.Rows.RemoveAt(0);       //上面那样写把列名也读进去了，在这里移除一下。也可以在上面把读列名单独出来
                return dt;
            }
            catch (Exception ex)
            {
                return null;//throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("excel读取完成");
            }
            
        }
    }
}
