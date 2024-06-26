﻿namespace RandomExamGenerator.WinFormsUI
{
    partial class InstructorView
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
            panel1 = new Panel();
            linkLabel5 = new LinkLabel();
            AddDept_btn = new LinkLabel();
            AddInstructor_btn = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            logoutLbl = new LinkLabel();
            InstCourses = new ListBox();
            panel2 = new Panel();
            AddQuestionsBtn = new Button();
            button1 = new Button();
            generateBtn = new Button();
            panel4 = new Panel();
            StudentsInCourseGrid = new DataGridView();
            panel3 = new Panel();
            UpdateCourseNameTxt = new TextBox();
            CourseName = new Label();
            UpadteBtn = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            linkLabel3 = new LinkLabel();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsInCourseGrid).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(AddDept_btn);
            panel1.Controls.Add(AddInstructor_btn);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(logoutLbl);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 53);
            panel1.TabIndex = 1;
            // 
            // linkLabel5
            // 
            linkLabel5.ActiveLinkColor = Color.DarkOrange;
            linkLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Candara", 12F, FontStyle.Bold);
            linkLabel5.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(495, 16);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(187, 24);
            linkLabel5.TabIndex = 6;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Manage Department";
            linkLabel5.LinkClicked += ManageDept_Click;
            // 
            // AddDept_btn
            // 
            AddDept_btn.ActiveLinkColor = Color.DarkOrange;
            AddDept_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDept_btn.AutoSize = true;
            AddDept_btn.Font = new Font("Candara", 12F, FontStyle.Bold);
            AddDept_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            AddDept_btn.LinkColor = Color.White;
            AddDept_btn.Location = new Point(312, 16);
            AddDept_btn.Name = "AddDept_btn";
            AddDept_btn.Size = new Size(150, 24);
            AddDept_btn.TabIndex = 5;
            AddDept_btn.TabStop = true;
            AddDept_btn.Text = "Manage Student";
            AddDept_btn.LinkClicked += ManageStudentClicked;
            // 
            // AddInstructor_btn
            // 
            AddInstructor_btn.ActiveLinkColor = Color.DarkOrange;
            AddInstructor_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddInstructor_btn.AutoSize = true;
            AddInstructor_btn.Font = new Font("Candara", 12F, FontStyle.Bold);
            AddInstructor_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            AddInstructor_btn.LinkColor = Color.White;
            AddInstructor_btn.Location = new Point(127, 16);
            AddInstructor_btn.Name = "AddInstructor_btn";
            AddInstructor_btn.Size = new Size(169, 24);
            AddInstructor_btn.TabIndex = 4;
            AddInstructor_btn.TabStop = true;
            AddInstructor_btn.Text = "Manage Instructor";
            AddInstructor_btn.LinkClicked += ManageInstructor_btn_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkOrange;
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Candara", 12F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(871, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(71, 24);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Location = new Point(1518, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // logoutLbl
            // 
            logoutLbl.ActiveLinkColor = Color.DarkOrange;
            logoutLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutLbl.AutoSize = true;
            logoutLbl.Font = new Font("Candara", 12F, FontStyle.Bold);
            logoutLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            logoutLbl.LinkColor = Color.White;
            logoutLbl.Location = new Point(1441, 9);
            logoutLbl.Name = "logoutLbl";
            logoutLbl.Size = new Size(71, 24);
            logoutLbl.TabIndex = 1;
            logoutLbl.TabStop = true;
            logoutLbl.Text = "Logout";
            // 
            // InstCourses
            // 
            InstCourses.FormattingEnabled = true;
            InstCourses.Location = new Point(40, 121);
            InstCourses.Margin = new Padding(2, 3, 2, 3);
            InstCourses.Name = "InstCourses";
            InstCourses.Size = new Size(186, 384);
            InstCourses.TabIndex = 2;
            InstCourses.SelectedIndexChanged += InstCourses_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddQuestionsBtn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(generateBtn);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(263, 121);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 385);
            panel2.TabIndex = 3;
            // 
            // AddQuestionsBtn
            // 
            AddQuestionsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddQuestionsBtn.BackColor = Color.DarkOrange;
            AddQuestionsBtn.Font = new Font("Candara", 12F, FontStyle.Bold);
            AddQuestionsBtn.ForeColor = Color.White;
            AddQuestionsBtn.Location = new Point(7, 341);
            AddQuestionsBtn.Name = "AddQuestionsBtn";
            AddQuestionsBtn.Size = new Size(138, 44);
            AddQuestionsBtn.TabIndex = 11;
            AddQuestionsBtn.Text = "AddQuestions";
            AddQuestionsBtn.UseVisualStyleBackColor = false;
            AddQuestionsBtn.Click += AddQuestionsBtnClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Candara", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(171, 341);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DeleteBtn;
            // 
            // generateBtn
            // 
            generateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            generateBtn.BackColor = Color.DarkOrange;
            generateBtn.Font = new Font("Candara", 12F, FontStyle.Bold);
            generateBtn.ForeColor = Color.White;
            generateBtn.Location = new Point(337, 341);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(149, 41);
            generateBtn.TabIndex = 9;
            generateBtn.Text = "Generate Exam";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(StudentsInCourseGrid);
            panel4.Location = new Point(2, 63);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(662, 251);
            panel4.TabIndex = 4;
            // 
            // StudentsInCourseGrid
            // 
            StudentsInCourseGrid.BackgroundColor = SystemColors.Window;
            StudentsInCourseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsInCourseGrid.Location = new Point(0, 0);
            StudentsInCourseGrid.Margin = new Padding(2, 3, 2, 3);
            StudentsInCourseGrid.Name = "StudentsInCourseGrid";
            StudentsInCourseGrid.ReadOnly = true;
            StudentsInCourseGrid.RowHeadersWidth = 62;
            StudentsInCourseGrid.Size = new Size(659, 251);
            StudentsInCourseGrid.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(UpdateCourseNameTxt);
            panel3.Controls.Add(CourseName);
            panel3.Controls.Add(UpadteBtn);
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(linkLabel3);
            panel3.Location = new Point(263, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 63);
            panel3.TabIndex = 2;
            // 
            // UpdateCourseNameTxt
            // 
            UpdateCourseNameTxt.Location = new Point(249, 25);
            UpdateCourseNameTxt.Margin = new Padding(2, 3, 2, 3);
            UpdateCourseNameTxt.Name = "UpdateCourseNameTxt";
            UpdateCourseNameTxt.Size = new Size(165, 27);
            UpdateCourseNameTxt.TabIndex = 5;
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Candara", 12F, FontStyle.Bold);
            CourseName.ForeColor = Color.White;
            CourseName.Location = new Point(96, 25);
            CourseName.Margin = new Padding(2, 0, 2, 0);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(123, 24);
            CourseName.TabIndex = 4;
            CourseName.Text = "Course Name";
            // 
            // UpadteBtn
            // 
            UpadteBtn.ActiveLinkColor = Color.DarkOrange;
            UpadteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpadteBtn.AutoSize = true;
            UpadteBtn.BackColor = Color.FromArgb(0, 0, 64);
            UpadteBtn.DisabledLinkColor = Color.FromArgb(0, 192, 0);
            UpadteBtn.Font = new Font("Candara", 12F, FontStyle.Bold);
            UpadteBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            UpadteBtn.LinkColor = Color.White;
            UpadteBtn.Location = new Point(453, 25);
            UpadteBtn.Name = "UpadteBtn";
            UpadteBtn.Size = new Size(72, 24);
            UpadteBtn.TabIndex = 3;
            UpadteBtn.TabStop = true;
            UpadteBtn.Text = "Update";
            UpadteBtn.LinkClicked += UpdateBtn;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.DarkOrange;
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Candara", 12F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(1223, 16);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(71, 24);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Logout";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1869, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.DarkOrange;
            linkLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Candara", 12F, FontStyle.Bold);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(1792, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(71, 24);
            linkLabel3.TabIndex = 1;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Logout";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Candara", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(40, 72);
            button2.Name = "button2";
            button2.Size = new Size(185, 44);
            button2.TabIndex = 12;
            button2.Text = "Add New Course";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddNewCourseClick;
            // 
            // InstructorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 591);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(InstCourses);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 3, 2, 3);
            Name = "InstructorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instrctor View";
            FormClosed += InstructorView_FormClosed;
            Load += InstructorView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentsInCourseGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private LinkLabel logoutLbl;
        private LinkLabel linkLabel1;
        private ListBox InstCourses;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel3;
        private LinkLabel UpadteBtn;
        private Label CourseName;
        private TextBox UpdateCourseNameTxt;
        private Panel panel4;
        private DataGridView StudentsInCourseGrid;
        private Button button1;
        private Button generateBtn;
        private Button AddQuestionsBtn;
        private Button button2;
        private LinkLabel AddInstructor_btn;
        private LinkLabel AddDept_btn;
        private LinkLabel linkLabel5;
    }
}