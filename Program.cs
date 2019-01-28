using System;

namespace AMC_SharpIntro
{
    public class Animal
    {
        private string Name { get; set;}
        protected int Age { get; set; }

        public Animal()
        {

        }
        public Animal(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

    }
    public class Cow : Animal
    {

        public Cow() : base()
        {
            var a = this.Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int tmp = 2 / a;
                Console.WriteLine(tmp);
            }
            catch { Console.WriteLine("smth went wrong"); }

        }
    }
}
