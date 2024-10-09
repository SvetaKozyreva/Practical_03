using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Arrays
    {
        public bool error = false;
        int[] a;
        int length;
        public Arrays(int size)
        {
            a = new int[size];
            length = size;
        }
        public int Length
        {
            get { return length; }
        }
        public static Arrays generateRandomArray(Arrays array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            return array;
        }
        public static Arrays operator *(Arrays arrays, int nul)
        {
            Arrays resArray = new Arrays( arrays.Length );
            for( int i = 0;i < resArray.Length; i++)
            {
                resArray[i] = arrays[i] * nul;
            }
            return resArray;
        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length) return a[i];
                else { error = true; return 0; }
            }
            set
            {
                if (i >= 0 && i < length && value >= -100 && value <= 10000)
                {
                    a[i] = value;
                }
                else error = true;
            }
        }
    }
}
