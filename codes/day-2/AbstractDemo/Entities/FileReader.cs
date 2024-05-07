namespace Entities
{
    public class FileReader : Reader
    {
        public FileReader() { }
        public FileReader(string path) : base(path) { }

        public sealed override string? ReadData()
        {
            return "file data";
        }
    }
    public class XmlFileReader : FileReader
    {
        //public override string? ReadData()
        //{
        //    return base.ReadData();
        //}
    }
}
