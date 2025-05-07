using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Subject
    {
    private string name;
    private readonly List<Lesson> lessons;
    public Subject(string name)
    {
        Name = name;
        this.lessons = new List<Lesson>();
    }

    public string Name
    {
        get 
        { 
            return name; 
        }

        set
        {
            if (value.Length < 2 || value.Length > 40 )
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }
    
    public void AddLesson(Lesson lesson)
    {
        lessons.Add( lesson );
    }
    public void AddRate(string title, int rate)
    {
        Lesson lesson = lessons.FirstOrDefault(s => s.Title == title);
        if (lesson == null)
        {
            throw new ArgumentException("Lesson not found!");
        }
        lesson.AddRating(rate);
    }
    public double AverageRating()
    {
        return lessons.Average(s => s.Rating);

    }
    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        return lessons
            .Where(t => t.Teacher == teacher)
            .OrderByDescending(d => d.Duration)
            .ToList();
    }
    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        return lessons
            .Where(d => d.Duration >= from && d.Duration <= to)
            .OrderByDescending(d => d.Rating)
            .ToList();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Subject {Name}");
        sb.AppendLine($"Total Lessons: {lessons.Count}");
        return sb.ToString().TrimEnd();
    }
}

