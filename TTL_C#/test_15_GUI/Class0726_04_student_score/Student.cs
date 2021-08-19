using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_04_student_score
{
    class Student
    {
        private string[] first_name_list = { "김", "이", "박", "최", "강", "황", "양", "전", "장", "정" };
        private string[] middle_name_list = { "형", "상", "현", "창", "태", "윤", "호", "화", "재", "정" };
        private string[] last_name_List = { "문", "원", "재", "민", "진", "성", "혁", "영", "탁", "환" };

        private string name;

        public Student(int num_1, int num_2, int num_3)
        {
            this.name = first_name_list[num_1]
                + middle_name_list[num_2]
                + last_name_List[num_3];
        }

        public string Name { get => name; set => name = value; }
    }
}
