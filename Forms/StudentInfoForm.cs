using Naimushin.Helpers;
using System;
using System.Windows.Forms;

namespace Naimushin.Forms
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
            SurnameLabel.Text = Data.Data.AddedStudent.Surname;
            MathLabel.Text = StringHelper.GradeItemsToString(Data.Data.AddedStudent.Grades);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Data.Data.Students.RemoveAt(Data.Data.Index);
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
            this.Close();
        }
    }
}
