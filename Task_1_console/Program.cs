using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string secondName;
            string birthday;
            string phone;
            int[] ocenka = null;
            List<Student> StudentList = new List<Student>();

            while(true)
            {
                ocenka = new int[10];
                try
                {
                    Console.WriteLine("Добро пожаловать!\r\n");
                    Console.WriteLine("Меню:\r\n1) Добавить студента;\r\n2) Вывести список студентов;\r\n3) Очистить консоль;\r\n4) Выход;");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.WriteLine("Введите имя:");
                            name = Console.ReadLine();
                            Console.WriteLine("Введите Фамилию:");
                            secondName = Console.ReadLine();
                            Console.WriteLine("Введите год рождения:");
                            birthday = Console.ReadLine();
                            Console.WriteLine("Введите номер телефона:");
                            phone = Console.ReadLine();
                            Console.WriteLine("Введите оценки:");
                            for (int i = 0; i < 10; ++i)
                            {
                                Console.WriteLine(string.Format("{0}) ", i + 1));
                                int o = Convert.ToInt32(Console.ReadLine());
                                if (o <= 5)
                                {
                                    ocenka[i] = o;
                                }
                                else
                                {
                                    Console.WriteLine("Не верное значение!");
                                    Console.WriteLine(string.Format("{0}) ", i + 1));
                                    int p = Convert.ToInt32(Console.ReadLine());
                                    ocenka[i] = p;
                                }
                            }
                            StudentList.Add(new Student() { Name = name, SecondName = secondName, Birthdey = birthday, Phone = phone, Ocenka = ocenka });
                            Console.Clear();
                            break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            //foreach (var l in StudentList)
                            for(int i = 0; i < StudentList.Count; ++i)
                            {
                                int LenghtFive = 0;
                                for(int p = 0; p < StudentList[i].Ocenka.Length; ++p)
                                {
                                    if(StudentList[i].Ocenka[p] == 5)
                                    {
                                        LenghtFive++;
                                    }
                                }
                                Console.WriteLine(string.Format("{0} {1} / {2} / {3} / Количество оценок \"5\": {4}\r\n", StudentList[i].Name, StudentList[i].SecondName, StudentList[i].Birthdey, StudentList[i].Phone, LenghtFive));
                            }
                            break;
                        case ConsoleKey.D3:
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Environment.Exit(0);
                            break;
                        default:

                            break;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }

        }
    }

    class Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Birthdey { get; set; }
        public string Phone { get; set; }
        public int[] Ocenka { get; set; }
    }
}
