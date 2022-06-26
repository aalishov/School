Student s1 = new Student("John", 5.40);
Student s2 = new Student("Jane", 5.20);
Student s3 = new Student("John", 5.20);
Student s4 = new Student("John", 4.60);
Student s5 = new Student("John", 3.40);
Student s6 = new Student("John", 2.60);

Student[] students = new Student[] { s1, s2, s3, s4, s5, s6 };

//Bubble<Student>(students);

//foreach (var item in students)
//{
//    Console.WriteLine(item.Name + " " + item.AverageGrade);
//}

string st1 = "red";
string st2 = "roses";
Console.WriteLine(string.Compare(st1,st2));


static void Bubble<T>(T[] elements) where T : IComparable<T>
{
    for (int i = 0; i < elements.Length; i++)
    {
        for (int j = 0; j < elements.Length; j++)
        {
            if (elements[i].CompareTo(elements[j]) < 0)
            {
                Swap(elements, i, j);
            }
        }
    }
}

static void Swap<T>(T[] elements, int first, int second)
{
    T temp = elements[first];
    elements[first] = elements[second];
    elements[second] = temp;
}

//// Дали даден елемент е по малък от друг = O(1)
//static bool IsLess<T>(IComparable<T> first, IComparable<T> second)
//{
//    return first.CompareTo(second?) < 0;
//}