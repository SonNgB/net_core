﻿using System;

delegate int NumberChanger(int n);
namespace VietJackCsharp
{
    class TestCsharp
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Delegate trong C#");
            Console.WriteLine("----------------------------------");

            //tao cac doi tuong delegate
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //goi cac phuong thuc boi su dung cac doi tuong delegate
            nc1(25);
            Console.WriteLine("Gia tri cua num la: {0}", getNum());
            nc2(5);
            Console.WriteLine("Gia tri cua num la: {0}", getNum());
            Console.ReadKey();
        }
    }
}