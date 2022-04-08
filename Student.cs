using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsTask
{
    class Student
    {
        static int _totalCount;
        //public Student()
        //{
        //    _totalCount++;
        //    No = _totalCount;
        //}

        public string No { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, int> Exams = new Dictionary<string, int>();
        public void AddExam(string examName, int point)
        {
            Exams.Add(examName, point);
        }
        public int GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if (item.Key==examName)
                {
                    return item.Value;
                }
            }
            return 0;
        }

        public int GetExamAvg()
        {
            int count = 0;
            int sum = 0;
            foreach (var item in Exams)
            {              
                sum += item.Value;
                count = Exams.Count;
            }
            return sum / count;
        }


    }
}
