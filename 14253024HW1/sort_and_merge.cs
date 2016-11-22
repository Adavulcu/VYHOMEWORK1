using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW1
{
    class sort_and_merge<T> where T : IComparable
    {
        
        Stack<T> stack;
       
        Stack<T> temp_stack;
        Stack<T> temp_stack1;
        Stack<T> temp_stack2;
       
        public Stack<T> sortAndMerge(Stack<T> st,Stack<T> st1 )
        {                
            //sıralama yaparken ihtiyac duydugum tüm dizileri olusturdum
            stack = new Stack<T>(st.size() + st1.size());
            temp_stack = new Stack<T>(st.size() + st1.size());
            temp_stack1 = new Stack<T>(st.size() + st1.size());
            temp_stack2 = new Stack<T>(st.size() + st1.size());                     
           
            while (!st.isEmpty())//ilk diziyi yedek diziye aktardım
            {
                temp_stack.push(st.pop());
               
            }
         while(!st1.isEmpty())//ikinci diziyi yedek diziye aktardım
            {
                temp_stack.push(st1.pop());
               
            }
            
            sort();
         
            for (int i = 0; i < temp_stack1.size(); i++)
            {
                if(!temp_stack1.isEmpty())
                st1.push(temp_stack1.pop());
            }
          
            return  st1;
        }

        public void sort()//degerleri kücükten büyüge sıralama methodu
        {
            T temp1,temp2;
            T min;         
           while(!temp_stack.isEmpty())
            { 
                min = temp_stack.peek();
                while (!temp_stack.isEmpty())//min degişkenine ilk elamanın degeri atadıktan sonra stack icini bir bir kontrol edip
                    //en küçük elemanı tespit ettim bir yanda dan yedek diziye(temp_stack2) aktarma yaptım
                {
                    temp1 = temp_stack.pop();
                    if (temp1.CompareTo(min)==-1)
                    {
                        min = temp1;
                    }
                    temp_stack2.push(temp1);
                    
                }
                while (!temp_stack2.isEmpty())// en küçük elamanı tespit ettikten sonra  aktarma yaptıgım temp_stack2 dizisinden en küçük
                    //elemanı cıkarıp temp_stack1 dizisine aktardım
                {
                    temp2 = temp_stack2.pop();
                    if (temp2.CompareTo(min)==0)
                    {
                        temp_stack1.push(temp2);
                    }
                    else
                        temp_stack.push(temp2);
                }
               
                

            }
            
        }
    }
}
