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
    
        public void ext(T value,Stack<T>st)
        {
           
            temp = new Stack<T>(st.size());//parametre olarak alınan stackin yedeklendigi stack
            temp2 = new Stack<T>(st.size());//parametre olarak alınan ve cıkarılması istenen degerin tutuldugu yedek stack
            try
            {             
               for (int i = 0; i < st.size(); i++)//stack  elemanları yedek stacak aktarılıyor
                 {
                     if (!st.isEmpty())
                        temp.push(st.pop());
                 }                   
               for (int i = 0; i < temp.size(); i++)
                 {
                     if (!temp.isEmpty())
                     {
                        temp1 = temp.pop();
                        if (temp1.CompareTo(value)==0)//eger istenen deger stackta yoksa kontrol edilen stack elemanı tekrar eski stackine akatarılıyor
                        {
                            
                            temp2.push(temp1);
                        }
                        else// eger stackteki elaman aranan elemanla eşleşiyorsa eşleşen stack elemanı diger yedek stack elemanına aktarılıyor
                            st.push(temp1);
                    }
                 }
                Console.WriteLine("\tstackin son hali...\n");   
                st.display();
                if(!temp2.isEmpty())
                Console.WriteLine("\tstacktan cıkarılan deger..\n");
               temp2.display();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
       
      
    }
}
