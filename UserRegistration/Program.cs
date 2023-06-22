namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registraction!!");

            ValidatePattern obj = new ValidatePattern("abc.xyz@bl.co.in");

            obj.ValidEmail();
                
        }
    }
}