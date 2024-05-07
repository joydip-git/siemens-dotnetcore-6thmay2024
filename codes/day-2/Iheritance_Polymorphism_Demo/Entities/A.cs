namespace Entities
{
    public class A
    {
        private int _id;
        public A() { }
        public A(int id)
        {
            _id = id;
        }
        public void SetId(int id)
        {
            this._id = id;
        }
        public int GetId()
        {
            return _id;
        }
    }
    public class B : A
    {
        private string? _name;
        public B() { }
        public B(string? name, int id) : base(id)
        {
            // _id = id;
            _name = name;
        }
    }
    public class C//: A
    {
        //int _id;
        private decimal _data;
    }
}
