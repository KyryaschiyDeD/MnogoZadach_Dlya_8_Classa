using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogoZadachDky8Classa.Param2
{
    internal class Subjects
    {
        public string _subjectName;
        public int _checkNumber;
        public DateTime _examDate;
        public string _teacherName;

        public Subjects(string subjectName, int checkNumber, DateTime examDate, string teacherName)
        {
            _subjectName = subjectName;
            _checkNumber = checkNumber;
            _examDate = examDate;
            _teacherName = teacherName;
        }

        public string GetSubjectName() => _subjectName;
        public int CheckNumber => _checkNumber;
        public string GetCheckNumber => _checkNumber.ToString();

        public DateTime GetExamDate() => _examDate;
        public string GetTeacherName() => _teacherName;
    }

}
