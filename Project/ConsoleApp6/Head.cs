using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Head
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();

            Console.WriteLine("Добрый день , прошу вас пройти простую процедуру регистрации");
            Console.WriteLine("HelloMaterBrunch");

            Console.WriteLine("Введите Логин");
            customer.Login = Console.ReadLine();
            Console.WriteLine("Введите Пароль");
            customer.Password = Console.ReadLine();

            if (customer.Password.Length < 5)
            {
                Console.WriteLine("Пароль должен содержать: буквы, цыфры, \n математическое выражение , заклинание, и желательно быть длиннее , чем 5 символов, повторите ввод");
                customer.Password = Console.ReadLine();

            }

            Console.WriteLine("Введите ваше имя");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Введите ваш email");
            customer.Email = Console.ReadLine();


            Email email = new Email();
            email.Confirm(customer);

            Console.WriteLine("Вам на почту пришло подтверждение,введите полученный пароль");
            int password = 3451;
            string confirm = Console.ReadLine();
            int confirm2 = Convert.ToInt32(confirm);
            if (confirm2 == password)
            {

                Console.WriteLine("Регистрация прошла успешна! Осталось только войти в аккаунт");
                reg:
                Console.WriteLine("Введите Логин");
                string fakelogin = Console.ReadLine();
                Console.WriteLine("Введите  пароль");
                string fakepassword = Console.ReadLine();
                if (fakelogin == customer.Login && fakepassword == customer.Password)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Вход произведен успешно");


                    Console.WriteLine("Список товаров");

                    Mobile mobile = new Mobile("XomyPro", 2500, "Xomy", 2400);

                    Console.WriteLine("Телефон");
                    Console.WriteLine("Название: " + mobile.Name);
                    Console.WriteLine("Цена: " + mobile.Price);
                    Console.WriteLine("Производитель: " + mobile.Manufacturer);
                    Console.WriteLine("Заряд: " + mobile.Charge);
                    Console.WriteLine(new String('-', 25));

                    Tablet tablet = new Tablet("Ixon", 1000, "Koe", 12);

                    Console.WriteLine("Планшет");
                    Console.WriteLine("Название: " + tablet.Name);
                    Console.WriteLine("Цена: " + tablet.Price);
                    Console.WriteLine("Производитель: " + tablet.Manufacturer);
                    Console.WriteLine("Диагональ: " + tablet.Diagonale);
                    Console.WriteLine(new String('-', 25));

                    Computer computer = new Computer("Rg8", 5000, "Dell", 233);

                    Console.WriteLine("Компьютер");
                    Console.WriteLine("Название: " + computer.Name);
                    Console.WriteLine("Цена: " + computer.Price);
                    Console.WriteLine("Производитель: " + computer.Manufacturer);
                    Console.WriteLine("Диагональ: " + computer.Power);
                    Console.WriteLine(new String('-', 25));


                    Product[] products = new Product[]
                    {
                        tablet,
                        mobile,
                        computer
                    };

                    Console.WriteLine();
                    Console.WriteLine($"Здравствуйте {customer.Name} ваш баланс {customer.Balance}");

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                    }
                    metka:

                    Console.WriteLine("Выберете номер товара и нажмите Enter:");
                    string str = Console.ReadLine();
                    int productNumber = Convert.ToInt32(str);

                    Informer informer = new Informer();




                    if (productNumber >= 0 && productNumber < products.Length)
                    {
                        if (products[productNumber].Price <= customer.Balance)
                        {
                            informer.Buy(customer, products[productNumber]);
                            Console.WriteLine("Платеж прошел");
                            Console.WriteLine("Желаете приобрести еще что-то?(Y/N)");     // Вот сюдой запилить делегат и событие
                            string choose = Console.ReadLine();

                            if (choose == "Y")
                            {

                                Console.WriteLine($"Оставшийся баланс{customer.Balance}");

                                goto metka;
                             }
                            else
                            {
                                if (choose == "N")
                                {
                                    Console.WriteLine("Ваш заказ принят,ожидайте");

                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели некорректный символ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Таких товаров нету");
                    }
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль, попробуйте ещё раз");
                    goto reg;
                }
            }

            else
            {
                Console.WriteLine("Вы не прошли регистрацию");
            }

        }
    }
}
