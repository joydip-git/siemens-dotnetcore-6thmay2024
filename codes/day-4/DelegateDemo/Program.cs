using System.Reflection;

namespace DelegateDemo
{
    //1. delegate declaration
    //delegate void CalDel(int a, int b);
    delegate void CalDel<in T>(T a, T b);
    delegate void CalDel<in T1, in T2>(T1 a, T2 b);

    /*
    class CalDel : MulticastDelegate //:Delegate:object
    {
        private MethodInfo _method;
        private object _target;

        public CalDel(MethodInfo method, object target)
        {
            _method = method;
            _target = target;
        }
        public void Invoke(int a, int b)
        {
            if (_target != null)
                _method.Invoke(_target, [a, b]);
            else
                _method.Invoke(null, [a, b]);
        }
    }
    */
    class Program
    {
        static void Main()
        {
            //ThreadStart runDel = new ThreadStart(Run);
            //Thread thread = new Thread(runDel);
            Calculation calculation = new Calculation();

            //2. instantiate a delegate
            CalDel<int> cdAdd = new CalDel<int>(calculation.Add);
            //group method conversion
            CalDel<int> cdSub = Calculation.Subtract;

            //3. invoking method using delegate instance
            cdAdd.Invoke(12, 13);
            cdSub(12, 3);

            //anonymous delegate (a delegate referring to an anonymous method (method without a name))

            CalDel<int, long> cdMulti = delegate (int x, long y)
            {
                Console.WriteLine(x * y);
            };
            cdMulti(12, 3);

            //Lambda expression (a new way of writing anonymous method
            //expression body syntax
            //type inference
            CalDel<double, double> cdDiv = (x, y) => Console.WriteLine(x / y);
            cdDiv.Invoke(12, 4);

            Button btn = new Button { Text = "Click Me!!!" };
            //ControlEventHandler ev = ButtonClicked;
            //btn.Click += ev;
            //btn.Click += ButtonClicked;
            btn.Click += (sender) => Console.WriteLine(sender.GetType().Name);

            btn.OnClick();
        }
        static void ButtonClicked(object sender)
        {
            Console.WriteLine(sender.GetType().Name);
            if (sender.GetType() == typeof(Button))
            {
                Button btn = (Button)sender;
                Console.WriteLine(btn.Text);
            }
        }
    }
    class Calculation
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
    delegate void ControlEventHandler(object sender);
    class Button
    {
        public string? Text { get; set; }
        public event ControlEventHandler? Click;
        public void OnClick()
        {
            Click?.Invoke(this);
        }
    }
}
