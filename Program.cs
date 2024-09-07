using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            //task1
            Console.WriteLine("Введіть число x: ");
            double x = double.Parse(Console.ReadLine());
            double y;

            if (x >= 1) 
                y = Math.Log(x);
            else if (x > -1 && x < 1)
                y = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(1.8, 3));
            else
                y = Math.Exp(x);

            Console.WriteLine("----------------------");
            Console.WriteLine($"|   y = {y}  |");
            Console.WriteLine("----------------------");


            //task2
            Console.WriteLine("Введіть послідовно три числа:");
            double first  = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third  = double.Parse(Console.ReadLine());

            double result = (first + second + third)/3;

            Console.WriteLine("----------------------");
            Console.WriteLine($"Середнє арифметичне: {result}");
            Console.WriteLine("----------------------");

            //task3
            double a;   //Катет
            double b;   //Гіпотенуза
            double h;   //Висота
            double s;   //Площа

            Console.WriteLine("Введіть номер елементу:\r\n1) Катет\r\n2) Гіпотенуза\r\n3) Висота, яка опущена з вершини прямого кута на гіпотенузу \r\n4) Площа");
            int element = int.Parse(Console.ReadLine());
            switch (element)
            {
                case 1: {
                    Console.WriteLine("Введіть значення катету:");
                    a = double.Parse(Console.ReadLine());

                    b = a*Math.Sqrt(2);
                    h = Math.Sin(Math.PI/4)*a;
                    s = b*h/2;

                    Console.WriteLine($"Катет: {a} \r\n Гіпотенуза: {b} \r\n Висота: {h} \r\n Площа: {s}");
                    break;
                };

                case 2: {
                    Console.WriteLine("Введіть значення гіпотенузи:");
                    b = double.Parse(Console.ReadLine());

                    a = b/Math.Sqrt(2);
                    h = Math.Sin(Math.PI/4)*a;
                    s = b*h/2;

                    Console.WriteLine($" Катет: {a} \r\n Гіпотенуза: {b} \r\n Висота: {h} \r\n Площа: {s}");
                    break;
                };

                case 3: {
                    Console.WriteLine("Введіть значення висоти:");
                    h = double.Parse(Console.ReadLine());

                    a = h/Math.Sin(Math.PI/4);
                    b = a*Math.Sqrt(2);
                    s = b*h/2;

                    Console.WriteLine($" Катет: {a} \r\n Гіпотенуза: {b} \r\n Висота: {h} \r\n Площа: {s}");
                    break;
                };
                
                case 4: {
                    Console.WriteLine("Введіть значення площі:");
                    s = double.Parse(Console.ReadLine());

                    a = Math.Sqrt(2*s);
                    b = a*Math.Sqrt(2);
                    h = Math.Sin(Math.PI/4)*a;

                    Console.WriteLine($" Катет: {a} \r\n Гіпотенуза: {b} \r\n Висота: {h} \r\n Площа: {s}");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}   