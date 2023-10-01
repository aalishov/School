using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Lake
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones)
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            List<int>even=stones.Where(x=>x%2==0).OrderByDescending(x=>x).ToList();
            List<int> odd = stones.Where(x => x % 2 == 1).OrderBy(x => x).ToList();

            for (int i = 0; i < odd.Count; i++)
            {
                yield return odd[i];
            }
            for (int i = 0; i < even.Count; i++)
            {
                yield return even[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
