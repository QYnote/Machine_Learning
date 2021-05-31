
namespace Solo_Project
{
    partial class work_RFID_Card_Form
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
            this.BTN_UserSet_Insert = new System.Windows.Forms.Button();
            this.BTN_UserSet_Change = new System.Windows.Forms.Button();
            this.BTN_UserSet_Delete = new System.Windows.Forms.Button();
            this.TB_UserSet_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_UserSet_Department = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.User_Status = new System.Windows.Forms.TabPage();
            this.TB_UserSet_CardCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_UserSet_UserCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_UserSet = new System.Windows.Forms.ListView();
            this.columnHeader_UserSet_Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_UserSet_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_UserSet_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_UserSet_Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_UserSet_SecurityLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_UserSet_CardCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB_UserSet_Position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Card_Status = new System.Windows.Forms.TabPage();
            this.label_Card_Status = new System.Windows.Forms.Label();
            this.listView_CardSet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Card_Broke = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_Card_Insert = new System.Windows.Forms.Button();
            this.label_Card_CardCode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.User_Status.SuspendLayout();
            this.Card_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_UserSet_Insert
            // 
            this.BTN_UserSet_Insert.Font = new System.Drawing.Font("굴림", 12F);
            this.BTN_UserSet_Insert.Location = new System.Drawing.Point(24, 394);
            this.BTN_UserSet_Insert.Name = "BTN_UserSet_Insert";
            this.BTN_UserSet_Insert.Size = new System.Drawing.Size(75, 39);
            this.BTN_UserSet_Insert.TabIndex = 4;
            this.BTN_UserSet_Insert.Text = "추가";
            this.BTN_UserSet_Insert.UseVisualStyleBackColor = true;
            this.BTN_UserSet_Insert.Click += new System.EventHandler(this.BTN_UserSet_Insert_Click);
            // 
            // BTN_UserSet_Change
            // 
            this.BTN_UserSet_Change.Font = new System.Drawing.Font("굴림", 12F);
            this.BTN_UserSet_Change.Location = new System.Drawing.Point(104, 394);
            this.BTN_UserSet_Change.Name = "BTN_UserSet_Change";
            this.BTN_UserSet_Change.Size = new System.Drawing.Size(75, 39);
            this.BTN_UserSet_Change.TabIndex = 5;
            this.BTN_UserSet_Change.Text = "수정";
            this.BTN_UserSet_Change.UseVisualStyleBackColor = true;
            this.BTN_UserSet_Change.Click += new System.EventHandler(this.BTN_UserSet_Change_Click);
            // 
            // BTN_UserSet_Delete
            // 
            this.BTN_UserSet_Delete.Font = new System.Drawing.Font("굴림", 12F);
            this.BTN_UserSet_Delete.Location = new System.Drawing.Point(189, 394);
            this.BTN_UserSet_Delete.Name = "BTN_UserSet_Delete";
            this.BTN_UserSet_Delete.Size = new System.Drawing.Size(75, 39);
            this.BTN_UserSet_Delete.TabIndex = 6;
            this.BTN_UserSet_Delete.Text = "삭제";
            this.BTN_UserSet_Delete.UseVisualStyleBackColor = true;
            this.BTN_UserSet_Delete.Click += new System.EventHandler(this.BTN_UserSet_Delete_Click);
            // 
            // TB_UserSet_Name
            // 
            this.TB_UserSet_Name.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_UserSet_Name.Location = new System.Drawing.Point(136, 155);
            this.TB_UserSet_Name.Name = "TB_UserSet_Name";
            this.TB_UserSet_Name.Size = new System.Drawing.Size(170, 29);
            this.TB_UserSet_Name.TabIndex = 1;
            this.TB_UserSet_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(24, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "부서";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_UserSet_Department
            // 
            this.TB_UserSet_Department.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_UserSet_Department.Location = new System.Drawing.Point(136, 231);
            this.TB_UserSet_Department.Name = "TB_UserSet_Department";
            this.TB_UserSet_Department.Size = new System.Drawing.Size(170, 29);
            this.TB_UserSet_Department.TabIndex = 3;
            this.TB_UserSet_Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.User_Status);
            this.tabControl1.Controls.Add(this.Card_Status);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.TabIndex = 10;
            // 
            // User_Status
            // 
            this.User_Status.Controls.Add(this.TB_UserSet_CardCode);
            this.User_Status.Controls.Add(this.label1);
            this.User_Status.Controls.Add(this.TB_UserSet_UserCode);
            this.User_Status.Controls.Add(this.label2);
            this.User_Status.Controls.Add(this.listView_UserSet);
            this.User_Status.Controls.Add(this.TB_UserSet_Position);
            this.User_Status.Controls.Add(this.BTN_UserSet_Delete);
            this.User_Status.Controls.Add(this.BTN_UserSet_Change);
            this.User_Status.Controls.Add(this.label5);
            this.User_Status.Controls.Add(this.BTN_UserSet_Insert);
            this.User_Status.Controls.Add(this.TB_UserSet_Name);
            this.User_Status.Controls.Add(this.TB_UserSet_Department);
            this.User_Status.Controls.Add(this.label3);
            this.User_Status.Controls.Add(this.label4);
            this.User_Status.Font = new System.Drawing.Font("굴림", 9F);
            this.User_Status.Location = new System.Drawing.Point(4, 25);
            this.User_Status.Name = "User_Status";
            this.User_Status.Padding = new System.Windows.Forms.Padding(3);
            this.User_Status.Size = new System.Drawing.Size(792, 471);
            this.User_Status.TabIndex = 0;
            this.User_Status.Text = "직원 관리";
            this.User_Status.UseVisualStyleBackColor = true;
            // 
            // TB_UserSet_CardCode
            // 
            this.TB_UserSet_CardCode.Enabled = false;
            this.TB_UserSet_CardCode.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_UserSet_CardCode.Location = new System.Drawing.Point(136, 273);
            this.TB_UserSet_CardCode.Name = "TB_UserSet_CardCode";
            this.TB_UserSet_CardCode.Size = new System.Drawing.Size(170, 29);
            this.TB_UserSet_CardCode.TabIndex = 18;
            this.TB_UserSet_CardCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(24, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "카드 코드";
            // 
            // TB_UserSet_UserCode
            // 
            this.TB_UserSet_UserCode.Enabled = false;
            this.TB_UserSet_UserCode.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_UserSet_UserCode.Location = new System.Drawing.Point(136, 105);
            this.TB_UserSet_UserCode.Name = "TB_UserSet_UserCode";
            this.TB_UserSet_UserCode.Size = new System.Drawing.Size(170, 29);
            this.TB_UserSet_UserCode.TabIndex = 16;
            this.TB_UserSet_UserCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "유저 코드";
            // 
            // listView_UserSet
            // 
            this.listView_UserSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_UserSet_Num,
            this.columnHeader_UserSet_Name,
            this.columnHeader_UserSet_Position,
            this.columnHeader_UserSet_Department,
            this.columnHeader_UserSet_SecurityLevel,
            this.columnHeader_UserSet_CardCode});
            this.listView_UserSet.FullRowSelect = true;
            this.listView_UserSet.HideSelection = false;
            this.listView_UserSet.Location = new System.Drawing.Point(329, 47);
            this.listView_UserSet.Name = "listView_UserSet";
            this.listView_UserSet.Size = new System.Drawing.Size(442, 386);
            this.listView_UserSet.TabIndex = 15;
            this.listView_UserSet.UseCompatibleStateImageBehavior = false;
            this.listView_UserSet.View = System.Windows.Forms.View.Details;
            this.listView_UserSet.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_UserSet_ColumnClick);
            this.listView_UserSet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_UserSet_MouseDoubleClick);
            // 
            // columnHeader_UserSet_Num
            // 
            this.columnHeader_UserSet_Num.Text = "No.";
            this.columnHeader_UserSet_Num.Width = 45;
            // 
            // columnHeader_UserSet_Name
            // 
            this.columnHeader_UserSet_Name.Text = "이름";
            this.columnHeader_UserSet_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_UserSet_Name.Width = 90;
            // 
            // columnHeader_UserSet_Position
            // 
            this.columnHeader_UserSet_Position.Text = "직급";
            this.columnHeader_UserSet_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_UserSet_Position.Width = 70;
            // 
            // columnHeader_UserSet_Department
            // 
            this.columnHeader_UserSet_Department.Text = "부서";
            this.columnHeader_UserSet_Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_UserSet_Department.Width = 130;
            // 
            // columnHeader_UserSet_SecurityLevel
            // 
            this.columnHeader_UserSet_SecurityLevel.Text = "보안 등급";
            this.columnHeader_UserSet_SecurityLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_UserSet_SecurityLevel.Width = 70;
            // 
            // columnHeader_UserSet_CardCode
            // 
            this.columnHeader_UserSet_CardCode.Text = "카드 코드";
            this.columnHeader_UserSet_CardCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_UserSet_CardCode.Width = 120;
            // 
            // TB_UserSet_Position
            // 
            this.TB_UserSet_Position.Font = new System.Drawing.Font("굴림", 11F);
            this.TB_UserSet_Position.Location = new System.Drawing.Point(136, 196);
            this.TB_UserSet_Position.Name = "TB_UserSet_Position";
            this.TB_UserSet_Position.Size = new System.Drawing.Size(170, 29);
            this.TB_UserSet_Position.TabIndex = 2;
            this.TB_UserSet_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "직급";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Card_Status
            // 
            this.Card_Status.Controls.Add(this.label_Card_Status);
            this.Card_Status.Controls.Add(this.listView_CardSet);
            this.Card_Status.Controls.Add(this.BTN_Card_Broke);
            this.Card_Status.Controls.Add(this.label7);
            this.Card_Status.Controls.Add(this.BTN_Card_Insert);
            this.Card_Status.Controls.Add(this.label_Card_CardCode);
            this.Card_Status.Controls.Add(this.label10);
            this.Card_Status.Location = new System.Drawing.Point(4, 25);
            this.Card_Status.Name = "Card_Status";
            this.Card_Status.Padding = new System.Windows.Forms.Padding(3);
            this.Card_Status.Size = new System.Drawing.Size(792, 471);
            this.Card_Status.TabIndex = 1;
            this.Card_Status.Text = "카드 관리";
            this.Card_Status.UseVisualStyleBackColor = true;
            // 
            // label_Card_Status
            // 
            this.label_Card_Status.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Card_Status.Location = new System.Drawing.Point(171, 212);
            this.label_Card_Status.Name = "label_Card_Status";
            this.label_Card_Status.Size = new System.Drawing.Size(211, 19);
            this.label_Card_Status.TabIndex = 32;
            this.label_Card_Status.Text = "-";
            this.label_Card_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_CardSet
            // 
            this.listView_CardSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_CardSet.FullRowSelect = true;
            this.listView_CardSet.HideSelection = false;
            this.listView_CardSet.Location = new System.Drawing.Point(397, 42);
            this.listView_CardSet.Name = "listView_CardSet";
            this.listView_CardSet.Size = new System.Drawing.Size(387, 386);
            this.listView_CardSet.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_CardSet.TabIndex = 31;
            this.listView_CardSet.UseCompatibleStateImageBehavior = false;
            this.listView_CardSet.View = System.Windows.Forms.View.Details;
            this.listView_CardSet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_CardSet_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "코드";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "현황";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 50;
            // 
            // BTN_Card_Broke
            // 
            this.BTN_Card_Broke.Font = new System.Drawing.Font("굴림", 12F);
            this.BTN_Card_Broke.Location = new System.Drawing.Point(219, 290);
            this.BTN_Card_Broke.Name = "BTN_Card_Broke";
            this.BTN_Card_Broke.Size = new System.Drawing.Size(75, 39);
            this.BTN_Card_Broke.TabIndex = 2;
            this.BTN_Card_Broke.Text = "불량";
            this.BTN_Card_Broke.UseVisualStyleBackColor = true;
            this.BTN_Card_Broke.Click += new System.EventHandler(this.BTN_Card_Broke_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F);
            this.label7.Location = new System.Drawing.Point(43, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "카드 코드";
            // 
            // BTN_Card_Insert
            // 
            this.BTN_Card_Insert.Font = new System.Drawing.Font("굴림", 12F);
            this.BTN_Card_Insert.Location = new System.Drawing.Point(93, 290);
            this.BTN_Card_Insert.Name = "BTN_Card_Insert";
            this.BTN_Card_Insert.Size = new System.Drawing.Size(75, 39);
            this.BTN_Card_Insert.TabIndex = 1;
            this.BTN_Card_Insert.Text = "등록";
            this.BTN_Card_Insert.UseVisualStyleBackColor = true;
            this.BTN_Card_Insert.Click += new System.EventHandler(this.BTN_Card_Insert_Click);
            // 
            // label_Card_CardCode
            // 
            this.label_Card_CardCode.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Card_CardCode.Location = new System.Drawing.Point(171, 137);
            this.label_Card_CardCode.Name = "label_Card_CardCode";
            this.label_Card_CardCode.Size = new System.Drawing.Size(211, 19);
            this.label_Card_CardCode.TabIndex = 23;
            this.label_Card_CardCode.Text = "입력할 카드를 대주세요";
            this.label_Card_CardCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Card_CardCode.TextChanged += new System.EventHandler(this.label_Card_CardCode_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 11F);
            this.label10.Location = new System.Drawing.Point(43, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "현황";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // work_RFID_Card_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "work_RFID_Card_Form";
            this.Text = "work_RFID_Card_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.work_RFID_Card_Form_FormClosed);
            this.Load += new System.EventHandler(this.work_RFID_Card_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.User_Status.ResumeLayout(false);
            this.User_Status.PerformLayout();
            this.Card_Status.ResumeLayout(false);
            this.Card_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_UserSet_Insert;
        private System.Windows.Forms.Button BTN_UserSet_Change;
        private System.Windows.Forms.Button BTN_UserSet_Delete;
        private System.Windows.Forms.TextBox TB_UserSet_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_UserSet_Department;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage User_Status;
        private System.Windows.Forms.ListView listView_UserSet;
        private System.Windows.Forms.TextBox TB_UserSet_Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Card_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_Num;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_Department;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_Position;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_SecurityLevel;
        private System.Windows.Forms.ColumnHeader columnHeader_UserSet_CardCode;
        private System.Windows.Forms.Label label_Card_Status;
        private System.Windows.Forms.ListView listView_CardSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BTN_Card_Broke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_Card_Insert;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label_Card_CardCode;
        private System.Windows.Forms.TextBox TB_UserSet_UserCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TB_UserSet_CardCode;
    }
}