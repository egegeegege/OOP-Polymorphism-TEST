using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM
{
    internal class Elektronik
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private double _Discount { get; set; }
        public double Discount
        {
            get { return _Discount; }
            set { _Discount = Price / 1.10; }
        }

        public virtual void Options()
        {
            Console.WriteLine(" Bu Ürünün Id'si: {0}", Id);
            Console.WriteLine("Bu Ürünün Adı: {0}", Name);
            Console.WriteLine("Bu Ürünün Fiyatı: {0}", Price);
            Console.WriteLine("Bu Ürünün İndirimli Fiyatı: {0}",Discount);
        }

    }
}
