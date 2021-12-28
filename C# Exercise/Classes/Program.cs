namespace Classes
{
    internal class Program
    {
        public class Person : PersonBase
        {
        }

        public class Customer : CustomerBase
        {
            public Customer(int id, string name) : base(id, name)
            {
            }
        }

        private static void Main(string[] args)
        {
            /*
            //* instance of person class
            Person p = new Person();
            p.name = "kaleab";
            p.introduce("josh");

            */
            var customer = new Customer(1, "kal");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}