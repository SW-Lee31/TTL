using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_01_sigletone
{
    class Singletest
    {
        static Singletest inst;

        private int data;


        public Singletest(Random ran)
        {
            data = ran.Next(50, 101);
        }

        public int getdata()
        {
            return data;
        }

        public static Singletest getinst(Random ran)
        {
            if (inst == null)
            {
                inst = new Singletest(ran);
            }

            return inst;
        }
    }
}
