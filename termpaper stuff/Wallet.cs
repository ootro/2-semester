using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet
{
    public class Account
    {
        internal string account_name;
        decimal account_value;

        const string replenish1 = "зарплата";
        decimal r1 = 0;
        const string replenish2 = "позика";
        decimal r2 = 0;
        const string replenish3 = "бiзнес";
        decimal r3 = 0;
        const string replenish4 = "подарунок";
        decimal r4 = 0;

        const string spend1 = "їжа";
        decimal s1 = 0;
        const string spend2 = "одяг";
        decimal s2 = 0;
        const string spend3 = "розваги";
        decimal s3 = 0;
        const string spend4 = "позика";
        decimal s4 = 0;

        public Account(string name, decimal value)
        {
            this.account_name = name;
            this.account_value = value;
        }

        

        public void Output()
        {
            Console.WriteLine("Назва акаунту: " + account_name + " ||| Баланс акаунту: " + account_value);
            return;
            
        }

        public void Type_output()
        {
            Console.WriteLine("Звiт для: " + account_name);
            Console.WriteLine("------Надходження------");
            Console.WriteLine("Заробiтня плата: " + r1);
            Console.WriteLine("Позика: " + r2);
            Console.WriteLine("Прибуток вiд бiзнесу: " + r3);
            Console.WriteLine("Подарунок: " + r4);
            Console.WriteLine("------Витрати------");
            Console.WriteLine("Їжа: " + s1);
            Console.WriteLine("Одяг: " + s2);
            Console.WriteLine("Розваги: " + s3);
            Console.WriteLine("Позика: " + s4);
        }

        public static decimal operator +(Account obj, decimal value)
        {
            return obj.account_value + value;
        }

        public void Adder(int value)
        {
            account_value += value;
            
            return;
        }

        static public void Transfer(Account obj1, Account obj2, decimal value)
        {
            if (value > obj1.account_value)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Недостатньо коштiв!");
                Menu.TransferMenu();
            }
            else
            {
                obj2.account_value += value;
                obj1.account_value -= value;
                
            }           
            
            return;
        }

        static public void Replenish(Account obj1, decimal value, string type)
        {
            
            switch (type.ToLower())
            {
                case replenish1:
                    obj1.r1 += value;
                    obj1.account_value += value;
                    break;
                case replenish2:
                    obj1.r2 += value;
                    obj1.account_value += value;
                    break;
                case replenish3:
                    obj1.r3 += value;
                    obj1.account_value += value;
                    break;
                case replenish4:
                    obj1.r4 += value;
                    obj1.account_value += value;
                    break;
                default:
                    Console.WriteLine("Неправильна стаття надходження коштів.");
                    break;
            }
            return;
        }
        static public void Spend(Account obj1, decimal value, string type)
        {
            if (value > obj1.account_value)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Недостатньо коштiв!");
                Transfers.SpendOrReplenish();
            }
            else
            {
                switch (type.ToLower())
                {
                    case spend1:
                        obj1.s1 -= value;
                        obj1.account_value -= value;
                        break;
                    case spend2:
                        obj1.s2 -= value;
                        obj1.account_value -= value;
                        break;
                    case spend3:
                        obj1.s3 -= value;
                        obj1.account_value -= value;
                        break;
                    case spend4:
                        obj1.s4 -= value;
                        obj1.account_value -= value;
                        break;
                    default:
                        Console.WriteLine("Неправильна стаття витрат!");
                        break;
                }
            }
            
            return;
        }


    }

    public class Menu
    {
        internal static Account[] accounts = new Account[5];
        static int counter = 0;
        static public void MainMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Оберiть, що Ви хочете зробити: ");
            Console.WriteLine("1 - Створити новий рахунок");
            Console.WriteLine("2 - Оглянути створенi рахунки");
            Console.WriteLine("3 - Зробити переказ коштiв");
            Console.WriteLine("4 - Оглянути звiт за статтями витрат та надходжень");
            Console.WriteLine("5 - Вихiд");
            Console.WriteLine("-------------------------------------");
            string input;

            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    NewAcc();
                    break;
                case "2":
                    Accounts();
                    break;
                case "3":
                    TransferMenu();
                    break;
                case "4":
                    Summary();
                    break;
                case "5":
                    return;
                    
                default:
                    Console.WriteLine("Неправильна команда.");
                    MainMenu();
                    break;
            }

        }
        static public void NewAcc()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ви можете створити до 5 рахункiв.");
            Console.WriteLine("Введiть iм'я для рахунку: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введiть початковий баланс для рахунку: ");
            string value = Console.ReadLine();
            decimal dec = Convert.ToDecimal(value);
            Account acc = new Account(name, dec);
            accounts[counter] = acc;
            counter += 1;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Новий рахунок успiшно створено!");
            Console.WriteLine("-------------------------------------");
            MainMenu();

        }

        static public void Accounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                try
                {
                    Console.WriteLine("-------------------------------------");
                    accounts[i].Output();
                    Console.WriteLine("-------------------------------------");
                }
                catch
                {
                    Console.WriteLine("Цей рахунок ще не створено.");
                }

            }
            MainMenu();
        }

        static public void TransferMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Оберiть, що Ви хотiли б зробити: ");
            Console.WriteLine("1 - Витратити кошти / Поповнити рахунок");
            Console.WriteLine("2 - Перевести кошти з одного рахунку на iнший");
            Console.WriteLine("3 - Повернутися до головного меню");
            Console.WriteLine("-------------------------------------");
            string input;

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Transfers.SpendOrReplenish();
                    break;
                case "2":
                    Transfers.OneToAnother();
                    break;
                case "3":
                    MainMenu();
                    break;
            }
        }
        static public void Summary()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Введiть назву рахунку, для якого Ви хотiли б побачити звiт: ");
            string name;
            name = Console.ReadLine();
            for (int i = 0; i < accounts.Length; i++)
            {
                try
                {
                    if (name == accounts[i].account_name)
                    {
                        accounts[i].Type_output();
                    }
                    
                }
                catch
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Неправильна назва рахунку!");
                }
                finally
                {
                    MainMenu();
                }
                
            }
        }


    }

    public class Transfers : Menu
    {
        delegate void Transfer(Account obj1, decimal value, string type);
        static Transfer to = Account.Spend;
        static Transfer back = Account.Replenish;

        public static void SpendOrReplenish()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Що саме Ви хотiли б зробити?");
            Console.WriteLine("1 - Витратити");
            Console.WriteLine("2 - Поповнити");
            Console.WriteLine("3 - Повернутися до головного меню");
            Console.WriteLine("-------------------------------------");
            string choice;
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Введiть назву рахунку: ");
                    string name;
                    name = Console.ReadLine();
                    Console.WriteLine("Введiть кiлькiсть коштiв, яку Ви хотіли б витратити: ");
                    decimal value;
                    value = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Статтi витрат: ");
                    Console.WriteLine("їжа, одяг, розваги, позика");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Введiть потрiбну статтю витрат: ");
                    string type;
                    type = Console.ReadLine();
                    try
                    {
                        if (name == accounts[0].account_name)
                        {
                            to(accounts[0], value, type);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (name == accounts[1].account_name)
                        {
                            to(accounts[1], value, type);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (name == accounts[2].account_name)
                        {
                            to(accounts[2], value, type);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (name == accounts[3].account_name)
                        {
                            to(accounts[3], value, type);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (name == accounts[4].account_name)
                        {
                            to(accounts[4], value, type);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        
                        
                    }
                    catch
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Неправильна назва рахунку!");
                    }
                    finally
                    {
                        SpendOrReplenish();
                    }
                                                         
                    break;

                case "2":
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Введiть назву рахунку: ");
                    string repname;
                    repname = Console.ReadLine();
                    Console.WriteLine("Введiть кiлькiсть коштiв, яку Ви хотiли б отримати: ");
                    decimal repvalue;
                    repvalue = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Статтi отримання коштiв: ");
                    Console.WriteLine("зарплата, позика, бiзнес, подарунок");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Введiть потрiбну статтю отримання коштiв: ");
                    string reptype;
                    reptype = Console.ReadLine();
                    try
                    {
                        if (repname == accounts[0].account_name)
                        {
                            back(accounts[0], repvalue, reptype);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (repname == accounts[1].account_name)
                        {
                            back(accounts[1], repvalue, reptype);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (repname == accounts[2].account_name)
                        {
                            back(accounts[2], repvalue, reptype);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (repname == accounts[3].account_name)
                        {
                            back(accounts[3], repvalue, reptype);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        else if (repname == accounts[4].account_name)
                        {
                            back(accounts[4], repvalue, reptype);
                            Console.WriteLine("Операцiя успiшна!");
                            MainMenu();
                        }
                        
                    }
                    catch
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Неправильна назва рахунку!");
                    }
                    finally
                    {
                        SpendOrReplenish();
                    }
                    
                    break;
                case "3":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Неправильний вибiр.");
                    SpendOrReplenish();
                    break;
            }
        }
        public static void OneToAnother()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Введiть назву рахунку, з якого будуть знятi кошти: ");
            string name1;
            name1 = Console.ReadLine();
            Console.WriteLine("Введiть назву рахунку, на який буде здiйснено переказ коштiв: ");
            string name2;
            name2 = Console.ReadLine();
            Console.WriteLine("Введiть кiлькiсть коштiв для переказу: ");
            decimal value;
            value = Convert.ToDecimal(Console.ReadLine());
            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts.Length; j++)
                {
                    while (i != j)
                    {
                        try
                        {
                            if (name1 == accounts[i].account_name && name2 == accounts[j].account_name)
                            {
                                Account.Transfer(accounts[i], accounts[j], value);
                                Console.WriteLine("Операцiя успiшна!");
                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("Неправильна назва рахунку.");
                                MainMenu();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Неправильна назва рахунку.");
                        }
                        finally
                        {
                            MainMenu();
                        }
                    }
                    
                }
            }
          

        }
    }
   
}
