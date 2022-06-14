using Naimushin.Helpers;
using Naimushin.Models;
using System;
using System.Windows.Forms;

namespace Naimushin.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddGrades_Click(object sender, EventArgs e)
        {
            var addGradesForm = new AddGradesForm();
            addGradesForm.ShowDialog();
        }

        private void FillStudentData()
        {
            try
            {
                Data.Data.AddedStudent.Surname = SurnameTextBox.Text.Trim();
                Data.Data.AddedStudent.Name = NameTextBox.Text.Trim();
                Data.Data.AddedStudent.FathersName = FathersNameTextBox.Text.Trim();
                Data.Data.AddedStudent.DateOfBirth = DateOfBirthPicker.Value;
                Data.Data.AddedStudent.Gender = ManRadioButton.Checked ? Genders.Male : Genders.Female;
                if (Data.Data.Index == Data.Data.Students.Count)
                    Data.Data.Students.Add(Data.Data.AddedStudent);
                else
                    Data.Data.Students[Data.Data.Index] = Data.Data.AddedStudent;
                FileHelper.WriteStudentsToFile(Data.Data.Path, Data.Data.Students);
                Data.Data.isGradesFilled = false;
                Data.Data.Index = Data.Data.Students.Count;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введены неправильные данные!");
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (Data.Data.isGradesFilled)
            {
                FillStudentData();
            }
            else
            {
                MessageBox.Show("Необходимо заполнить оценки студента!");
            }
        }

        private void GenderRadioButton_Click(object sender, EventArgs e)
        {
            (ManRadioButton.Checked, WomanRadioButton.Checked) =
                (WomanRadioButton.Checked, ManRadioButton.Checked);
        }
    }
}
