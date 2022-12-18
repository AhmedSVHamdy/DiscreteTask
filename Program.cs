namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Frist Number:");
            int prime = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Other Number: ");
            int prime1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime Resualt: ");

            int H = 0;
            for (int i = prime; i <= prime1; i++ )
            {
                for (int W = 1; W <= i; W++)

                {
                    if (i % W == 0)
                        H++;
                }
                if (H == 2)
                    Console.WriteLine(i);
                H = 0;

            }







        }
    }
}