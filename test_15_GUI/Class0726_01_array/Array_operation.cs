using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_01_array
{
    class Array_operation
    {
        private int[] arr;
        private int sum;
        private double avg;

        public Array_operation(int[] arr)
        {
            this.arr = arr;
        }

        public int arr_sum()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(this.sum + "\n");
            return sum;
        }

        public double arr_avg()
        {
            this.avg = sum / this.arr.Length;

            Console.WriteLine(this.avg + "\n");
            return avg;
        }
    }
}
