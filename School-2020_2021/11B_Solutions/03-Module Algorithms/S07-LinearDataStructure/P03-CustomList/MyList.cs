using System;
using System.Collections.Generic;
using System.Text;

namespace P03_CustomList
{
    public class MyList<T> : List<T>
    {
        public void ShiftRight(int shiftPosition)
        {
            // 3, 15, 5, 8 => Shift(2)  => //5, 8, 3, 15

            List<T> temp = new List<T>();

            for (int i = 0; i < shiftPosition; i++)
            {
                temp.Add(this[this.Count - 1]);
                for (int j = 0; j < this.Count - 1; j++)
                {
                    temp.Add(this[j]);
                }
                this.Clear();
                for (int j = 0; j < temp.Count; j++)
                {
                    this.Add( temp[j]);
                }
                temp.Clear();
            }
        }
    }
}
