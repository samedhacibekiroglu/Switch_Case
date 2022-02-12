using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter a number between 1 and 12..");
            month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("1.ay ocaktır");
                    break;
                case 2:
                    Console.WriteLine("2.ay şubattır");
                    break;
                case 3:
                    Console.WriteLine("3.ay marttır");
                    break;
                case 4:
                    Console.WriteLine("4. ay nisandır");
                    break;
                case 5:
                    Console.WriteLine("5. ay mayısdır");
                    break;
                case 6:
                    Console.WriteLine("6. ay hazirandır");
                    break;
                case 7:
                    Console.WriteLine("7. ay temmuzdur");
                    break;
                case 8:
                    Console.WriteLine("8. ay ağustostur");
                    break;
                case 9:
                    Console.WriteLine("9. ay eylüldür");
                    break;
                case 10:
                    Console.WriteLine("10. ay ekimdir");
                    break;
                case 11:
                    Console.WriteLine("11. ay kasımdır");
                    break;
                case 12:
                    Console.WriteLine("12. ay aralıkdır");
                    break;
                default:
                    Console.WriteLine("1 yıl 12 aydan oluşmaktadır..");
                    break;


            }

        }
    }
}
