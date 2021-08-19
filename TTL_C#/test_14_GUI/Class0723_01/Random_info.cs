using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_01
{
    class Random_info
    {
        Random rand;
        private string[] first_name = { "김", "최", "양", "강", "황", "이", "추", "박", "장", "정" };
        private string[] middle_name = { "재", "창", "호", "태", "정", "상", "성", "준", "석", "주" };
        private string[] last_name = { "혁", "민", "진", "환", "운", "원", "명", "영", "범", "완" };
        private string full_name;
        private string[] first_digit = { "010", "011", "016" };
        private string[] rest_digit = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private string full_digit;
        private string[] city = { "대구", "서울", "제주", "부산", "대전", "광주", "전주", "울산" };
        private string[] area = { "중구", "서구", "남구", "동구", "북구", "수성구", "달서구", "달서군" };
        private string[] area_num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private string full_addr;

        public string createName(int first, int second, int last)
        {
            full_name = first_name[first] + middle_name[second] + last_name[last];

            return full_name;
        }

        public string getname()
        {
            return full_name;
        }

        public string Create_digit(int first_digit, int middle_digit, int last_digit)
        {
            this.full_digit = this.first_digit[first_digit];

            full_digit += "-";

            for (int i = 0; i < 4; i++)
            {
                full_digit += rest_digit[middle_digit];
            }
            
            full_digit += "-";

            for (int i = 0; i < 4; i++)
            {
                full_digit += rest_digit[last_digit];
            }

            return full_digit;
        }

        public string Create_addr(int city, int area, int area_num)
        {
            full_addr = this.city[city];
            full_addr += this.area[area];
            full_addr += "-";

            
            for (int i = 0; i < 4; i++)
            {
                full_addr += this.area_num[area_num];
            }

            full_addr += "번지";

            return full_addr;
        }
    }
}
