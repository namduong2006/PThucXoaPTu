using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTXoaPTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] list = { 1, 11, 6, 9, 8, 46, 4, 33, 7, 0, 2, 5, 15 };
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int x;
            Console.WriteLine("Nhập giá trị muốn xóa");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(Xoa(list,x));
            Console.ReadLine();
        }
          public static string Xoa(int[]list,int x)
          {
            int t;
            string kq = "CẢM ƠN ĐÃ SỬ DỤNG CHƯƠNG TRÌNH";
            bool tim = false;
            for (int i = 0; i < list.Length-1; i++)
            {
                if (list[i] == x)
                {
                    t = i;
                    Console.WriteLine($"Xóa giá trị {x} tại vị trí {t+1}. Kết quả:");
                    for (int j = t; j < list.Length - 1; j++)
                    {
                        list[j] = list[j + 1];
                    }
                    list[list.Length - 1] = 0;
                    tim = true;
                }
            }
            if (tim == true)
            {
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            if (!tim)
            {
                Console.WriteLine("Không tìm thấy giá trị muốn xóa trong mảng");
            }            
            return kq;
          }
    }
}
