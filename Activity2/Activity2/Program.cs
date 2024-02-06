using System.Buffers;


namespace Activity2
{
    public class Cat
    {
        public string Breed { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }





    }

    class Program
    {
        static void Main(string[] args)
        {


            List<Cat> list = new List<Cat>();

            while (true)
            {
                Console.WriteLine("Do you want to add more Data? [Y/N]");

                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Cat cat1 = new Cat();

                Console.WriteLine("Enter the cat name : ");
                cat1.Name = Console.ReadLine();
                Console.WriteLine("Enter the cat breed : ");
                cat1.Breed = Console.ReadLine();
                Console.WriteLine("Enter the cat age : ");
                cat1.Age = int.Parse(Console.ReadLine());


                list.Add(cat1);

            }
            list.ForEach(x =>
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("CAT DATA : ");
                Console.Write("NAME:");
                Console.WriteLine(x.Name);
                Console.Write("BREED:");
                Console.WriteLine(x.Breed);
                Console.Write("AGE:");
                Console.WriteLine(x.Age);
                Console.WriteLine("-------------------------------");



            });







            /*  }
                Cat cat = new Cat();

                 cat.Name = "Test";
                 cat.Age = 1;
                 cat.Breed = "Siamese";


                 list.ForEach(x => cat++);

                 Console.WriteLine(x);
             }
            */


        }
    }
    }


