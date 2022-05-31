namespace Oops_Concepts_Modules
{
    interface interfaceI2 : interfaceI1
    {
        void Print();
    }

    class Ultra : interfaceI2
    {
        public void Display()
        {
            Console.WriteLine("This is Display Method");
        }

        public void Sum()
        {
            Console.WriteLine("This is PrSumint Method");
        }

        public void Print()
        {
            Console.WriteLine("This is Print Method");
        }

    }
}
