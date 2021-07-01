using System;



namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            if(string.IsNullOrEmpty(Lesson8.Settings1.Default.UserName) || string.IsNullOrEmpty(Lesson8.Settings1.Default.Age) || string.IsNullOrEmpty(Lesson8.Settings1.Default.Work))
            {
                Console.WriteLine(Lesson8.Settings1.Default.Greeting);
                Console.Write("Ваше имя: ");
                Lesson8.Settings1.Default.UserName = Console.ReadLine();
                Console.Write("Сколько Вам лет: ");
                Lesson8.Settings1.Default.Age = Console.ReadLine();
                Console.Write("Ваш род деятельности: ");
                Lesson8.Settings1.Default.Work = Console.ReadLine();
                Lesson8.Settings1.Default.Save();               
            }
            else
            {
                Console.WriteLine($"Здравствуйте {Lesson8.Settings1.Default.UserName}, Вам {Lesson8.Settings1.Default.Age} лет и Вы работает в сфере {Lesson8.Settings1.Default.Work}");
            }
            

        }
    }
}
