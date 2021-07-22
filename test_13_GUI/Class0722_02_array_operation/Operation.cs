using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0722_02_array_operation
{
    class Operation
    {
        private double sum;
        private double avg;
        private double[] arr;

        public Operation(double[] arr)
        {
            this.arr = arr;
        }

        public double sum_result()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.sum += arr[i];
            }

            return sum;   
        }

        public double avg_result()
        {
            this.avg = sum / arr.Length;
            return avg;
        }
    }
}
