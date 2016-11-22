using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW1
{
    class subset<T> where T : IComparable
    {
        CircularQueue<T> temp_queue;
        CircularQueue<T> temp_queue1;
        int counter = 0, counter1 = 0;// ilk ve ikinci dizilerin eleman sayısısı tutan degişkenler
        T temp,temp1;//ilk ve ikinci dizi elemnalarını gçici olarak atandıgı degişkenler
        public void subset_control(CircularQueue<T> que,CircularQueue<T> que1)
        {
            temp_queue= new CircularQueue<T>(que.size());//ilk dizi için yedek dizi
            temp_queue1 = new CircularQueue<T>(que1.size());//ikinci dizi için yedek dizi
            //ilk once dizilerin içinde kac tane eleman oldugunu tespit edilmesi lazım
            for (int i = 0; i < que.size(); i++)//ilk queue disinzeki eleman sayısını belirleme
            {
                if(!que.isEmpty())
                {
                    temp_queue.enQueue(que.deQueue());
                    counter++;
                }
            }
            for (int i = 0; i < que1.size(); i++) //ikinci queue disinzeki eleman sayısını belirleme
            {
                if(!que1.isEmpty())
                {
                    temp_queue1.enQueue(que1.deQueue());
                    counter1++;
                }
            }
            if (counter1 == counter)//eleman sayıları eşit ise dizilerin birbirine eşit olup olamadıgının bakıldııg yer
            {
                bool control = false;//ilk dizideki elamanın diger dizide olup olamdıgını kontrol eden degişken
                int control2 =0;//ilk diideki elemanların kac tanesinin ikinci dizide olup olmadıgını kontrol eden degişken
                for (int i = 0; i < counter; i++)
                {
                    temp = temp_queue.deQueue();
                                     
                    for (int j = 0; j < counter1; j++)
                    {
                        temp1 = temp_queue1.deQueue();
                      
                        if (temp.CompareTo(temp1)==0)
                        {                      
                            control =true ;
                                                              
                        }
                        temp_queue1.enQueue(temp1);
                    }
                 
                    if (control)
                        control2++;
                 
                    control = false;
                    temp_queue.enQueue(temp);
                }
              
               
                if (control2==counter)
                    Console.WriteLine("ilk ve ikinci diziler aynı dizilerdir... \n");
                else
                Console.WriteLine("ilk ve ikinci diziler farklı dizilerdir...\n");
               
            }
            else if (counter < counter1)//ilk dizinin elaman sayısı ikinci diziden küçükse
            {

                bool control = false;//ilk dizideki elamanın diger dizide olup olamdıgını kontrol eden degişken
                int control2 = 0;//ilk dizideki elemanların kac tanesinin ikinci dizide olup olmadıgını kontrol eden degişken
                for (int i = 0; i < counter; i++)
                {
                    temp = temp_queue.deQueue();
                 
                    for (int j = 0; j < counter1; j++)
                    {
                        temp1 = temp_queue1.deQueue();
                      
                        if (temp.CompareTo(temp1)==0)
                        {
                            control = true;
                          
                        }                   
                            temp_queue1.enQueue(temp1);
                                              
                    }

                    if (control)
                        control2++;
                    control =false;
                    temp_queue.enQueue(temp);
                }
                if(control2==counter)
                    Console.WriteLine("ilk dizi ikinci dizinin nin alt kümesidir...\n");
                else
                Console.WriteLine("ilk dizi ikinci dizinin nin alt kümesi degildir...\n");
               
            }
            else//ilk dizinin eleman sayısı ikinci diziden büyükse
            {

                bool control = false;//ilk dizideki elamanın diger dizide olup olamdıgını kontrol eden degişken
                int control2 = 0;//ilk diideki elemanların kac tanesinin ikinci dizide olup olmadıgını kontrol eden degişken
                for (int i = 0; i < counter1; i++)
                {
                   
                    temp1 = temp_queue1.deQueue();                 
                    for (int j = 0; j < counter; j++)
                    {
                        temp = temp_queue.deQueue();
                    
                        if (temp.CompareTo(temp1)==0)
                        {
                            control =true;
                     
                        }
                        temp_queue.enQueue(temp);                                                 
                    }
                    if (control)
                        control2++;
                    control = false;
                    temp_queue1.enQueue(temp1);
                }
                if(control2==counter1)
                Console.WriteLine("ikinci dizi ilk dizinin  nin alt kümesidir\n");
                else
                Console.WriteLine("ikinci dizi ilk dizinin nin alt kümesi degildir...\n");
            }

        }
       
    }
}
