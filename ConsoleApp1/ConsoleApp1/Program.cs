using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House[] arrHouses;
            Console.Write("Введiть кiлькiсть будинкiв: ");
            int cntHouses = int.Parse(Console.ReadLine());
            arrHouses = new House[cntHouses];
            for (int i = 0; i < cntHouses; i++)
            {
                Console.Write("Введiть ширину: ");
                double sWidth = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введiть довжину: ");
                double sLength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введiть висоту: ");
                double sHeight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введiть кiлькiсть кiмнат: ");
                int sRoom = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введiть кiлькiсть поверхiв: ");
                int sFloor = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введiть цiну опалення: ");
                double sValue = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введiть цiну за квадратний метр: ");
                double sPrice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Чи є меблi та технiка? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasForniture = Console.ReadKey();
                Console.WriteLine();
                House TheHouse = new House();
                TheHouse.Width = sWidth;
                TheHouse.Length = sLength;
                TheHouse.Height = sHeight;
                TheHouse.Room = sRoom;
                TheHouse.Floor = sFloor;
                TheHouse.Value = sValue;
                TheHouse.Price = sPrice;
                TheHouse.HasForniture = keyHasForniture.Key == ConsoleKey.Y ? true : false;
                arrHouses[i] = TheHouse;
            }
                    foreach (House t in arrHouses)
                    {
                        Console.WriteLine();
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine("Данi про об'єкт: ");
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine("Ширина: " + t.Width + "м");
                        Console.WriteLine("Довжина: " + t.Length + "м");
                        Console.WriteLine("Висота: " + t.Height + "м");
                        Console.WriteLine("Кiлькiсть кiмнат: " + t.Room);
                        Console.WriteLine("Кiлькiсть поверхів: " + t.Floor); 
                        Console.WriteLine("Ціна за опалення: " + t.Value);
                        Console.WriteLine("Цiна за квадратний метр: " + t.Price + "грн");
                        Console.WriteLine(t.HasForniture ? "У будинку є меблi та технiка" : "У будинку немає меблiв та технiки");
                        Console.WriteLine();
                        Console.WriteLine("Загальна вартість будинку: " + t.GetCost().ToString("0.00") + "грн");
                        Console.WriteLine("Вартість опалення: " + t.Heating().ToString("0.00") + "грн");
                    }
                    Console.ReadKey();
                }

            }
        }
 

