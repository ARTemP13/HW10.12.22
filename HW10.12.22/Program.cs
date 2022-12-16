using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("Задание 1");
            Bank bank1 = new Bank(10000, "Сберегательный");
            Bank bank2 = new Bank(9999);
            Bank bank3 = new Bank("Текущий");

            Console.WriteLine($"Баланс счета: {bank3.Balance}$\nТип счета: {bank3.Type}\nНомер счета: {bank3.Id}\n");
            Console.WriteLine($"Баланс счета: {bank2.Balance}$\nТип счета: {bank2.Type}\nНомер счета: {bank2.Id}\n");
            Console.WriteLine($"Баланс счета: {bank1.Balance}$\nТип счета: {bank1.Type}\nНомер счета: {bank1.Id}\n");
            int r = 1;
            while (r == 1)
            {
                Console.WriteLine("Введите счет который надо использовать(1 - bank1, 2 - bank2, 3 - bank3): ");
                int identification = int.Parse(Console.ReadLine());
                Console.WriteLine("Что вы хотите сделать?(0 - перевести, 1 - пополнить баланс)");
                int y = int.Parse(Console.ReadLine());
                if (identification == 1)
                {
                    switch (y)
                    {
                        case 0:
                            Console.WriteLine("Введите сумму, которую хотите перевести: ");
                            int summa1 = int.Parse(Console.ReadLine());
                            bank1.Transfer(ref bank1, summa1);
                            bank1[j].money = summa1;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                        case 1:
                            Console.WriteLine("Введите сумму пополнения: ");
                            int summa2 = int.Parse(Console.ReadLine());
                            bank1.ReplenishmentBalance(ref bank1, summa2);
                            bank1[j].money = summa2;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                    }
                }
                if (identification == 2)
                {
                    switch (y)
                    {
                        case 0:
                            Console.WriteLine("Введите сумму, которую хотите перевести: ");
                            int summa1 = int.Parse(Console.ReadLine());
                            bank2.Transfer(ref bank2, summa1);
                            bank1[j].money = summa1;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                        case 1:
                            Console.WriteLine("Введите сумму пополнения: ");
                            int summa2 = int.Parse(Console.ReadLine());
                            bank2.ReplenishmentBalance(ref bank2, summa2);
                            bank1[j].money = summa2;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                    }
                }
                if (identification == 3)
                {
                    switch (y)
                    {
                        case 0:
                            Console.WriteLine("Введите сумму, которую хотите перевести: ");
                            int summa1 = int.Parse(Console.ReadLine());
                            bank3.Transfer(ref bank3, summa1);
                            bank1[j].money = summa1;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                        case 1:
                            Console.WriteLine("Введите сумму пополнения: ");
                            int summa2 = int.Parse(Console.ReadLine());
                            bank3.ReplenishmentBalance(ref bank3, summa2);
                            bank1[j].money = summa2;
                            bank1[j].date = DateTime.Now;
                            j++;
                            break;
                    }
                }
                Console.WriteLine("Хотите продолжить операции с приложением введите 1, хотите выйти введите 2");
                r = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();


            Console.WriteLine("Задание 2");
            Random random1 = new Random();
            Building building1 = new Building(random1.Next(100), 40, 5, 100, 5);
            SomeBuilding someBuilding = new SomeBuilding(new[] 
            { new Building(random1.Next(100), 40, 5, 100, 5), new Building(random1.Next(100), 35, 6, 110, 4), new Building(random1.Next(100), 37, 4, 111, 6),   });
            building1.InfoB();
            building1.FloorHeight();
            building1.Apartament();
            building1.ApartamentFloor();
            Console.ReadLine();


        }
    }
}
