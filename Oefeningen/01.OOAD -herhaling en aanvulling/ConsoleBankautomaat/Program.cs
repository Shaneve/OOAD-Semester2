using System;

namespace _01.OOAD_herhaling_en_aanvulling
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 500, storten, afhalen;
            string keuze;
            int pin = 0, x = 0;
            Console.WriteLine("Bankautomaat\n");
            Console.WriteLine("============\n\n");
            Console.WriteLine("Gebruik pincode \n");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("\na. Afhaling \n");
                Console.WriteLine("b. Storting \n");
                Console.WriteLine("c. Stoppen \n");
                Console.WriteLine("d. Uw huidig saldo \n");
                Console.WriteLine("Je keuze: ");
                keuze = Console.ReadLine();
                switch (keuze)
                {

                    case "a":
                        Console.WriteLine("\n Welk bedrag wil je afhalen: ");
                        afhalen = int.Parse(Console.ReadLine());
                        if (afhalen > saldo)
                        {
                            Console.WriteLine("\n Onvoldoende Saldo!");
                        }
                        else
                        {
                            saldo = saldo - afhalen;
                            Console.WriteLine("\n\n Afhaling ok-");
                            Console.WriteLine("het nieuw saldo is : {0}", saldo);
                        }
                        break;
                    case "b":
                        Console.WriteLine("\n Welk bedrag wil je storten: ");
                        storten = int.Parse(Console.ReadLine());
                        saldo = saldo + storten;
                        Console.WriteLine("Storting ok-");
                        Console.WriteLine("het nieuw saldo is : {0}", saldo);
                        break;
                    case "c":
                        Console.WriteLine("\n Bedankt en tot ziens.");
                        break;
                    case "d":
                        Console.WriteLine("\n Uw huidig saldo is : {0} ", saldo);
                        break;
                }
            }
        }
    }
}


