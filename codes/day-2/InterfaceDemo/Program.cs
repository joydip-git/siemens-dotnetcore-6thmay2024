Console.WriteLine("Hello, World!");
//implicit interface member invocation
DbReader dbReader = new DbReader();
Console.WriteLine(dbReader.Setting);
dbReader.ReadData();

//explicit interface member invocation (by upcasting)
IReader reader = dbReader;
reader.ReadData();

Console.WriteLine((dbReader as IReaderSetting).Setting);

interface IReader
{
    string? ReadData();
}
interface IReaderSetting
{
    string? Setting { set; get; }
}
class DbReader : IReader, IReaderSetting
{
    private string? _setting;
    public string? Setting
    {
        get => _setting;
        set => _setting = value;
    }

    public string? ReadData()
    {
        return "db data";
    }
}


