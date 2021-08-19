using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0722_03_score_management
{
    class StudentRecord
    {
        private const int SUBJECT = 6;
        private int korean;
        private int english;
        private int math;
        private int society;
        private int science;
        private int history;
        private int sum;
        private double avg;

        public StudentRecord(int korean, int english, int math, int society, int science, int history)
        {
            this.korean = korean;
            this.english = english;
            this.math = math;
            this.society = society;
            this.science = science;
            this.history = history;
        }

        public int sum_result()
        {
            this.sum = korean + english + math + society + science + history;

            return sum;
        }

        public double avg_result()
        {
            avg = sum / SUBJECT;

            return avg;
        }

        public string score_result()
        {
            if (avg >= 85)
            {
                return "A";
            }

            else if (avg >= 75)
            {
                return "B";
            }

            else if (avg >= 65)
            {
                return "C";
            }

            else if (avg >= 55)
            {
                return "D";
            }

            else
            {
                return "F";
            }
        }
    }
}
