namespace Classes
{
    public class PersonBase
    {
        public string name;

        public void introduce(string to)
        {
            System.Console.WriteLine("hi {0}, I'm {1}", to, name);
        }
    }
}