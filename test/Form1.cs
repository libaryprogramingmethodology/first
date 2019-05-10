using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form 
        //到这里为止 韩帅和宋仪工作的部分没有重合，所以可以大胆放心写
        //这个是程序的界面 也是最难的部分 由韩帅和我一起完成，需要实现的功能主要有：
        //1.初始化界面预留一个初始化模型的函数
        //2.生成多个可选择页面
        //3.若干可移动的按钮
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Init_Info()   //预处理函数 我来写
        {


        }


        private int maxFloor = 9;

        private String getDate()
        {
            /// 获取当前所选日期
            return this.datePicker.Text;
        }

        private String getTime()
        {
            /// 获取当前所选时间
            return this.timePicker.Text;
        }

        private String getFloor()
        {
            /// 获取用户输入楼层
            return this.floorTogoBox.Text;
        }

        private String getSystemFloor()
        {
            /// 获取系统显示楼层
            return this.floorShowBox.Text;
        }

        private void refreshFloor(String floor)
        {
            /// 刷新floorShowBox中的显示内容
            this.floorShowBox.Text = floor;
        }

        private void refreshHome(int _floor)
        {
            /// 刷新homeBtn1~5
            this.homeBtn1.Text = Convert.ToString(_floor * 100 + 1);
            this.homeBtn2.Text = Convert.ToString(_floor * 100 + 2);
            this.homeBtn3.Text = Convert.ToString(_floor * 100 + 3);
            this.homeBtn4.Text = Convert.ToString(_floor * 100 + 4);
            this.homeBtn5.Text = Convert.ToString(_floor * 100 + 5);
        }

        /// 变量说明：
        ///   --变量名中数字对应第几个座位
        ///   --seatState有三个可选值{"BUSY", "NOT_BUSY", "FREE"},分别表示座位有人占、有人占但人在上课、未分配三种情况
        ///   --对应seatState的三个可选值，seatInfo格式如下：
        ///      1、"BUSY"："座位x-同学A 占用"
        ///      2、"NOT_BUSY"："座位x-同学B 空闲xx分钟"
        ///      3、"FREE"："座位x 未分配"
        ///   
        private String seatInfo1 = "";
        private String seatState1 = "";

        private String seatInfo2 = "";
        private String seatState2 = "";

        private String seatInfo3 = "";
        private String seatState3 = "";

        private String seatInfo4 = "";
        private String seatState4 = "";

        private void refreshSeat()
        {
            /// 显示房间1中的座位占用情况
            /// 这组样例测试用
            seatInfo1 = "座位1-同学A 占用";
            seatState1 = "BUSY";

            seatInfo2 = "座位2-同学B 空闲45分钟";
            seatState2 = "NOT_BUSY";

            seatInfo3 = "座位3 未分配";
            seatState3 = "FREE";

            seatInfo4 = "座位4-同学C 占用";
            seatState4 = "BUSY";

            this.seatBtn1.Text = seatInfo1;
            this.seatBtn2.Text = seatInfo2;
            this.seatBtn3.Text = seatInfo3;
            this.seatBtn4.Text = seatInfo4;

            /// 根据状态对按钮颜色进行调整
            if (seatState1 == "BUSY")
            {
                this.seatBtn1.BackColor = System.Drawing.Color.Green;
            }
            else if (seatState1 == "NOT_BUSY")
            {
                this.seatBtn1.BackColor = System.Drawing.Color.Blue;
            }
            else if (seatState1 == "FREE")
            {
                this.seatBtn1.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                this.seatBtn1.BackColor = System.Drawing.Color.Black;
            }

            if (seatState2 == "BUSY")
            {
                this.seatBtn2.BackColor = System.Drawing.Color.Green;
            }
            else if (seatState2 == "NOT_BUSY")
            {
                this.seatBtn2.BackColor = System.Drawing.Color.Blue;
            }
            else if (seatState2 == "FREE")
            {
                this.seatBtn2.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                this.seatBtn2.BackColor = System.Drawing.Color.Black;
            }

            if (seatState3 == "BUSY")
            {
                this.seatBtn3.BackColor = System.Drawing.Color.Green;
            }
            else if (seatState3 == "NOT_BUSY")
            {
                this.seatBtn3.BackColor = System.Drawing.Color.Blue;
            }
            else if (seatState3 == "FREE")
            {
                this.seatBtn3.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                this.seatBtn3.BackColor = System.Drawing.Color.Black;
            }

            if (seatState4 == "BUSY")
            {
                this.seatBtn4.BackColor = System.Drawing.Color.Green;
            }
            else if (seatState4 == "NOT_BUSY")
            {
                this.seatBtn4.BackColor = System.Drawing.Color.Blue;
            }
            else if (seatState4 == "FREE")
            {
                this.seatBtn4.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                this.seatBtn4.BackColor = System.Drawing.Color.Black;
            }

        }


        private void Query_MouseDown(object sender, MouseEventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：“查询”按钮被点击
            /// 对应事务流程：
            ///     1、获取datePicker、timePicker中的时间。(已完成)
            ///     2、将datePicker、timePicker中的时间转化为方便查询的格式。
            ///     3、获取当前楼层数。(已完成)
            ///     4、根据楼层数刷新homeBtn1~5、floorShowBox中的显示内容。(已完成)
            ///     5、根据时间、当前房间信息查询座位占用情况。
            ///     6、根据查询信息，默认显示房间1中的座位占用情况。
            /// </summary>

            /// 1、获取datePicker、timePicker中的时间。
            String _date = this.getDate();    //日期字符串格式：xxxx-xx-xx(2019-05-09)
            String _time = this.getTime();    //时间字符串格式：xx:xx:xx(1:42:33)

            /// 2、将datePicker、timePicker中的时间转化为方便查询的格式。

            /// ##################################################################################################
            /// #                                                                                                #
            /// #                           如果需要，可以在这对时间格式进行转换                                 #
            /// #                                                                                                #
            /// ##################################################################################################

            /// 3、获取当前楼层数。
            String floor = getFloor();  //FloorTogoBox_KeyPress()限制此内容必能转为正整数
            int _floor = int.Parse(floor);          

            /// 4、根据楼层数刷新homeBtn1~5、floorShowBox中的显示内容。
            this.refreshFloor(floor);
            this.refreshHome(_floor);

            /// 5、根据时间、当前房间信息查询座位占用情况。
            /// 需要将查询结果更新至seatInfo、seatState等成员变量中
            /// ##################################################################################################
            /// #                                                                                                #
            /// #                                    查询的逻辑写在这                                            #
            /// #                                                                                                #
            /// ################################################################################################## 

            /// 6、根据查询信息，默认显示房间1中的座位占用情况。
            this.refreshSeat();

        }

        private void FloorTogoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>
            /// 键盘事件函数。
            /// 处理事件：限制用户输入合法内容（正整数）
            /// 对应事务流程：
            ///     
            /// </summary>
            if (e.KeyChar != '\b') //允许退格
            {
                Console.WriteLine(e.KeyChar);
                int len = floorTogoBox.Text.Length;
                if (len < 1 && e.KeyChar == '0')  //首位不为0
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar < '0') || (e.KeyChar > '9'))  //输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void queryByRoom(String room)
        {
            /// <summary>
            /// 根据房间号查询
            /// 对应事务流程：
            ///     1、获取楼层、时间。
            ///     2、根据楼层、时间、房间号查询。
            ///     3、根据查询信息，显示房间中的座位占用情况。
            /// </summary>
            String floor = this.getSystemFloor();
            String _date = this.getDate();    //日期字符串格式：xxxx-xx-xx(2019-05-09)
            String _time = this.getTime();    //时间字符串格式：xx:xx:xx(1:42:33)

            /// 2、根据楼层、时间、房间号查询。
            /// 需要将查询结果更新至seatInfo、seatState等成员变量中
            /// ##################################################################################################
            /// #                                                                                                #
            /// #                                    查询的逻辑写在这                                            #
            /// #                                                                                                #
            /// ################################################################################################## 
            /// 

            /// 3、根据查询信息，显示房间中的座位占用情况。
            this.refreshSeat();
        }

        private void HomeBtn1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：房间号被点击
            /// 对应事务流程：
            ///     1、获取房间号。
            ///     2、根据房间号查询。
            /// </summary>


            ///  1、获取房间号。
            String floor = this.getSystemFloor();
            String room = Convert.ToString(int.Parse(floor) * 100 + 1);
            ///  2、根据房间号查询。
            this.queryByRoom(room);

        }

        private void HomeBtn2_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：房间号被点击
            /// 对应事务流程：
            ///     1、获取房间号。
            ///     2、根据房间号查询。
            /// </summary>

            ///  1、获取房间号。
            String floor = this.getSystemFloor();
            String room = Convert.ToString(int.Parse(floor) * 100 + 2);

            ///  2、根据房间号查询。
            this.queryByRoom(room);
        }

        private void HomeBtn3_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：房间号被点击
            /// 对应事务流程：
            ///     1、获取房间号。
            ///     2、根据房间号查询。
            /// </summary>

            ///  1、获取房间号。
            String floor = this.getSystemFloor();
            String room = Convert.ToString(int.Parse(floor) * 100 + 3);

            ///  2、根据房间号查询。
            this.queryByRoom(room);
        }

        private void HomeBtn4_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：房间号被点击
            /// 对应事务流程：
            ///     1、获取房间号。
            ///     2、根据房间号查询。
            /// </summary>

            ///  1、获取房间号。
            String floor = this.getSystemFloor();
            String room = Convert.ToString(int.Parse(floor) * 100 + 4);

            ///  2、根据房间号查询。
            this.queryByRoom(room);
        }

        private void HomeBtn5_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：房间号被点击
            /// 对应事务流程：
            ///     1、获取房间号。
            ///     2、根据房间号查询。
            /// </summary>

            ///  1、获取房间号。
            String floor = this.getSystemFloor();
            String room = Convert.ToString(int.Parse(floor) * 100 + 5);

            ///  2、根据房间号查询。
            this.queryByRoom(room);

        }

        private void UpperFloorBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：上一层按钮被点击
            /// 对应事务流程：
            ///     1、根据楼层数刷新homeBtn1~5、floorShowBox中的显示内容。
            ///     2、默认查询房间号为第一个房间的信息。
            /// </summary>

            /// 1、根据楼层数刷新homeBtn1~5、floorShowBox中的显示内容。
            String floor = this.floorShowBox.Text;
            int _floor = int.Parse(floor);
            if (_floor < maxFloor)
            {
                _floor = _floor + 1;
            }
            this.refreshFloor(Convert.ToString(_floor));
            this.refreshHome(_floor);

            /// 2、默认查询房间号为第一个房间的信息。
            String room = Convert.ToString(_floor * 100 + 1);
            this.queryByRoom(room);
        }

        private void DownFloorBtn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 鼠标事件函数。
            /// 处理事件：下一层按钮被点击
            /// 对应事务流程：
            ///     1、根据楼层数刷新homeBtn1~5、floorShowBox中的显示内容。
            ///     2、默认查询房间号为第一个房间的信息。
            /// </summary>
            String floor = this.floorShowBox.Text;
            int _floor = int.Parse(floor);
            if (_floor > 1)
            {
                _floor = _floor - 1;
            }
            this.refreshFloor(Convert.ToString(_floor));
            this.refreshHome(_floor);

            /// 2、默认查询房间号为第一个房间的信息。
            String room = Convert.ToString(_floor * 100 + 1);
            this.queryByRoom(room);
        }
    }
}
