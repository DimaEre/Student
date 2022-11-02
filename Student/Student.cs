using System;
using System.Collections.Specialized;

class Students
{
    public string name;
    public string surname;
    public string group;
    public string DOB; // date of birthday
    public int[] grades1; // grades
    public int[] grades2; // grades
    public int[] grades3; // grades
    public Students()
    {
        name = "";
        surname = "";
        group = "";
        DOB = "";
        grades1 = new int[0];
        grades2 = new int[0];
        grades3 = new int[0];
    }
    public void add(int b, int c)
    {
        if (b == 0)
        {
            int[] bufer = new int[grades1.Length + 1];
            Array.Copy(grades1,0, bufer, 0, grades1.Length);
            grades1 = new int[bufer.Length];
            bufer[bufer.Length-1] = c;
            Array.Copy(bufer,0, grades1,0,grades1.Length);
            
        }
        if (b == 1)
        {
            int[] bufer = new int[grades2.Length + 1];
            Array.Copy(grades2, 0, bufer, 0, grades2.Length);
            grades2 = new int[bufer.Length];
            bufer[bufer.Length - 1] = c;
            Array.Copy(bufer, 0, grades2, 0, grades2.Length);
        }
        if (b == 2)
        {
            int[] bufer = new int[grades3.Length + 1];
            Array.Copy(grades3, 0, bufer, 0, grades3.Length);
            grades3 = new int[bufer.Length];
            bufer[bufer.Length - 1] = c;
            Array.Copy(bufer, 0, grades3, 0, grades3.Length);
        }
    }
    public int average(int[] a)
    {
        int av = 0;
        for (int i = 0; i < a.Length; i++)
        {
            av += a[i];
        }
        if (a.Length == 0)
        {

        }
        else
        {
            av = av / a.Length;
        }
        return av;
    }
    public void see(int a)
    {
        if (a == 0)
        {
            Console.WriteLine("\nім'я: " + name + "\nпрізвище: " + surname + "\nгрупа: " + group + "\nдата народження: " + DOB);
            Console.Write("Оцінки з предмету історія:   ");
            for (int i = 0; i < grades1.Length; i++)
            {
                Console.Write(grades1[i] + " ");
            }
            Console.Write("\nОцінки з предмету математика: ");
            for (int i = 0; i < grades2.Length; i++)
            {
                Console.Write(grades2[i] + " ");
            }
            Console.Write("\nОцінки з предмету українська мова: ");
            for (int i = 0; i < grades3.Length; i++)
            {
                Console.Write(grades3[i] + " ");
            }
        }
        else if (a == 1)
        {
            Console.WriteLine("\nім'я: " + name + "\nпрізвище: " + surname + "\nгрупа: " + group + "\nдата народження: " + DOB);


            Console.Write("Середня оцінка з предмету історія:   ");
            Console.WriteLine(average(grades1));

            Console.Write("Середня оцінка з предмету математика:   ");
            Console.WriteLine(average(grades2));

            Console.Write("Середня оцінка з предмету українська мова:   ");
            Console.WriteLine(average(grades3));

        }
    }
}


class Program
{
    public static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int a = -1, b = -1, c = -1;

        Students[] students = new Students[3];

        students[0] = new Students()
        {
            name = "Лесь",
            surname = "Курбас",
            group = "НАУ",
            DOB = "25.02.1887"
        };

        students[1] = new Students()
        {
            name = "Нестор",
            surname = "Махно",
            group = "РПАУ",
            DOB = "7.11.1888"
        };

        students[2] = new Students()
        {
            name = "Дмитро",
            surname = "Донцов",
            group = "УПА",
            DOB = "29.07.1883"
        };

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("Додати оцінку\t - 1");
            Console.WriteLine("Показати оцінки\t - 2");
            Console.WriteLine("Показати середній бал\t - 3");

            a = Convert.ToInt32(Console.ReadLine());

            if (a == 1) //add
            {
                Console.Clear();
                a = -1;
                b = -1;
                c = -1;
                Console.WriteLine("Введіть номер студента(1 - 3):  ");
                while (a < 0 || a > 2) a = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("До якого предмету хочете додати?");
                Console.WriteLine("Історія \t - 1 ");
                Console.WriteLine("Математика \t - 2 ");
                Console.WriteLine("Українська мова \t - 3");
                while (b < 0 || b > 2) b = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.Write("Поставте оцінку:\t");
                while (c < 1 || c > 12) c = Convert.ToInt32(Console.ReadLine()); //12-point evaluation

                students[a].add(b, c);
                Console.Clear();
            }
            else if (a == 2) //see
            {
                Console.Clear();
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].see(0);
                    Console.WriteLine("\n\n");
                }

            }
            else if (a == 3) //GPA
            {
                Console.Clear();
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].see(1);
                    Console.WriteLine("\n\n");
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Ви певно напутали");
            }
        }

    }
}