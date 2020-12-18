using System;
using System.IO;

namespace DZ_4
{
    class Exam
    {
        
        public void PrintInfoStudents()
        {
            for (int i = 0; i < countStudents; i++)
                ConsoleWriteLineColor(_students[i].Info(), ConsoleColor.White);
        }
       
        public Student[] WorstResultExamStudents(int maxCountWorstStudents, out int countWorstStudents)
        {
            if (maxCountWorstStudents > countStudents)
                maxCountWorstStudents = countStudents;

            countWorstStudents = maxCountWorstStudents;
            Student[] students = SortStudent();
            Student[] worstStudents = new Student[countStudents];


            for (int i = 0; i < students.Length; i++)
            {
                if (i < maxCountWorstStudents)
                    worstStudents[i] = students[i];
                else if (students[maxCountWorstStudents - 1].AverageMark == students[i].AverageMark)
                {
                    worstStudents[i] = students[i];
                    countWorstStudents++;
                }
                else if (students[maxCountWorstStudents - 1].AverageMark < students[i].AverageMark)
                    break;
            }

            return worstStudents;
        }
        
        Student[] SortStudent()
        {
            
            void Swap(ref Student first, ref Student second)
            {
                Student temp = first;
                first = second;
                second = temp;
            }

            Student[] students = new Student[countStudents];
            for (int i = 0; i < countStudents; i++)
            {
                students[i] = _students[i];
            }

            for (int i = 0; i < countStudents; i++)
            {
                for (int inner = 0; inner < countStudents - 1; inner++)
                {
                    if (students[inner].AverageMark > students[inner + 1].AverageMark)
                        Swap(ref students[inner], ref students[inner + 1]);
                }
            }
            
            return students;
        }
        public void AddStudent(Student student)
        {
            if (countStudents >= maxCountStudents)
                ConsoleWriteLineColor("Достигнуто максимальное количество студентов!", ConsoleColor.Red);
            else if (countStudents < maxCountStudents)
                _students[countStudents++] = student;
        }
        
        public void PrintInputFile(string path, bool append = false)
        {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
                _filename = path;
            }

            try
            {
                StreamWriter sw = new StreamWriter(path, append);
                sw.WriteLine(countStudents);

                for (int i = 0; i < countStudents; i++)
                    sw.WriteLine(_students[i].Info());

                sw.Close();
                ConsoleWriteLineColor($"Данные записаны в файл {path}", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                ConsoleWriteLineColor(e.Message, ConsoleColor.DarkRed);
            }
        }
       
        public void ReadStudentsFromFile(string path)
        {
            if (!File.Exists(path))
            {
                ConsoleWriteLineColor($"Файл не был найден по указанному пути: {path}", ConsoleColor.Red);
                return;
            }

            try
            {
                StreamReader sr = new StreamReader(path);
                int.TryParse(sr.ReadLine(), out int count);

                for (int i = 0; !sr.EndOfStream && countStudents < maxCountStudents; i++)
                {
                    string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                    string[] words = sr.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    int[] marks = new int[3];

                    for (int indexWord = 2, indexMark = 0; indexMark < 3; indexWord++, indexMark++)
                    {
                        int.TryParse(words[indexWord], out marks[indexMark]);
                    }

                    AddStudent(new Student(words[1], words[0], marks));
                }

                sr.Close();
                ConsoleWriteLineColor($"Данные считаны из {path}", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                ConsoleWriteLineColor(e.Message, ConsoleColor.DarkRed);
            }
        }
        
        void ClearFile()
        {
            if (!File.Exists(_filename))
            {
                FileStream fs = File.Create(_filename);
                fs.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(_filename, false);
                sw.Write("");
                sw.Close();
            }
        }
        
        public static void ConsoleWriteLineColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        public static void ConsoleWriteColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
                
        public Exam()
        {
            countStudents = 0;
            _students = new Student[maxCountStudents];
        }
        public Exam(Student[] students, int length) : this()
        {
            for (int i = 0; i < length && countStudents < maxCountStudents; i++)
                _students[countStudents++] = students[i];
        }
       
        public Student[] Students
        {
            get
            {
                Student[] students = new Student[CountStudents];

                for (int i = 0; i < CountStudents; i++)
                    students[i] = _students[i];

                return students;
            }
        }
        public Student this[int i]
        {
            get { return _students[i]; }
            set
            {
                if (i < maxCountStudents)
                {
                    _students[i] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public string Filename
        {
            get { return _filename; }
            set
            {
                if (!File.Exists(value))
                {
                    FileStream stream = File.Create(value);
                    stream.Close();
                }

                _filename = value;
            }
        }
        
        public int MaxStudents
        {
            get { return maxCountStudents; }
        }
        
        public int CountStudents
        {
            get { return countStudents; }
        }
       
        const int maxCountStudents = 100;
        
        Student[] _students;
        string _filename;
        int countStudents;        
    }
}
