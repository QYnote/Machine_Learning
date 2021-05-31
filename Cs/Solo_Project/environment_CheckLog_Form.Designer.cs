
namespace Solo_Project
{
    partial class environment_CheckLog_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_Log = new System.Windows.Forms.ListView();
            this.comboBox_LogList = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_StartTime = new System.Windows.Forms.ComboBox();
            this.comboBox_EndTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Allday = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Log
            // 
            this.listView_Log.HideSelection = false;
            this.listView_Log.Location = new System.Drawing.Point(426, 27);
            this.listView_Log.Name = "listView_Log";
            this.listView_Log.Size = new System.Drawing.Size(347, 445);
            this.listView_Log.TabIndex = 0;
            this.listView_Log.UseCompatibleStateImageBehavior = false;
            this.listView_Log.View = System.Windows.Forms.View.Details;
            // 
            // comboBox_LogList
            // 
            this.comboBox_LogList.Font = new System.Drawing.Font("굴림", 11F);
            this.comboBox_LogList.FormattingEnabled = true;
            this.comboBox_LogList.Items.AddRange(new object[] {
            "온습도",
            "희망 온습도",
            "출입문"});
            this.comboBox_LogList.Location = new System.Drawing.Point(117, 175);
            this.comboBox_LogList.Name = "comboBox_LogList";
            this.comboBox_LogList.Size = new System.Drawing.Size(121, 26);
            this.comboBox_LogList.TabIndex = 1;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(147, 83);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_EndDate.TabIndex = 2;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(117, 52);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_StartDate.TabIndex = 3;
            // 
            // comboBox_StartTime
            // 
            this.comboBox_StartTime.Enabled = false;
            this.comboBox_StartTime.Font = new System.Drawing.Font("굴림", 11F);
            this.comboBox_StartTime.FormattingEnabled = true;
            this.comboBox_StartTime.Location = new System.Drawing.Point(199, 114);
            this.comboBox_StartTime.Name = "comboBox_StartTime";
            this.comboBox_StartTime.Size = new System.Drawing.Size(48, 26);
            this.comboBox_StartTime.TabIndex = 4;
            this.comboBox_StartTime.Text = "00";
            // 
            // comboBox_EndTime
            // 
            this.comboBox_EndTime.Enabled = false;
            this.comboBox_EndTime.Font = new System.Drawing.Font("굴림", 11F);
            this.comboBox_EndTime.FormattingEnabled = true;
            this.comboBox_EndTime.Location = new System.Drawing.Point(282, 114);
            this.comboBox_EndTime.Name = "comboBox_EndTime";
            this.comboBox_EndTime.Size = new System.Drawing.Size(48, 26);
            this.comboBox_EndTime.TabIndex = 5;
            this.comboBox_EndTime.Text = "24";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(253, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // checkBox_Allday
            // 
            this.checkBox_Allday.AutoSize = true;
            this.checkBox_Allday.Checked = true;
            this.checkBox_Allday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Allday.Location = new System.Drawing.Point(117, 118);
            this.checkBox_Allday.Name = "checkBox_Allday";
            this.checkBox_Allday.Size = new System.Drawing.Size(75, 19);
            this.checkBox_Allday.TabIndex = 7;
            this.checkBox_Allday.Text = "All Day";
            this.checkBox_Allday.UseVisualStyleBackColor = true;
            this.checkBox_Allday.CheckedChanged += new System.EventHandler(this.checkBox_Allday_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(118, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "기간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "목록";
            // 
            // BTN_Select
            // 
            this.BTN_Select.Font = new System.Drawing.Font("굴림", 11F);
            this.BTN_Select.Location = new System.Drawing.Point(183, 233);
            this.BTN_Select.Name = "BTN_Select";
            this.BTN_Select.Size = new System.Drawing.Size(75, 34);
            this.BTN_Select.TabIndex = 11;
            this.BTN_Select.Text = "검색";
            this.BTN_Select.UseVisualStyleBackColor = true;
            this.BTN_Select.Click += new System.EventHandler(this.BTN_Select_Click);
            // 
            // environment_CheckLog_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BTN_Select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Allday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_EndTime);
            this.Controls.Add(this.comboBox_StartTime);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.comboBox_LogList);
            this.Controls.Add(this.listView_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "environment_CheckLog_Form";
            this.Text = "environment_CheckLog_Form";
            this.Load += new System.EventHandler(this.environment_CheckLog_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Log;
        private System.Windows.Forms.ComboBox comboBox_LogList;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.ComboBox comboBox_StartTime;
        private System.Windows.Forms.ComboBox comboBox_EndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Allday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Select;
    }
}