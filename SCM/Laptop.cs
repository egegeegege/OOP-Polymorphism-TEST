using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SCM
{
    internal class Laptop : Computer
    {

        public int EkranBoyutu { get; set; }
        public int LaptopBuyuklugu { get; set; }

        public virtual void Options()
        {
            Console.WriteLine(" Bu Ürünün Id'si: {0}", Id);
            Console.WriteLine("Bu Ürünün Adı: {0}", Name);
            Console.WriteLine("Bu Ürünün Fiyatı: {0}", Price);
            Console.WriteLine("Bu Ürünün İndirimli Fiyatı: {0}", Discount );
            Console.WriteLine("Bu Ürün masaüstümü: {0}", Masaüstü);
            Console.WriteLine("Bu Ürün dizüstümü: {0}", Dizüstü);
            Console.WriteLine("Bu Ürün Kasa Boyutu: {0}", LaptopBuyuklugu);
            Console.WriteLine("Bu Ürün Ekran Boyutu: {0}", EkranBoyutu);
        }

    }
}
