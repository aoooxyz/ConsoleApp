using System;

namespace ConsoleApp
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Books book1;    // 声明 Books 类型的 book1
            Books book2;    // 声明 Books 类型的 book2
            // 定义 book1 的属性
            book1.title = "C#教程";
            book1.author = "C语言中文网";
            book1.subject = "C#编程教程";
            book1.book_id = 123456;
            // 定义 book2 的属性
            book2.title = "HTTP教程";
            book2.author = "C语言中文网";
            book2.subject = "HTTP协议教程";
            book2.book_id = 123455;
            // 输出 book1 的属性信息
            Console.WriteLine("book1 title : {0}", book1.title);
            Console.WriteLine("book1 author : {0}", book1.author);
            Console.WriteLine("book1 subject : {0}", book1.subject);
            Console.WriteLine("book1 book_id :{0}", book1.book_id);
            // 输出 book2 的属性信息
            Console.WriteLine("book2 title : {0}", book2.title);
            Console.WriteLine("book2 author : {0}", book2.author);
            Console.WriteLine("book2 subject : {0}", book2.subject);
            Console.WriteLine("book2 book_id :{0}", book2.book_id);
            Console.ReadKey();
        }
    }
}