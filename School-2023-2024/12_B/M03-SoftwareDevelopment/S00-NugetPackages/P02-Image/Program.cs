using ImageProcessor.Imaging.Formats;
using ImageProcessor;
using System.Drawing;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string file = @"C:\Users\aalis\Desktop\file.jpg";

        byte[] photoBytes = File.ReadAllBytes(file);

        //Console.WriteLine(string.Join(" ",photoBytes));
        //Format is automatically detected though can be changed.
        ISupportedImageFormat format = new PngFormat { Quality = 70 };

        while (true)
        {
            Console.Write("Enter cmd: ");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "be":
                    Console.Write("Enter red: ");
                    int red = int.Parse(Console.ReadLine());
                    Console.Write("Enter gree: ");
                    int green = int.Parse(Console.ReadLine());
                    Console.Write("Enter blue: ");
                    int blue = int.Parse(Console.ReadLine());
                    Background(photoBytes, format, red, green, blue);
                    break;
                case "re":
                    Console.Write("Enter width: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    int height = int.Parse(Console.ReadLine());
                    Resize(photoBytes, format, width, height);
                    break;
                case "ro":
                    Console.Write("Enter angle: ");
                    int angle = int.Parse(Console.ReadLine());
                    Rotate(photoBytes, format, angle);
                    break;
                case "rc":
                    Console.Write("Enter angle: ");
                    angle = int.Parse(Console.ReadLine());
                    RoundCorners(photoBytes, format, angle);
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private static void Resize(byte[] photoBytes, ISupportedImageFormat format, int width, int height)
    {
        Size size = new Size(width, height);
        using (MemoryStream inStream = new MemoryStream(photoBytes))
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                {
                    // Load, resize, set the format and quality and save an image.
                    imageFactory.Load(inStream)
                            .Resize(size)
                            .Format(format)
                            .Save(outStream);
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();
                    byte[] image = outStream.ToArray();
                    File.WriteAllBytes($"{fileName}.jpg", image);
                }
                // Do something with the stream.
            }
        }
    }
    private static void Rotate(byte[] photoBytes, ISupportedImageFormat format, int angle)
    {
        using (MemoryStream inStream = new MemoryStream(photoBytes))
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                {
                    // Load, resize, set the format and quality and save an image.
                    imageFactory.Load(inStream)
                            .Rotate(angle)
                            .Format(format)
                            .Save(outStream);
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();
                    byte[] image = outStream.ToArray();
                    File.WriteAllBytes($"{fileName}.jpg", image);
                }
                // Do something with the stream.
            }
        }
    }
    private static void RoundCorners(byte[] photoBytes, ISupportedImageFormat format, int angle)
    {
        using (MemoryStream inStream = new MemoryStream(photoBytes))
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                {
                    // Load, resize, set the format and quality and save an image.
                    imageFactory.Load(inStream)
                            .RoundedCorners(angle)
                            .Format(format)
                            .Save(outStream);
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();
                    byte[] image = outStream.ToArray();
                    File.WriteAllBytes($"{fileName}.jpg", image);
                }
                // Do something with the stream.
            }
        }
    }

    private static void Background(byte[] photoBytes, ISupportedImageFormat format, int red, int green, int blue)
    {
        Color myColor = Color.FromArgb(red, green, blue);

        using (MemoryStream inStream = new MemoryStream(photoBytes))
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                {
                    // Load, resize, set the format and quality and save an image.
                    imageFactory.Load(inStream)
                            .BackgroundColor(myColor)
                            .Format(format)
                            .Save(outStream);
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();
                    byte[] image = outStream.ToArray();
                    File.WriteAllBytes($"{fileName}.jpg", image);
                }
                // Do something with the stream.
            }
        }
    }
}
