
using System.Text;
using System.Threading.Channels;

namespace LessonFinder
{
    public class Controller
    {
        List<Subject> subjects = new List<Subject>();
        public string AddSubject(List<string> arguments)
        {
            string name = arguments[0];
            if (subjects.Any(x => x.Name == name))
            {
                return $"Subject already exists!";
            }
            subjects.Add(new Subject(name));
            return $"Created Subject {name}!";
        }

        public string AddLesson(List<string> arguments)
        {
            string name = arguments[0];
            string title = arguments[1];
            int duration = int.Parse(arguments[2]);
            int grade = int.Parse(arguments[3]);
            int difficulty = int.Parse(arguments[4]);
            string teacher = arguments[5];
            string type = arguments[6];
            string platformOrLocation = arguments[7];

            Subject subject = subjects.Find(x => x.Name == name);
            Lesson lesson = null;
            if (subject != null)
            {
                switch (type)
                {
                    case "online":
                        lesson = new OnlineLesson(title, duration, grade, difficulty, teacher, platformOrLocation);
                        break;
                    case "onsite":
                        lesson = new LectureLesson(title, duration, grade, difficulty, teacher, platformOrLocation);
                        break;
                    default:
                        return string.Empty;
                }
            }
            subject.AddLesson(lesson);
            return $"Created Lesson {title} in Subject {name}!";
        }

        public string GetAverageRating(List<string> arguments)
        {
            string name = arguments[0];
            double averageRating = subjects.FirstOrDefault(x => x.Name == name).AverageRating();
            return $"The average rating is: {averageRating:F2}";
        }

        public string GetLessonsBetweenDuration(List<string> arguments)
        {
            string name = arguments[0];
            int from = int.Parse(arguments[1]);
            int to = int.Parse(arguments[2]);

            StringBuilder sb = new StringBuilder();
            subjects
                 .FirstOrDefault(x => x.Name == name)
                 .GetLessonsBetweenDuration(from, to)
                 .ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }

        public string GetLessonsByTeacher(List<string> arguments)
        {
            string name = arguments[0];
            string teacher = arguments[1];

            StringBuilder sb = new StringBuilder();

            subjects
                .FirstOrDefault(x => x.Name == name)
                .GetLessonsByTeacher(teacher)
                .ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }

        public string RateLesson(List<string> arguments)
        {
            string name = arguments[0];
            string title = arguments[1];
            int rate = int.Parse(arguments[2]);
            subjects.FirstOrDefault(x => x.Name == name).AddRate(title, rate);
            return $"Rated {title} with {rate} rate.";
        }
    }
}