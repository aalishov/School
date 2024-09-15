using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFinder
{
    public class LectureLesson : Lesson
    {
        public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location) : base(title, duration, grade, difficulty, teacher)
        {
            Location = location;
        }

        public string Location { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $" @ Onsite: {Location}";
        }
    }
}
