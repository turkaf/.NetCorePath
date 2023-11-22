using System;

namespace C__101;

class Program
{
    static void Main(string[] args)
    {
        int deger = 2;
        string degisken = null;

        byte b = 5;
        sbyte c = 5;

        short s = 5;
        ushort us = 5;

        Int16 i16 = 2;
        int i = 2;
        Int32 i32 = 2;
        Int64 i64 = 2;
        uint ui = 2;

        long l = 4;
        ulong ul = 4;

        float f = 5;
        double d = 5;

        decimal de = 5;

        char ch = 'c';
        string str = "Ahmet";

        bool bl = true;

        DateTime dt = DateTime.Now;

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        string str1 = string.Empty;
        str1 = "Ahmet Faruk";
        string ad = "Ahmet";
        string soyad = "TÜRK";

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 + integer2;

        bool bool1 = 10 < 2;

        Console.WriteLine(bool1);

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();

        Console.WriteLine(yeniDeger);

        int int21 = int20 + Convert.ToInt32(str20);

        Console.WriteLine(int21);
    }
}
