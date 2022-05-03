using System;

namespace HoneyMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if(city == "Cairo")
            {
                totalPrice = (nights * 250) * 2 + 600;

                if (nights >= 1 && nights <= 4)
                {
                    totalPrice -= 0.03 * totalPrice;
                }

                else if(nights >= 5 && nights <= 9)
                {
                    totalPrice -= 0.05 * totalPrice;
                }

                else if(nights >= 10 && nights <= 24)
                {
                    totalPrice -= 0.10 * totalPrice;
                }

                else if(nights >= 25 && nights <= 49)
                {
                    totalPrice -= 0.17 * totalPrice;
                }

                else if(nights >= 50)
                {
                    totalPrice -= 0.30 * totalPrice;
                }
            }

            else if (city == "Paris")
            {
                totalPrice = (nights * 150) * 2 + 350;
      
                if (nights >= 5 && nights <= 9)
                {
                    totalPrice -= 0.07 * totalPrice;
                }

                else if (nights >= 10 && nights <= 24)
                {
                    totalPrice -= 0.12 * totalPrice;
                }

                else if (nights >= 25 && nights <= 49)
                {
                    totalPrice -= 0.22 * totalPrice;
                }

                else if (nights >= 50)
                {
                    totalPrice -= 0.30 * totalPrice;
                }
            }

            else if (city == "Lima")
            {
                totalPrice = (nights * 400) * 2 + 850;

                if (nights >= 25 && nights <= 49)
                {
                    totalPrice -= 0.19 * totalPrice;
                }

                else if(nights >= 50)
                {
                    totalPrice -= 0.30 * totalPrice;
                }
            }

            else if (city == "New York")
            {
                totalPrice = (nights * 300) * 2 + 650;

                if (nights >= 1 && nights <= 4)
                {
                    totalPrice -= 0.03 * totalPrice;
                }

                else if (nights >= 5 && nights <= 9)
                {
                    totalPrice -= 0.05 * totalPrice;
                }

                else if (nights >= 10 && nights <= 24)
                {
                    totalPrice -= 0.12 * totalPrice;
                }

                else if (nights >= 25 && nights <= 49)
                {
                    totalPrice -= 0.19 * totalPrice;
                }

                else if (nights >= 50)
                {
                    totalPrice -= 0.30 * totalPrice;
                }
            }

            else if (city == "Tokyo")
            {
                totalPrice = (nights * 350) * 2 + 700;

                if (nights >= 10 && nights <= 24)
                {
                    totalPrice -= 0.12 * totalPrice;
                }

                else if (nights >= 25 && nights <= 49)
                {
                    totalPrice -= 0.17 * totalPrice;
                }

                else if (nights >= 50)
                {
                    totalPrice -= 0.30 * totalPrice;
                }
            }

            if(budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }

            else
            {
                double sumNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {sumNeeded:F2} leva.");
            }
        }
    }
}
