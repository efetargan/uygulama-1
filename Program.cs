using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyp_Uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                bool ekipmanOduncte = false;

                Console.WriteLine("--- Ekipman Ödünç Sistemi ---");


                if (ekipmanOduncte)
                {
                    Console.WriteLine("HATA: Bu ekipman şu an başkasında. Talebin reddedildi!");
                    return;
                }

                Console.Write("Kaç günlüğüne alacaksın?");
                string kullaniciGirisi = Console.ReadLine();


                if (int.TryParse(kullaniciGirisi, out int gunSayisi))
                {

                    if (gunSayisi >= 1 && gunSayisi <= 7)
                    {
                        Console.WriteLine($"İşlem tamam! Ekipmanı {gunSayisi} günlüğüne aldın.");
                    }
                    else
                    {
                        Console.WriteLine("HATA: Sadece 1 ile 7 gün arasında alabilirsin. Talep reddedildi.");
                    }
                }
                else
                {
                    Console.WriteLine("HATA: Talep reddedildi.");
                }

                Console.ReadKey();
            }
        }
    }


