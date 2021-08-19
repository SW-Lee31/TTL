using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_05_parking_management
{
    class Rand_data
    {
        Random ran = new Random();

        string[] name = { "현대", "기아", "삼성르노", "대우", "쌍용" };

        public string get_rand_manucom()
        {
            int ran_num = ran.Next(name.Length);

            string manu_com = name[ran_num];

            return manu_com;
        }
    }
}
