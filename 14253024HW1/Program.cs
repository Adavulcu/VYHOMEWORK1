using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _14253024HW1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Stack<int> stk_int = new Stack<int>(10);//1. madde icin stack dizisi
            Stack<string> stk_string = new Stack<string>(10);//1. madde icin stack dizisi
            Stack<int> stk1_int = new Stack<int>(10);//2. madde için ilk stack dizisi
            Stack<int> stk2_int = new Stack<int>(10);//2. madee içim ikinci stack dizisi
            Stack<int> stk3_int = new Stack<int>(stk1_int.size() + stk2_int.size());//2. madde için iki stackin birleştigi dizi
            Stack<string> stk1_string = new Stack<string>(10);//2. madde için ilk stack dizisi
            Stack<string> stk2_string = new Stack<string>(10);//2. madee içim ikinci stack dizisi
            Stack<string> stk3_string = new Stack<string>(stk1_string.size() + stk2_string.size());//2. madde için iki stackin birleştigi dizi
            CircularQueue<int> circ_int = new CircularQueue<int>(10);//3. madde için ilk circularqueue dizisi
            CircularQueue<int> circ1_int = new CircularQueue<int>(10);//3. madde için ikinci circularqueue dizizi
            CircularQueue<string> circ_string = new CircularQueue<string>(10);//3. madde için ilk circularqueue dizisi
            CircularQueue<string> circ1_string = new CircularQueue<string>(10);//3. madde için ikinci circularqueue dizizi
            try
            {
                //ilk madde işlemleri
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\t\t\t\t1. maddee işlermleri.......\n");
                stk_string.push("a");
                stk_string.push("b");
                stk_string.push("c");
                stk_string.push("d");
                //stk_int.push(1);
                //stk_int.push(2);
                //stk_int.push(3);
                //stk_int.push(4);
                //stk_int.push(5);
                //stk_int.push(7);
                //stk_int.push(6);
                Console.WriteLine("\tstackin ilk hali..\n");
                //  stk_int.display();
                stk_string.display();
                extract<int> extract_int = new extract<int>();//stacktan deger cıkarmak için methot bulunduran
                //sınıfın nesnesi              
              //  extract_int.ext(3, stk_int);
              extract<string> extract_string = new extract<string>();
                extract_string.stackOutValue("a", stk_string);

                Console.WriteLine("\t\t\t\t2. maddeye gecmek için ENTER tusuna basın....\n");
              //  Console.ReadLine();

                /////***********************************************************************///////

                Console.WriteLine("*******************************************************************************************");
                //2. madde işlemleri
                Console.WriteLine("\t\t\t\t2. maddee işlermleri.......\n");
                //stk1_int.push(1);
                //stk1_int.push(3);
                //stk1_int.push(2);
                //stk1_int.push(15);
                //stk2_int.push(4);
                //stk2_int.push(17);
                //stk2_int.push(9);
                //stk2_int.push(46);
                stk1_string.push("abc");
                stk1_string.push("aa");
                stk1_string.push("a");
                stk1_string.push("abcef");
                stk2_string.push("dgg");
                stk2_string.push("apo");
                stk2_string.push("ac");
                Console.WriteLine("\tilk stack..." );
                //stk1_int.display();
                stk1_string.display();
                Console.WriteLine("\tikinci stack...");
                //stk2_int.display();
                stk2_string.display();
                sort_and_merge<int> sort_int = new sort_and_merge<int>();//stackleri birleştirmek için metoht bulunduran
                //sınıfın nesnesi

                //if (!stk3_int.isFull())
                 //  stk3_int = (sort_int.sortAndMerge(stk1_int, stk2_int));
                sort_and_merge<string> sort_string = new sort_and_merge<string>();//stackleri birleştirmek için metoht bulunduran
                //sınıfın nesnesi
                if (!stk3_string.isFull())
                    stk3_string = (sort_string.sortAndMerge(stk1_string, stk2_string));
                Console.WriteLine("\t stacklarin birleştirimiş ve sıralanmıs hali");
                // stk3_int.display();
                stk3_string.display();

                Console.WriteLine("\t\t\t\t3. maddeye gecmek için ENTER tusuna basın....\n");
               // Console.ReadLine();
                Console.WriteLine("*******************************************************************************************");

                /////////***********************************************************************///////

                //3. madde işlemleri

                Console.WriteLine("\t\t\t\t3. maddee işlermleri.......\n");
                //circ_int.enQueue(5);
                //circ_int.enQueue(1);
                //circ_int.enQueue(3);
                //circ_int.enQueue(4);
                //circ_int.enQueue(6);
                //circ1_int.enQueue(1);
                //circ1_int.enQueue(3);
                //circ1_int.enQueue(7);
                circ_string.enQueue("a");
                circ_string.enQueue("b");
                circ_string.enQueue("35");
                circ1_string.enQueue("a");
                circ1_string.enQueue("b");
                circ1_string.enQueue("35");
                //circ1_string.enQueue("c");
                Console.WriteLine("ilk dizi...\n");
                //circ_int.display();
                circ_string.display();
                Console.WriteLine("ikinci dizi\n");
                circ1_string.display();
                // circ1_int.display();

               // subset<int> sub_int = new subset<int>();//alt küme tespiti yaptıran methodu bulunduran
               //// sınıfın nesnesi
               // sub_int.subset_control(circ_int, circ1_int);
                subset<string> sub_string = new subset<string>();//alt küme tespiti yaptıran methodu bulunduran
                //sınıfın nesnesi
                sub_string.subset_control(circ_string, circ1_string);

                sw.Stop();
                Console.WriteLine(sw.Elapsed);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
       
    }
}
