using Naimushin.Models;
using System;
using System.Collections.Generic;

namespace Naimushin.Data
{
    public static class MockData
    {
        public static List<Student> Students = new List<Student> {
            new Student
            {
                Name = "Владислава",
                Surname = "Кищенко",
                FathersName = "Игоревна",
                DateOfBirth = new DateTime(2005, 11, 30),
                Gender = Genders.Female,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 70
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 65
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 100
                    },
                }
            },
            new Student
            {
                Name = "Пашков",
                Surname = "Лыков",
                FathersName = "Александрович",
                DateOfBirth = new DateTime(2003, 8, 30),
                Gender = Genders.Male,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 70
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 60
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 80
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 60
                    },
                }
            },
            new Student
            {
                Name = "Алексей",
                Surname = "Калоша",
                FathersName = "Григорьевич",
                DateOfBirth = new DateTime(2001, 6, 21),
                Gender = Genders.Male,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 70
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 80
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 60
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 100
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 90
                    },
                }
            },
            new Student
            {
                Name = "Владимир",
                Surname = "Гаджун",
                FathersName = "Александрович",
                DateOfBirth = new DateTime(2005, 8, 30),
                Gender = Genders.Male,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 12
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 90
                    },
                }
            },
            new Student
            {
                Name = "Софья",
                Surname = "Лукашева",
                FathersName = "Юрьевна",
                DateOfBirth = new DateTime(2005, 11, 25),
                Gender = Genders.Female,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 90
                    },
                }
            },
            new Student
            {
                Name = "Иван",
                Surname = "Добрынин",
                FathersName = "Сергеевич",
                DateOfBirth = new DateTime(2003, 8, 7),
                Gender = Genders.Male,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 85
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 75
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 75
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 98
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 60
                    },
                }
            },
            new Student
            {
                Name = "Алена",
                Surname = "Яковлева",
                FathersName = "Витальевна",
                DateOfBirth = new DateTime(2004, 7, 18),
                Gender = Genders.Female,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 90
                    },
                }
            },
            new Student
            {
                Name = "Иван",
                Surname = "Белокобыльский",
                FathersName = "Александрович",
                DateOfBirth = new DateTime(2003, 5, 23),
                Gender = Genders.Male,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 70
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 80
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 100
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 100
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 60
                    },
                }
            },
            new Student
            {
                Name = "Марина",
                Surname = "Онищенко",
                FathersName = "Сергеевна",
                DateOfBirth = new DateTime(1998, 5, 1),
                Gender = Genders.Female,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 80
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 60
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 100
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 75
                    },
                }
            },
            new Student
            {
                Name = "Екатерина",
                Surname = "Тимофеева",
                FathersName = "Андреевна",
                DateOfBirth = new DateTime(2003, 4, 6),
                Gender = Genders.Female,
                Grades = new GradeItem[]
                {
                    new GradeItem
                    {
                        Subject = Subjects.Math,
                        Grade = 70
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Programming,
                        Grade = 80
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Physics,
                        Grade = 90
                    },
                    new GradeItem
                    {
                        Subject = Subjects.Russian,
                        Grade = 60
                    },
                    new GradeItem
                    {
                        Subject = Subjects.English,
                        Grade = 75
                    },
                }
            },
        };
    }
}
