using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW1
{
    class extract<T> where T : IComparable
    {
        Stack<T> temp;
        Stack<T> temp2;
        T temp1;
        public void stackOutValue (Stack<int> gelenStack,int deger)
        {//Stackten degeri search edip çıkartma methodu
            Stack<int> yedekStack = new Stack<int>(gelenStack.size());
            Stack<int> yedekStack2 = new Stack<int>(gelenStack.size());
            while (!gelenStack.isEmpty())
            {
                yedekStack.push(gelenStack.pop());          //Stacki yedekliyoruz.
            }
            while (!yedekStack.isEmpty())
            {
                int geciciYedekDeger=yedekStack.pop();
                gelenStack.push(geciciYedekDeger);
                if (geciciYedekDeger==deger)                //Stackte ki değeri ile çıkartacağımız değer ise o değeri çıkartıyoruz.Yani hiç bir şey yapmıyoruz.
                {
                    
                }
                else                                        //Değilse o değeri tekrar başka bir stacke ekliyoruz.
                {
                    yedekStack2.push(geciciYedekDeger);
                }
            }
            Stack<int> yeniStack = new Stack<int>(gelenStack.size());
            Console.WriteLine("Eski Stack");                                                    //Stackleri yazdırıyoruz.
            gelenStack.display();
            Console.WriteLine("Çıkarttığınız Değer "+deger);
            Console.WriteLine();
            Console.WriteLine("Yeni Stack");
            yedekStack2.display();
        }
       
      
    }
}
