using System;

namespace Naimushin.Models
{
    public enum Genders
    {
        Male,
        Female
    }

    public class Student
    {
        private string name;
        public string Name { 
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Имя не может быть пустым.");
                }
                name = value;
            }
        }

        private string surname;
        public string Surname {
            get
            {
                return surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Фамилия не может быть пустой.");
                }
                surname = value;
            }
        }

        private string fathersName;
        public string FathersName {
            get
            {
                return fathersName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Отчество не может быть пустым.");
                }
                fathersName = value;
            }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth 
        { 
            get 
            {
                return dateOfBirth;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    throw new Exception("Дата рождения не может быть больше текущей даты.");
                }
                dateOfBirth = value;
            }
        }
        public Genders Gender { get; set; }
        public GradeItem[] Grades { get; set; }
    }
}
