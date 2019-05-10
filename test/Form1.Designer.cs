namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBtn5 = new System.Windows.Forms.Button();
            this.homeBtn4 = new System.Windows.Forms.Button();
            this.homeBtn3 = new System.Windows.Forms.Button();
            this.homeBtn2 = new System.Windows.Forms.Button();
            this.homeBtn1 = new System.Windows.Forms.Button();
            this.seatBtn4 = new System.Windows.Forms.Button();
            this.seatBtn3 = new System.Windows.Forms.Button();
            this.seatBtn2 = new System.Windows.Forms.Button();
            this.seatBtn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.floorShowBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upperFloorBtn = new System.Windows.Forms.Button();
            this.downFloorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.floorTogoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd ";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(108, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(152, 25);
            this.datePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择时间";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(295, 30);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(200, 25);
            this.timePicker.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.seatBtn4);
            this.panel1.Controls.Add(this.seatBtn3);
            this.panel1.Controls.Add(this.seatBtn2);
            this.panel1.Controls.Add(this.seatBtn1);
            this.panel1.Location = new System.Drawing.Point(71, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 563);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homeBtn5);
            this.panel2.Controls.Add(this.homeBtn4);
            this.panel2.Controls.Add(this.homeBtn3);
            this.panel2.Controls.Add(this.homeBtn2);
            this.panel2.Controls.Add(this.homeBtn1);
            this.panel2.Location = new System.Drawing.Point(592, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 563);
            this.panel2.TabIndex = 5;
            // 
            // homeBtn5
            // 
            this.homeBtn5.Location = new System.Drawing.Point(47, 415);
            this.homeBtn5.Name = "homeBtn5";
            this.homeBtn5.Size = new System.Drawing.Size(98, 54);
            this.homeBtn5.TabIndex = 4;
            this.homeBtn5.Text = "305";
            this.homeBtn5.UseVisualStyleBackColor = true;
            this.homeBtn5.Click += new System.EventHandler(this.HomeBtn5_Click);
            // 
            // homeBtn4
            // 
            this.homeBtn4.Location = new System.Drawing.Point(47, 319);
            this.homeBtn4.Name = "homeBtn4";
            this.homeBtn4.Size = new System.Drawing.Size(98, 54);
            this.homeBtn4.TabIndex = 3;
            this.homeBtn4.Text = "304";
            this.homeBtn4.UseVisualStyleBackColor = true;
            this.homeBtn4.Click += new System.EventHandler(this.HomeBtn4_Click);
            // 
            // homeBtn3
            // 
            this.homeBtn3.Location = new System.Drawing.Point(47, 228);
            this.homeBtn3.Name = "homeBtn3";
            this.homeBtn3.Size = new System.Drawing.Size(98, 54);
            this.homeBtn3.TabIndex = 2;
            this.homeBtn3.Text = "303";
            this.homeBtn3.UseVisualStyleBackColor = true;
            this.homeBtn3.Click += new System.EventHandler(this.HomeBtn3_Click);
            // 
            // homeBtn2
            // 
            this.homeBtn2.Location = new System.Drawing.Point(47, 141);
            this.homeBtn2.Name = "homeBtn2";
            this.homeBtn2.Size = new System.Drawing.Size(98, 54);
            this.homeBtn2.TabIndex = 1;
            this.homeBtn2.Text = "302";
            this.homeBtn2.UseVisualStyleBackColor = true;
            this.homeBtn2.Click += new System.EventHandler(this.HomeBtn2_Click);
            // 
            // homeBtn1
            // 
            this.homeBtn1.Location = new System.Drawing.Point(47, 53);
            this.homeBtn1.Name = "homeBtn1";
            this.homeBtn1.Size = new System.Drawing.Size(98, 54);
            this.homeBtn1.TabIndex = 0;
            this.homeBtn1.Text = "301";
            this.homeBtn1.UseVisualStyleBackColor = true;
            this.homeBtn1.Click += new System.EventHandler(this.HomeBtn1_Click);
            // 
            // seatBtn4
            // 
            this.seatBtn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seatBtn4.Location = new System.Drawing.Point(347, 291);
            this.seatBtn4.Name = "seatBtn4";
            this.seatBtn4.Size = new System.Drawing.Size(169, 82);
            this.seatBtn4.TabIndex = 4;
            this.seatBtn4.Text = "座位4 空闲";
            this.seatBtn4.UseVisualStyleBackColor = false;
            // 
            // seatBtn3
            // 
            this.seatBtn3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.seatBtn3.Location = new System.Drawing.Point(79, 291);
            this.seatBtn3.Name = "seatBtn3";
            this.seatBtn3.Size = new System.Drawing.Size(170, 82);
            this.seatBtn3.TabIndex = 3;
            this.seatBtn3.Text = "座位3 同学3 \r\n占用";
            this.seatBtn3.UseVisualStyleBackColor = false;
            // 
            // seatBtn2
            // 
            this.seatBtn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.seatBtn2.Location = new System.Drawing.Point(347, 111);
            this.seatBtn2.Name = "seatBtn2";
            this.seatBtn2.Size = new System.Drawing.Size(169, 84);
            this.seatBtn2.TabIndex = 2;
            this.seatBtn2.Text = "座位2 同学2 \r\n空闲45分钟";
            this.seatBtn2.UseVisualStyleBackColor = false;
            // 
            // seatBtn1
            // 
            this.seatBtn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.seatBtn1.Location = new System.Drawing.Point(79, 111);
            this.seatBtn1.Name = "seatBtn1";
            this.seatBtn1.Size = new System.Drawing.Size(170, 84);
            this.seatBtn1.TabIndex = 1;
            this.seatBtn1.Text = "座位1 同学2 \r\n空闲45分钟";
            this.seatBtn1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(974, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前";
            // 
            // floorShowBox
            // 
            this.floorShowBox.Location = new System.Drawing.Point(1017, 126);
            this.floorShowBox.Name = "floorShowBox";
            this.floorShowBox.ReadOnly = true;
            this.floorShowBox.Size = new System.Drawing.Size(39, 25);
            this.floorShowBox.TabIndex = 8;
            this.floorShowBox.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1074, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "层";
            // 
            // upperFloorBtn
            // 
            this.upperFloorBtn.Location = new System.Drawing.Point(965, 207);
            this.upperFloorBtn.Name = "upperFloorBtn";
            this.upperFloorBtn.Size = new System.Drawing.Size(141, 61);
            this.upperFloorBtn.TabIndex = 10;
            this.upperFloorBtn.Text = "上一层";
            this.upperFloorBtn.UseVisualStyleBackColor = true;
            this.upperFloorBtn.Click += new System.EventHandler(this.UpperFloorBtn_Click);
            // 
            // downFloorBtn
            // 
            this.downFloorBtn.Location = new System.Drawing.Point(965, 339);
            this.downFloorBtn.Name = "downFloorBtn";
            this.downFloorBtn.Size = new System.Drawing.Size(141, 61);
            this.downFloorBtn.TabIndex = 11;
            this.downFloorBtn.Text = "下一层";
            this.downFloorBtn.UseVisualStyleBackColor = true;
            this.downFloorBtn.Click += new System.EventHandler(this.DownFloorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(962, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "输入楼层查询：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(962, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "查看";
            // 
            // floorTogoBox
            // 
            this.floorTogoBox.Location = new System.Drawing.Point(1017, 514);
            this.floorTogoBox.Name = "floorTogoBox";
            this.floorTogoBox.Size = new System.Drawing.Size(39, 25);
            this.floorTogoBox.TabIndex = 14;
            this.floorTogoBox.Text = "3";
            this.floorTogoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloorTogoBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1084, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "层";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(965, 620);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(141, 61);
            this.query.TabIndex = 16;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Query_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 769);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.floorTogoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downFloorBtn);
            this.Controls.Add(this.upperFloorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floorShowBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeBtn5;
        private System.Windows.Forms.Button homeBtn4;
        private System.Windows.Forms.Button homeBtn3;
        private System.Windows.Forms.Button homeBtn2;
        private System.Windows.Forms.Button homeBtn1;
        private System.Windows.Forms.Button seatBtn4;
        private System.Windows.Forms.Button seatBtn3;
        private System.Windows.Forms.Button seatBtn2;
        private System.Windows.Forms.Button seatBtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floorShowBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upperFloorBtn;
        private System.Windows.Forms.Button downFloorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox floorTogoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button query;
    }
}

