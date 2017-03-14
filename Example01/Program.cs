using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            status response = status.Success;
            switch (response)
            {
                case status.Success:
                    //你要寫的程式
                    Console.WriteLine("狀態成功");
                    Console.WriteLine((int)response);
                    break;

                case status.Error:
                    //你要寫的程式
                    Console.WriteLine("狀態錯誤");
                    Console.WriteLine(response);
                    break;

                default:
                    //你要寫的程式
                    Console.WriteLine("未知狀態");
                    Console.WriteLine(response);
                    break;
            }
        }
    }
}