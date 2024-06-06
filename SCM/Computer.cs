using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM
{
    internal class Computer : Elektronik
    {
        public bool Masaüstü { get; set; }
        public bool Dizüstü { get; set; }
        public int Cpu { get; set; }
        public string Islemci { get; set; }

        public virtual void Options()
        {
            Console.WriteLine("Bu Ürünün Id'si: {0}", Id);
            Console.WriteLine("Bu Ürünün Adı: {0}", Name);
            Console.WriteLine("Bu Ürünün Fiyatı: {0}", Price);
            Console.WriteLine("Bu Ürünün İndirimli Fiyatı: {0}", Discount);
            Console.WriteLine("Bu Ürün masaüstümü: {0}",Masaüstü);
            Console.WriteLine("Bu Ürün dizüstümü: {0}",Dizüstü);
        }

    }
}
