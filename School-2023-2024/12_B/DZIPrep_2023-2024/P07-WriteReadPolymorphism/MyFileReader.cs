using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_FormApp
{
    public class MyFileReader : IReader
    {
        public MyFileReader()
        {
            inputLines = new Queue<string>(File.ReadAllLines("C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2023-2024\\12_B\\DZIPrep_2023-2024\\P07-WriteReadPolymorphism\\input.txt"));
        }
        private Queue<string> inputLines;
        public string Read()
        {
            return inputLines.Dequeue();
        }
    }
}

