using System;

namespace Lesson1{
    class Program{
        static void Main(string[] args){
            const string myChannel = "MyChannel";
            // myChannel = "OtherChannel"; //it doesnt work because is a constant
            var varVariable = 9;
            const double pi = 3.1415;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("MyChannel: "+myChannel);
            Console.WriteLine("varVariable: "+varVariable);
            Console.WriteLine("pi: "+pi);
            if (args.GetLength(0) > 0) {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}