using System;

namespace Naimushin.Models
{
    public enum Subjects
    {
        Math,
        Programming,
        English,
        Physics,
        Russian
    }
    public class GradeItem
    {
        public Subjects Subject { get; set; }

        private int grade;
        public int Grade {
            get
            {
                return grade;
            } 
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception("Оценка студента должна быть больше или равна 0 и меньше или равна 100.");
                }
                grade = value;
            }
        }
    }
}
