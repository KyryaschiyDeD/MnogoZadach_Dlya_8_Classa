using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogoZadachDky8Classa.Param2
{
    internal class Student
    {
        public string _firstName { get; set; } = "";
        public string _lastName { get; set; } = "";
        public string _patronymics { get; set; } = "";
        public string getFIO { get { return _lastName + " " + _firstName + " " + _patronymics; } }
        private DateTime _birthday { get; set; }
        public string birthday { get { return _birthday.ToString("dd-MM-yyyy"); } }
        public int age { get 
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - _birthday.Year;
                if (currentDate.Month < _birthday.Month || (currentDate.Month == _birthday.Month && currentDate.Day < _birthday.Day))
                    age--;
                return age;
            } 
        }
        public List<Subjects> _subjects { get; set; }

        public string GetTeachers
        {
            get
            {
                string teachers = "";

                foreach (var subject in _subjects)
                {
                    teachers += subject.GetTeacherName();
                    if (_subjects.Last() != subject)
                        teachers += ", ";
                }

                return teachers;
            }
        }

        public string _checkNumAndSub
        {
            get
            {
                string sub = "";

                foreach (var subject in _subjects)
                {
                    sub += subject.GetSubjectName() + ": " + subject.GetCheckNumber + "\n";
                    if (_subjects.Last() != subject)
                        sub += "\n";
                }

                return sub;
            }
        }

        public Student(string firstName, string lastName, string patronymics, DateTime birthday, List<Subjects> subjects)
        {
            _firstName = firstName;
            _lastName = lastName;
            _patronymics = patronymics;
            _birthday = birthday;
            _subjects = subjects;
        }

        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public DateTime GetBirthday() => _birthday;
        public List<Subjects> GetSubjects() => _subjects;
        
        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {_firstName} {_lastName}");
            Console.WriteLine($"Дата рождения: {_birthday.ToString("yyyy-MM-dd")}");
            foreach (var subject in _subjects)
            {
                Console.WriteLine($"Предмет: {subject.GetSubjectName()}");
                Console.WriteLine($"Дата экзамена: {subject.GetExamDate().ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Преподаватель: {subject.GetTeacherName()}");
            }
        }

        
    }
}
