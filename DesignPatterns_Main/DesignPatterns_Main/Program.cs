using System;
using FactoryMethod;

namespace DesignPatterns_Main
{
    public class Program
    {
        #region Properties_Definition

        private static string[] _options = { "Salir","Factory Method","Abstract Factory","Singleton","Adapter",
                                            "Composite","Proxy","Facade"};

        private static Action[] functions = { () => factoryMethod(),() => abstractFactory(), () => Singleton() ,()=> Adapter(),
                                            ()=> Composite(),()=>Proxy(),()=>Facade()};


        private const int DOTS_EDGE = 7;
        #endregion
        
        static void Main(string[] args)
        {
            ShowMenu();
            var optionSelected = readOption();
            while (optionSelected > 0)
            {
                switch (optionSelected)
                {
                    case 1:
                        functions[0].Invoke();
                        break;
                    case 2:
                        functions[1].Invoke();
                        break;
                    case 3:
                        functions[2].Invoke();
                        break;
                    case 4:
                        functions[3].Invoke();
                        break;
                    case 5:
                        functions[4].Invoke();
                        break;
                    case 6:
                        functions[5].Invoke();
                        break;
                    case 7:
                        functions[6].Invoke();
                        break;
                    case 8:
                        functions[7].Invoke();
                        break;
                    case 9:
                        functions[8].Invoke();
                        break;
                    case 10:
                        functions[9].Invoke();
                        break;
                    case 11:
                        functions[10].Invoke();
                        break;
                    default:
                        break;
                }
                ShowMenu();
                optionSelected = readOption();
            }
        }

        #region Calls_to_Design_Patterns

        public static void factoryMethod()
        {
            var factoryMethod = new FactoryMethod.FactoryMethodMain();
            factoryMethod.Run();
            Console.ReadLine();
        }
                
        public static void abstractFactory()
        {
            var abstractFactory = new AbstractFactory.AbstractFactoryMain();
            abstractFactory.Run();
            Console.ReadLine();
        }

        public static void Singleton()
        {
            var singleton = new Singleton.SingletonMain();
            singleton.Run();
            Console.ReadLine();
        }

        public static void Adapter()
        {
            var adapter = new Adapter.AdapterMain();
            adapter.Run();
            Console.ReadLine();
        }

        public static void Composite()
        {
            var composite = new Composite.CompositeMain();
            composite.Run();
            Console.ReadLine();
        }

        public static void Proxy()
        {
            var proxy = new Proxy.ProxyMain();
            proxy.Run();
            Console.ReadLine();
        }

        public static void Facade()
        {
            var facade = new Facade.FacadeMain();
            facade.Run();
            Console.ReadLine();
        }
        #endregion



        #region Menu_functions
        public static void ShowMenu()
        {
            Console.Clear();
            var index = 0;
            foreach (var option in _options)
            {
                if (index < 1)
                    Console.WriteLine($"::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                //else
                //{
                    for (int i = 0; i < DOTS_EDGE; i++)
                    {
                        Console.Write($" ");
                    }
                    Console.Write($"{index} .- {option}");
                    for (int i = 0; i < DOTS_EDGE; i++)
                    {
                        Console.Write($" ");
                    }
                    Console.Write(System.Environment.NewLine);
                //}
                index++;
            }
            Console.WriteLine($"::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }

        public static int readOption()
        {
            Console.Write($"Escribe el numero de tu opcion:: ");
            string input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
                return Int32.Parse(input);
            }
            else
                return 0;
        }
        #endregion
    }
}
