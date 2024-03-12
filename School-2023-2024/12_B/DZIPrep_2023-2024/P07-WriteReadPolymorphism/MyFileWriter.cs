using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyFileWriter : IWriter
{
    private string outputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2023-2024\\12_B\\DZIPrep_2023-2024\\P07-WriteReadPolymorphism\\output.txt";
    public void Write(string text)
    {
        File.AppendAllText(outputPath, $"{text}{Environment.NewLine}");
    }
}

