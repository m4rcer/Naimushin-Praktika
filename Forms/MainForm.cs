using Naimushin.Helpers;
using Naimushin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Naimushin.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Data.Data.Path = "data.dat";
            Data.Data.Students = new List<Student>();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CheckDataFile(Data.Data.Path);
            AddStudentsToListView(Data.Data.Students);
            Data.Data.Index = Data.Data.Students.Count;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            Data.Data.AddedStudent = new Student();
            addStudentForm.ShowDialog();
        }

        private void CheckDataFile(string path)
        {
            if (!File.Exists(path))
            {
                DialogResult dataDialog =
                    MessageBox.Show("Файл с данными студентов не найден. Вы хотите загрузить встроенные в программу данные?",
                    "Данные студентов", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dataDialog == DialogResult.Yes)
                {
                    Data.Data.Students = Data.MockData.Students;
                    FileHelper.WriteStudentsToFile(path, Data.Data.Students);
                }
            }
            else
            {
                Data.Data.Students = FileHelper.ReadStudentsFromFile(path).ToList();
            }
        }

        private void GetYoungestStudent_Click(object sender, EventArgs e)
        {
            var maleStudents = Data.Data.Students.Where(student =>
                student.Gender == Genders.Male);
            var youngestStudent = maleStudents
                .Where(student => 
                student.DateOfBirth == maleStudents
                .Max(student => student.DateOfBirth))
                .FirstOrDefault();
            MessageBox.Show(youngestStudent == null ? "Студентов не найдено!": StringHelper.StudentToString(youngestStudent));
        }

        private void AddStudentsToListView(IEnumerable<Student> students)
        {
            StudentsListView.Items.Clear();
            foreach (var student in students)
            {
                StudentsListView.Items.Add(StringHelper.StudentToListViewItem(student));
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            AddStudentsToListView(Data.Data.Students);
            FileHelper.WriteStudentsToFile(Data.Data.Path, Data.Data.Students);
        }

        private void StudentsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (StudentsListView.SelectedItems.Count > 0)
            {
                var index = StudentsListView.SelectedItems[0].Index;
                var student = Data.Data.Students[index];
                Data.Data.AddedStudent = student;
                Data.Data.Index = index;
                var studentInfoForm = new StudentInfoForm();
                studentInfoForm.ShowDialog();
            }
        }

        private void PrintStudents_Click(object sender, EventArgs e)
        {
            if(Data.Data.Students.Count == 0)
            {
                MessageBox.Show("Студентов не найдено!");
                return;
            }
            var text = new StringBuilder();
            foreach(var student in Data.Data.Students)
            {
                text.AppendLine(StringHelper.StudentToString(student));
            }
            PrintHelper.Print(text.ToString());
        }
    }
}
