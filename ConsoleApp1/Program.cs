using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string>tech=new List<string>();
            {
             
                tech.Add("1.earphones");
                tech.Add("2.phones");
                tech.Add("3.laptops");
                tech.Add("4.woofers");
                tech.Add("5.Televisions");
                Console.WriteLine("WELCOME " +
                                  "ITEMS AVAILABLE IN OUR STORE");
                foreach (string o in tech)
                {
                    Console.WriteLine($"{o}");
                }
                
                
                Console .WriteLine("ENTER THE PRODUCT YOU WANT?");

               var input = Console.ReadLine();
                if (input=="earphones")
                {
                    earphones();
                }

                if (input=="phones")
                {
                    phones();
                }

                if (input == "laptops")
                {
                    laptops();
                }

                if (input=="Woofers")
                {
                    Woofers();
                }
                if (input=="Televisions")
                {
                    Televisions();
                }


                Console.ReadKey();


            }
           
         
            
        }
       static  void earphones()
        {
            List<string>types=new List<string>();
            {
                types.Add("Samsung, price=200");
                types.Add("Huawei, price=300");
                types.Add("Itel, price=150");
                foreach (var d in types)
                {
                    Console.WriteLine($"{d}");
                }
            }
                    
        }
         static void phones()
        {
            List<string>phone=new List<string>();
            {
                phone.Add("Samsung, price=12000");
                phone.Add("Huawei, price=33000");
                phone.Add("Itel, price=15000");
                phone.Add("Iphone, price=70000");
                phone.Add("Alcatel, price=16000");
                phone.Add("Xiaomi, price=13000");
                phone.Add("Oppo, price=19000");
                phone.Add("Tecno, price=14000");
                phone.Add("LG, price=33000");
                foreach (var q in phone)
                {
                    Console.WriteLine($"{q}");
                }
            }
                    
        } 
        static void laptops()
        {
            List<string>laptop=new List<string>();
            {
                laptop.Add("Hp, price=32000");
                laptop.Add("Lenovo, price=30000");
                laptop.Add("Dell, price=45550");
                laptop.Add("Asus, price=34000");
                laptop.Add("MacBook, price=56000");
                laptop.Add("Gerry, price=23000");
                foreach (var L in laptop)
                {
                    Console.WriteLine($"{L}");
                }
            }
                    
        }
       static void Woofers()
        {
            List<string>woofer=new List<string>();
            {
               woofer.Add("Sayona, price=9200");
               woofer.Add("LG, price=7000");
                woofer.Add("EchoSounds, price=4050");
                woofer.Add("IgniteSounds, price=5600");
                woofer.Add("Sony, prices=8000");
                woofer.Add("Samsung, price=7600");
                foreach (var W in woofer)
                {
                    Console.WriteLine($"{W}");
                }
            }
                    
        }
        static void Televisions()
        {
            List<string>Television=new List<string>();
            {
              Television.Add("Vacuum, price=9200");
              Television.Add("Akira, price=4050");
               Television.Add("LG, price=5600");
              Television.Add("Sony, prices=38000");
               Television.Add("Samsung, price=76050");
                foreach (var T in Television)
                {
                    Console.WriteLine($"{T}");
                }
            }
                    
        }
    }
}