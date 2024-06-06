using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM
{
    internal class Desktop : Computer
    {

        public int KasaBoyutu { get; set; }
        public int Monitorİnc { get; set; }

        public virtual void Options()
        {
            Console.WriteLine(" Bu Ürünün Id'si: {0}", Id);
            Console.WriteLine("Bu Ürünün Adı: {0}", Name);
            Console.WriteLine("Bu Ürünün Fiyatı: {0}", Price);
            Console.WriteLine("Bu Ürünün İndirimli Fiyatı: {0}", Discount );
            Console.WriteLine("Bu Ürün masaüstümü: {0}", Masaüstü);
            Console.WriteLine("Bu Ürün dizüstümü: {0}", Dizüstü);
            Console.WriteLine("Bu Ürün Kasa Boyutu: {0}", KasaBoyutu);
            Console.WriteLine("Bu Ürün Monitör Boyutu: {0}", Monitorİnc);
            Console.WriteLine("Bu Ürünün Ram'i: {0}", Cpu);
            Console.WriteLine("Bu Ürünün İşlemcisi: {0}", Islemci);
        }

    }
}
