using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string Fullname { get; set; }
        public Dictionary<string, int> Exams { get; set; } = new Dictionary<string, int>();
        public void AddExam(string examName,int point)
        {
            Exams.Add(examName, point);
        }
        public int GetExamResult(string examName)
        {
            foreach (var item in Exams.Keys)
            {
                if (examName==item)
                {
                    return Exams[examName];
                }
            }
            return -1;
        }
        public int GetExamAvg()
        {
            int sum = 0;
            int count = 0;
            foreach (var item in Exams.Values)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }

    }
}
