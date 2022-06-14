using Naimushin.Models;
using System;
using System.Windows.Forms;

namespace Naimushin.Forms
{
    public partial class AddGradesForm : Form
    {
        public AddGradesForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddGrades_Click(object sender, EventArgs e)
        {
            try
            {
                var grades = new GradeItem[]
                {
                        new GradeItem
                        {
                            Subject = Subjects.Math,
                            Grade = int.Parse(MathTextBox.Text)
                        },
                        new GradeItem
                        {
                            Subject = Subjects.Programming,
                            Grade = int.Parse(ProgrammingTextBox.Text)
                        },
                        new GradeItem
                        {
                            Subject = Subjects.Physics,
                            Grade = int.Parse(PhysicsTextBox.Text)
                        },
                        new GradeItem
                        {
                            Subject = Subjects.Russian,
                            Grade = int.Parse(RussianTextBox.Text)
                        },
                        new GradeItem
                        {
                            Subject = Subjects.English,
                            Grade = int.Parse(EnglishTextBox.Text)
                        },
                };
                Data.Data.AddedStudent.Grades = grades;
                Data.Data.isGradesFilled = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введены неправильные данные.");
            }
        }
    }
}
