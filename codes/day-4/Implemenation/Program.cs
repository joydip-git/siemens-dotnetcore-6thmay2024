static List<T>? Filter<T>(List<T> inputList, LogicDel<T> logicDel)
{
    List<T>? result = null;
    if (inputList != null && inputList.Count > 0)
    {
        //result = new List<T>();
        result = [];
        foreach (var item in inputList)
        {
            if (logicDel(item))
                result.Add(item);
        }
    }
    return result;
}

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//LogicDel<int> evenDel = (num) => num % 2 == 0;
//LogicDel<int> oddDel = (num) => num % 2 != 0;
//var evenNumbers = Filter<int>(numbers, oddDel);
var result = Filter(numbers, (num) => num % 2 == 0);
if (result != null)
{
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}

delegate bool LogicDel<in T>(T num);
//delegate bool Predicate<in T>(T obj);
delegate TResult LogicDel<in T, out TResult>(T num);
//delegate TResult Func<out TResult>();
//delegate TResult Func<in T1, out TResult>(T1 arg1);
//delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
//...
//delegate TResult Func<in T1, in T2,...,in T16, out TResult>(T1 arg1, T2 arg2,...,T16 arg16);