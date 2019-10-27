using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLesson
{
    class Program
    {
        static void Main(string[] args) //値渡し
        {
            int x = 10;
            Fuga(x);
            Console.WriteLine("main:x=" + x);
            int[] arr = { 2, 4, 6 };
            Hoge(arr);　//渡される
            
            Console.WriteLine("main:arr[0]=" + arr[0]);
            FugaRef(ref num);
            Console.WriteLine("main:num=" + num);
            HogeRef(ref arr);
            Console.WriteLine("main:arr[0]=" + arr[0]);
            int[] arr2;
            HogeOut(out arr2);
            Console.WriteLine(arr2[0]);
           
            }

        }
        static void Fuga(int num)
        {
            num = num * 2;
            Console.WriteLine("inFunga:num=" + num);
        }
        static void Hoge(int[] arr)
        {
            arr = new int[] { 3, 4, 5 }; //参照値は渡すが上書きされる//newされない限り動かす値は変わらない
            Console.WriteLine("inHoge:arr[0]=" + arr[0]);
        }
        static void HogeRef(ref int[] arr)
        {
            arr = new int[] { 3, 4, 5 };
            Console.WriteLine("inHogeRef:arr[0]=" + arr[0]);
        }


        static void FugaRef(ref int num)
        {
            num = num * 2;
            Console.WriteLine("inFugaRef:num=" + num);
        }
        /*static void Piyo(int[] arr) //参照値渡し
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2;
            }
            Console.WriteLine("inPiyo:arr[0]=" + arr[0]);　//2倍してるから4
        }*/
        static void HogeOut(out int[] arr)
        {
            arr = new int[] { 3, 4, 5 };
            Console.WriteLine("inHogeOut:arr[0]=" + arr[0]);

        }
    }
}
