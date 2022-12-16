using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class Bank
    {
        public int Id { get; }
        public double Balance { get; set; }
        public string Type { get; }
        public string Holder { get; set; }
        public BankTransaction[] bankTransactions;
        public BankTransaction this[int index]
        {
            get => bankTransactions[index];
            set => bankTransactions[index] = value;
        }
        private Queue<double> TrancM = new Queue<double>();
        private Queue<DateTime> TrancD = new Queue<DateTime>();

        public Bank(double balance)
        {
            Balance = balance;
            Id = ID();
        }
        public Bank(string type)
        {
            Type = type;
            Id = ID();
        }
        public Bank(double balance, string type)
        {
            Balance = balance;
            Type = type;
            Id = ID();
        }
        List<int> list = new List<int>();
        int j = 0;
        private int ID()
        {
            Random random = new Random();
            int h = random.Next(10000000, 99999999);
            j++;
            for (int i = 0; i < list.Count; i++)
            {
                if (h == list[i])
                {
                    i = -1;
                    h = random.Next(10000000, 99999999);
                    continue;
                }
            }
            list.Add(h);
            return h;
        }

        public int Transfer(ref Bank bank, double a)
        {
            double b = bank.Balance;
            if (bank.Balance >= a)
            {
                bank.Balance = bank.Balance - a;
                Console.WriteLine($"Счет до операции: {b}$\nТекущий счет: {bank.Balance}$");
                BankTransaction transaction = new BankTransaction(a);
                TrancM.Enqueue(transaction.money);
                TrancD.Enqueue(transaction.date);
            }
            else
            {
                Console.WriteLine("На вашем счету недостаточно средств!!!");
            }
            return 0;
        }
        public void ReplenishmentBalance(ref Bank bank, int summa)
        {
            bank.Balance += summa;
            Console.WriteLine($"Баланс успешно пополнен!\nТекущий баланс: {bank.Balance}$");
            BankTransaction transaction = new BankTransaction(summa);
            TrancM.Enqueue(transaction.money);
            TrancD.Enqueue(transaction.date);
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер счета: {Id}\nБаланс: {Balance}\nТип: {Type}\nДержатель карты: {Holder}");
        }
    }
}
