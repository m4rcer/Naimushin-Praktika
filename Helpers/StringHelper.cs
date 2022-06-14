using Naimushin.Models;
using System.Text;
using System.Windows.Forms;

namespace Naimushin.Helpers
{
    public static class StringHelper
    {
        public static string StudentToString(Student student)
        {
            var studentArray = StudentToStringArray(student);
            var result = @$"ФИО: {studentArray[0]}
Дата рождения: {studentArray[1]}
Пол: {studentArray[2]}
Оценки:
{studentArray[3]}
";
            return result;
        }
        private static string GradeItemToString(GradeItem grade)
        {
            var subjects = new string[] { "Математика", "Программирование", "Английский язык", "Физика", "Русский язык" };
            return $"{subjects[(int)grade.Subject]}: {grade.Grade}";
        }
        private static string[] StudentToStringArray(Student student)
        {
            var fullName = $"{student.Surname} {student.Name} {student.FathersName}";
            var dateOfBirth = $"{student.DateOfBirth.Day}.{student.DateOfBirth.Month}.{student.DateOfBirth.Year}";
            var gender = student.Gender == Genders.Male ? "Мужской" : "Женский";
            var grades = GradeItemsToString(student.Grades);
            return new string[] { fullName, dateOfBirth, gender, grades };
        }

        public static string GradeItemsToString(GradeItem[] grades)
        {
            var result = new StringBuilder();
            foreach(var grade in grades)
            {
                result.AppendLine(GradeItemToString(grade));
            }
            return result.ToString();
        }

        public static ListViewItem StudentToListViewItem(Student student)
        {
            var stringArray = StudentToStringArray(student);
            return new ListViewItem(stringArray);
        }
    }
}
