using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;

namespace P03_ImageProcessor_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] photoBytes = File.ReadAllBytes("f.jpg");
            // Format is automatically detected though can be changed.
            ISupportedImageFormat format = new JpegFormat { Quality = 70 };
            Size size = new Size(150, 0);
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    .Rotate(90)
                                    .Save(outStream);
                    }
                    // Do something with the stream.
                    Image img = System.Drawing.Image.FromStream(outStream);

                    img.Save("myImage.Jpeg", ImageFormat.Jpeg);
                }
            }
        }
    }
}
