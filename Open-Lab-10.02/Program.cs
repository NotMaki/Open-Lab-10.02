using System;

namespace Open_Lab_10._01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book("the Lord of the Rings", 9250);
            Console.WriteLine(LOTR.title);
            //  LOTR.pages is private
        }
    }
}