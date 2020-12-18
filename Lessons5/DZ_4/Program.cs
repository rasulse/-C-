using System;
using static DZ_4.Exam;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Program
    {
        /* Код написан: Бахмудовым Расулом
        *  Домашнее задание №4:
        *  Задача ЕГЭ.
        *  На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
        *  В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
        *  каждая из следующих N строк имеет следующий формат: <Фамилия> <Имя> <оценки>, где <Фамилия> — строка,
        *  состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
        *  <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
        *  <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки: Иванов Петр 4 5 3
        *  Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх
        *  худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один
        *  из трёх худших, следует вывести и их фамилии и имена. */

        static Random rand = new Random();

        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Антон", "Травкин", RandomMarks(3)),
                new Student("Григорий", "Соболев", RandomMarks(3)),
                new Student("Анатолий", "Бурыкин", RandomMarks(3)),
                new Student("Елена", "Петрянина", RandomMarks(3)),
                new Student("Василий", "Фадейкин", RandomMarks(3)),
                new Student("Вячеслав", "Давыдов", RandomMarks(3)),
                new Student("Мария", "Колесникова", RandomMarks(3)),
                new Student("Сергей", "Коршунов", RandomMarks(3)),
                new Student("Александр", "Дивин", RandomMarks(3)),
                new Student("Алексей", "Фанкин", RandomMarks(3)),
                new Student("Павел", "Баранов", RandomMarks(3)),
                new Student("Владислав", "Кротов", RandomMarks(3)),
                new Student("Ирина", "Кузнецова", RandomMarks(3)),
                new Student("Анастасия", "Спирина", RandomMarks(3)),
                new Student("Андрей", "Исаев", RandomMarks(3))
            };

            string filepath = @"../../students.txt";
            Exam exam = new Exam(students, students.Length);

            ConsoleWriteLineColor("Список студентов с оценками за экзамен: ", ConsoleColor.DarkGray);
            exam.PrintInfoStudents();
            Console.WriteLine();

            exam.AddStudent(new Student("Артем", "Гилёв", RandomMarks(3)));
            exam.AddStudent(new Student("Ирина", "Завьялова", RandomMarks(3)));
            exam.AddStudent(new Student("Александра", "Алтынова", RandomMarks(3)));
            exam.AddStudent(new Student("Федор", "Игнатьев", RandomMarks(3)));
            exam.AddStudent(new Student("Всеволод", "Кузнецов", RandomMarks(3)));

            ConsoleWriteLineColor("Список студентов с оценками за экзамен после добавления: ", ConsoleColor.DarkGray);
            exam.PrintInfoStudents();
            Console.WriteLine();
            exam.PrintInputFile(filepath);

            Console.WriteLine();
            exam.AddStudent(new Student("Лариса", "Федотова", RandomMarks(3)));
            exam.AddStudent(new Student("Кристина", "Жук", RandomMarks(3)));
            exam.AddStudent(new Student("Николай", "Демин", RandomMarks(3)));
            exam.AddStudent(new Student("Юрий", "Хан", RandomMarks(3)));
            exam.AddStudent(new Student("Артем", "Черезов", RandomMarks(3)));
            ConsoleWriteLineColor("Добавили еще 5 студентов и записали в файл", ConsoleColor.DarkYellow);
            exam.PrintInputFile(filepath);
            Console.WriteLine();

            Exam newExam = new Exam();
            newExam.ReadStudentsFromFile(filepath);
            Console.WriteLine();

            ConsoleWriteLineColor("Список студентов с оценками за экзамен после чтения из файла: ", ConsoleColor.DarkGray);
            newExam.PrintInfoStudents();
            Console.WriteLine();

            int maxCountWorstStudents = 3;
            ConsoleWriteLineColor("Список студентов с худшим средним баллом: ", ConsoleColor.DarkGray);
            Student[] worstStudents = newExam.WorstResultExamStudents(maxCountWorstStudents, out int countWorstStudents);

            for (int i = 0; i < countWorstStudents; i++)
                ConsoleWriteLineColor($"{i + 1}. {worstStudents[i].Surname} {worstStudents[i].Name}", ConsoleColor.White);
            Console.ReadKey();
        }
        
        static int[] RandomMarks(int count)
        {
            int[] marks = new int[count];
            for (int i = 0; i < count; i++)
                marks[i] = rand.Next(2, 6);
            return marks;
        }
    }
}
