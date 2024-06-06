using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Desktop desktop = new Desktop();

            desktop.Id = Guid.NewGuid();
            desktop.Name = "Asus";
            desktop.Price = 43589.99;
            desktop.Discount = 43589.99;
            desktop.KasaBoyutu = 30;
            desktop.Cpu = 36;
            desktop.Islemci = "Intel i7";
            desktop.Dizüstü = false;
            desktop.Masaüstü = true;
            desktop.Monitorİnc = 29;
            desktop.Options();

            Ayirac();

            Laptop laptop = new Laptop();
            laptop.Id = Guid.NewGuid();
            laptop.Name = "Macbook";
            laptop.Price = 35499.99;
            laptop.Discount = 35499.99;
            laptop.Cpu = 16;
            laptop.EkranBoyutu = 15;
            laptop.Islemci = "M3";
            laptop.Dizüstü = true;
            laptop.Masaüstü = false;
            laptop.Options();

            Console.ReadLine();
        }

        static void Ayirac()
        {
            Console.WriteLine("**************************************");
        }
    }
}
