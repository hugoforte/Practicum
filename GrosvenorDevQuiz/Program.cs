using System;
using Autofac;
using GrosvenorDevQuiz.BusinessObjects;
using GrosvenorDevQuiz.Ioc;

namespace GrosvenorDevQuiz
{
    /// <summary>
    /// TODO: Create entities
    /// TODO:Enable parser to 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var server = container.Resolve<IServer>();
            
            Console.WriteLine("Add your order or q for quit");
            var order = Console.ReadLine();
            while (!order.ToLower().Equals("q"))
            {
                var food = server.TakeOrder(order);
                Console.WriteLine(food);

                Console.WriteLine("");
                Console.WriteLine("Add your order or q for quit");
                order = Console.ReadLine();
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DevQuizModule>();
            return builder.Build();
        }
    }
}