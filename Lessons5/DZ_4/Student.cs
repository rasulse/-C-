using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Student
    {        
        public string Info()
        {
            string info = _surname;
            info += $" {_name}";
            for (int i = 0; i < _marks.Length; i++)
                info += $" {_marks[i]}";
            return info;
        }
        
        public Student(string name, string surname, int[] marks)
        {
            Name = name;
            Surname = surname;
            _marks = marks;
        }
        
        public int this[int i]
        {
            get { return _marks[i]; }
            set
            {
                if (value >= 2 && value <= 5)
                    _marks[i] = value;
            }
        }
        
        public float AverageMark
        {
            get
            {
                float mark = 0f;
                for (int i = 0; i < _marks.Length; i++)
                    mark += _marks[i];
                return mark /= _marks.Length;
            }
        }
        
        public string Name
        {
            get { return _name; }

            set
            {
                if (value.Length <= 15 && value.Length >= 2)
                    _name = value;
                else if (value.Length > 15)
                    _name = value.Remove(16);
                else
                    throw new ArgumentException();
            }
        }
        
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length <= 20 && value.Length >= 2)
                    _surname = value;
                else if (value.Length > 20)
                    _surname = value.Remove(21);
                else
                    throw new ArgumentException();
            }
        }        
        private string _name;
        private string _surname;
        private int[] _marks;        
    }
}
