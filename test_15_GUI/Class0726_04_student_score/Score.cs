using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_04_student_score
{
    class Score
    {
        public const int SUBJECT = 6;
        Student st_name;

        private int korean;
        private int english;
        private int math;
        private int society;
        private int science;
        private int history;

        public Score(Student st_name, int korean, int english, int math, int society, int science, int history)
        {
            this.st_name = st_name;
            this.korean = korean;
            this.english = english;
            this.math = math;
            this.society = society;
            this.science = science;
            this.history = history;
        }

        public int Korean { get => korean; set => korean = value; }
        public int English { get => english; set => english = value; }
        public int Math { get => math; set => math = value; }
        public int Society { get => society; set => society = value; }
        public int Science { get => science; set => science = value; }
        public int History { get => history; set => history = value; }
        internal Student St_name { get => st_name; set => st_name = value; }

        public void show_score()
        {
            Console.WriteLine("{0}의 점수입니다.", st_name.Name);
            Console.WriteLine("국어점수는 : {0}", korean);
            Console.WriteLine("영어점수는 : {0}", english);
            Console.WriteLine("수학점수는 : {0}", math);
            Console.WriteLine("사회점수는 : {0}", society);
            Console.WriteLine("과학점수는 : {0}", science);
            Console.WriteLine("역사점수는 : {0}", history);
        }

        public int sum_score()
        {
            int sum = korean + english + math + society + science + history;

            return sum;
        }

        public double avg_score()
        {
            double avg = (korean + english + math + society + science + history) / SUBJECT;

            return avg;
        }

        public char get_result(double avg)
        {
            if (avg >= 80)
            {
                return 'A';
            }
            else  if (avg >= 70)
            {
                return 'B';
            }
            else if (avg >= 55)
            {
                return 'C';
            }
            else if (avg >= 40)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
