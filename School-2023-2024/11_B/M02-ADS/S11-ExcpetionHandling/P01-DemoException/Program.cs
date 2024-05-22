public class Program
{
    public static void Main(string[] args)
    {
        //      int[] nums = { 12, 21, 123, 89 };
        //try
        //{
        //	int.Parse("as");
        //         // Console.WriteLine(nums[15]);
        //      }

        //      catch (IndexOutOfRangeException ex)
        //{
        //          Console.WriteLine(ex.Message);
        //      }
        //      catch (FormatException e)
        //      {
        //          Console.WriteLine("Invalid number");
        //      }
        //      catch (Exception e)
        //      {
        //          Console.WriteLine("Base exception");
        //      }
        //      finally
        //      {
        //          Console.WriteLine("End");
        //      }


        // Sum(5, 15);

        //throw new MyException();
        //int[] nums = { 1, 2 };
        List<int> nums = new List<int> { 1, 2, 3 };
        Console.WriteLine(nums[3]);
    }

    public static int Sum(int a, int b)
    {
        throw new NotImplementedException(nameof(Sum));
    }

    class Student
    {
        private List<double> grades = new List<double>();
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}