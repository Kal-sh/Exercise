namespace Classes
{
    public class CustomerBase
    {
        public int Id;
        public string Name;

        public CustomerBase()
        {
        }

        public CustomerBase(int id)
        {
            this.Id = id;
        }

        public CustomerBase(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}