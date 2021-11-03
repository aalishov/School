using System;
using System.Text;
using Tesseract;

public class Program
{
    public static void Main()
    {
        string fileName = "test2.png";
        Console.WriteLine(ReadTextFromImage(fileName));
    }

    private static string ReadTextFromImage(string fileName)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Start {new string('>', 20)}");
            using (var engine = new TesseractEngine(@"tessdata", "eng"))
            {
                using (var image = Pix.LoadFromFile(fileName))
                {
                    using (var page = engine.Process(image))
                    {
                        string text = page.GetText();
                        sb.AppendLine(text);

                    }
                }
            }
            sb.AppendLine($"End {new string('<', 20)}");
            return sb.ToString();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }
}

