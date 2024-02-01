using System.Buffers;


namespace ArithmeticActivity
{

    public class Operations
    {
        public void Add(int input1, int input2)
        {
            Console.WriteLine("The Sum is : " + (input1 + input2));
        }

        public void Sub(int input1, int input2)
        {
            Console.WriteLine("The Difference is : " + (input1 - input2));
        }

        public void Div(int input1, int input2)
        {
            Console.WriteLine("The Quotient is : " + (input1 / input2));
        }

        public void Mul(int input1, int input2)
        {
            Console.WriteLine("The Product is : " + (input1 * input2));
        }






    }
    class Program
    {
        static void Main(string[] args)
        {
            Operations calc = new Operations();

            int input1, input2;



            Console.WriteLine("Enter number input 1 : ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number input 2 : ");
            input2 = int.Parse(Console.ReadLine());

            calc.Add(input1, input2);
            
            calc.Sub(input1, input2);   
            calc.Mul(input1, input2);
            calc.Div(input1, input2);



        }



    }
}