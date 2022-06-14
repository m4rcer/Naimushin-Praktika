
namespace Naimushin.Forms
{
    partial class MainForm
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
            this.StudentsListView = new System.Windows.Forms.ListView();
            this.FullName = new System.Windows.Forms.ColumnHeader();
            this.DateOfBirth = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.AddStudent = new System.Windows.Forms.Button();
            this.GetYoungestStudent = new System.Windows.Forms.Button();
            this.PrintStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsListView
            // 
            this.StudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FullName,
            this.DateOfBirth,
            this.Gender});
            this.StudentsListView.HideSelection = false;
            this.StudentsListView.Location = new System.Drawing.Point(-2, 151);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.Size = new System.Drawing.Size(681, 412);
            this.StudentsListView.TabIndex = 0;
            this.StudentsListView.UseCompatibleStateImageBehavior = false;
            this.StudentsListView.View = System.Windows.Forms.View.Details;
            this.StudentsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StudentsListView_MouseDoubleClick);
            // 
            // FullName
            // 
            this.FullName.Text = "Полное имя";
            this.FullName.Width = 400;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "Дата рождения";
            this.DateOfBirth.Width = 150;
            // 
            // Gender
            // 
            this.Gender.Text = "Пол";
            this.Gender.Width = 120;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(12, 34);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(214, 89);
            this.AddStudent.TabIndex = 1;
            this.AddStudent.Text = "Добавить студента";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // GetYoungestStudent
            // 
            this.GetYoungestStudent.Location = new System.Drawing.Point(434, 34);
            this.GetYoungestStudent.Name = "GetYoungestStudent";
            this.GetYoungestStudent.Size = new System.Drawing.Size(214, 89);
            this.GetYoungestStudent.TabIndex = 2;
            this.GetYoungestStudent.Text = "Информация о самом молодом студенте";
            this.GetYoungestStudent.UseVisualStyleBackColor = true;
            this.GetYoungestStudent.Click += new System.EventHandler(this.GetYoungestStudent_Click);
            // 
            // PrintStudents
            // 
            this.PrintStudents.Location = new System.Drawing.Point(254, 34);
            this.PrintStudents.Name = "PrintStudents";
            this.PrintStudents.Size = new System.Drawing.Size(159, 89);
            this.PrintStudents.TabIndex = 2;
            this.PrintStudents.Text = "Печать";
            this.PrintStudents.UseVisualStyleBackColor = true;
            this.PrintStudents.Click += new System.EventHandler(this.PrintStudents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 561);
            this.Controls.Add(this.PrintStudents);
            this.Controls.Add(this.GetYoungestStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.StudentsListView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(682, 617);
            this.MinimumSize = new System.Drawing.Size(682, 617);
            this.Name = "MainForm";
            this.Text = "Мониторинг студентов";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StudentsListView;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button GetYoungestStudent;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.Button PrintStudents;
    }
}