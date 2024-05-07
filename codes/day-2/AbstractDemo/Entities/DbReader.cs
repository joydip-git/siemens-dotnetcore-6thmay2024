namespace Entities
{
    public sealed class DbReader : Reader
    {
        public DbReader(string? path) : base(path)
        {
        }
        //virtual
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Hello...");
        }
        //abstract
        public override string? ReadData()
        {
            return "Db Data";
        }
    }
}
