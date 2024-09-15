using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFinder
{
    public abstract class Lesson
    {
        private readonly List<int> ratings = new List<int>();
        private string title;
        private int duration;
        private int grade;
        private int difficulty;
        private string teacher;

        protected Lesson(string title, int duration, int grade, int difficulty, string teacher)
        {
            Title = title;
            Duration = duration;
            Grade = grade;
            Difficulty = difficulty;
            Teacher = teacher;
        }

        public string Title
        {
            get { return title; }
            private set
            {
                if (value.Length < 3 || value.Length > 54)
                {
                    throw new ArgumentException("Title should be between 3 and 54 characters!");
                }

                title = value;
            }
        }

        public int Duration
        {
            get { return duration; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Duration should be positive!");
                }
                duration = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade should be between 1 and 12!");
                }
                grade = value;
            }
        }

        public int Difficulty
        {
            get { return difficulty; }
            private set
            {
                if (value < 1 || value > 3)
                {
                    throw new ArgumentException("Difficulty should be between 1 and 3!");
                }
                difficulty = value;
            }
        }

        public string Teacher
        {
            get { return teacher; }
            private set
            {
                if (value.Length < 3 || value.Length > 54)
                {
                    throw new ArgumentException("Teacher should be between 3 and 54 characters!");
                }
                teacher = value;
            }
        }

        public double Rating { get { return ratings.Average(); } }

        public void AddRating(int rate)
        {
            if (rate >= 1 && rate <= 5)
            {
                ratings.Add(rate);
            }
        }

        public override string ToString()
        {
            return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating:f2} / 5)";
        }
    }
}
