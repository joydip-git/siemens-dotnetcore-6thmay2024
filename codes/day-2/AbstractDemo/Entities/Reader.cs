namespace Entities
{
    public abstract class Reader
    {
        string? path;
       
        public Reader()
        {

        }    
        public Reader(string? path)
        {
            this.path = path;
        }
        public string? Path => path;

        public abstract string? ReadData();
        public virtual void Print() { }
    }
}
