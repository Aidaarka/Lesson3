using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3.OOP
{
    class Worker
    {
        string fullName;
        int salary;
        int age;

        Worker(string fullName, int salary, int age)
        {
            this.fullName = fullName;
            this.salary = salary;
            this.age = age;
        }

        void ShowSalary()
        {
            if (salary > 30000)
            {
                Console.WriteLine(salary);
            }
        }

        static void Main()
        {
            var worker1 = new Worker("Коволева Марина Степановна", 47000, 31);
            var worker2 = new Worker("Аркадьев Лимур Потшевич", 41000, 26);
            var worker3 = new Worker("Ларисов Гузей Лучникович", 29000, 53);
            var worker4 = new Worker("Филимонов Петр Степанович", 12000, 60);
            var worker5 = new Worker("Астапова Анастасия Петровна", 78000, 58);
            var worker6 = new Worker("Столяров Андрей Викторович", 95000, 47);
            var worker7 = new Worker("Третьяков Галерей Москович", 66000, 164);

            Worker[] Workers = { worker1, worker2, worker3, worker4, worker5, worker6, worker7 };

            foreach (var worker in Workers)
            {
                worker.ShowSalary();
            }
        }
    }
}
