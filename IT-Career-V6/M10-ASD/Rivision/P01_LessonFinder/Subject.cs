using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFinder
{
    public class Subject
    {

        private string name;
        private readonly List<Lesson> lessons = new List<Lesson>();

        public Subject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters!");
                }
                name = value;
            }
        }

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }

        public void AddRate(string title, int rate)
        {
            Lesson? lesson = lessons.Find(x => x.Title == title);

            if (lesson == null)
            {
                throw new ArgumentException("Lesson not found!");
            }

            lesson.AddRating(rate);
        }

        public double AverageRating()
        {
            return lessons.Average(x => x.Rating);
        }

        public List<Lesson> GetLessonsByTeacher(string teacher)
        {
            return lessons
                .Where(x => x.Teacher == teacher)
                .OrderByDescending(x => x.Duration)
                .ToList();
        }
        public List<Lesson> GetLessonsBetweenDuration(int from, int to)
        {
            return lessons
                .Where(x=>x.Duration >= from && x.Duration <= to)
                .OrderByDescending (x => x.Rating)
                .ToList();  
        }

        public override string ToString()
        {
            return $"Subject {Name}{Environment.NewLine}Total Lessons: {lessons.Count}";
        }
    }
}
