namespace ConsoleApp  //定义明明空间ConsoleApp
{
    class Demo  //定义Demo类
    {
        static void Main(string[] args)
        {
            Student.id = 1001;
            Student.name = "张三";
            Student.Display();
            Console.Read();
        }
    }
    public class Student
    {
        private Student() { }
        public static int id;
        public static string name;
        public static void Display()
        {
            Console.WriteLine(" 姓名：" + name + " 编号：" + id);
        }
    }
}