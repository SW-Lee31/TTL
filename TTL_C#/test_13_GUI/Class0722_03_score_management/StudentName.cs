using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0722_03_score_management
{
    public class StudentName
    {
        private string[] first_name = { "김", "최", "양", "강", "황", "이", "추", "박", "장", "정" };
        private string[] middle_name = { "재", "창", "호", "태", "정", "상", "성", "준", "석", "주" };
        private string[] last_name = { "혁", "민", "진", "환", "운", "원", "명", "영", "범", "완" };
        private string full_name;

        public string createName(int first, int second, int last)
        {
            full_name = first_name[first] + middle_name[second] + last_name[last];

            return full_name;
        }
        
        public string getname()
        {
            return full_name;
        }
    }
}
