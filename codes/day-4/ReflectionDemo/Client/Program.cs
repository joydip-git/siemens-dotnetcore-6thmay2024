using System.Reflection;

Console.WriteLine("starting with reflection...");

try
{
    //1. load assembly dynamically
    Assembly loadedAssembly = Assembly.LoadFile(@"D:\training\siemens-dotnetcore-6thmay2024\codes\day-4\ReflectionDemo\Entities\bin\Debug\net8.0\Entities.dll");

    Console.WriteLine(loadedAssembly.FullName);

    //2. extract metadata of types declared in loaded assembly
    Type[] allTypes = loadedAssembly.GetTypes();
    string? typeName = null;
    Type? clsType = null;
    foreach (var type in allTypes)
    {
        Console.WriteLine("Name: " + type.FullName);
        Console.WriteLine($"Class?: {type.IsClass}");
        if (type.IsClass)
        {
            typeName = type.FullName;
            clsType = type;
        }
        Console.WriteLine($"Abstract Class?: {type.IsAbstract}");
        Console.WriteLine($"Interface?: {type.IsInterface}");
        Console.WriteLine($"Value Type?: {type.IsValueType}");
        Console.WriteLine($"Enum?: {type.IsEnum}");
    }

    //3. extract metadata about a particular type
    //if (typeName != null && typeName != string.Empty)
    //{
    //    clsType = loadedAssembly.GetType(typeName);
    //}

    //3. create instance of the type dynamically based on its metadata
    if (clsType != null)
    {
        //this following code will use default construtor (parameterless) to create instance of the class
        //var instance = Activator.CreateInstance(clsType);

        //this following code will use parameterized construtor to create instance of the class
        var instance = Activator.CreateInstance(clsType);

        PropertyInfo? nameProp = clsType.GetProperty("Name");
        PropertyInfo? idProp = clsType.GetProperty("Id");
        PropertyInfo? priceProp = clsType.GetProperty("Price");

        nameProp?.SetValue(instance, "Anil");
        idProp?.SetValue(instance, 1);
        priceProp?.SetValue(instance, 10000M);

        Console.WriteLine(nameProp?.GetValue(instance));

        MethodInfo? toStringMethodInfo = clsType.GetMethod("ToString");
        object? returnValue = null;

        if (toStringMethodInfo != null)
        {
            if (toStringMethodInfo.ReturnType != null)
            {
                if (toStringMethodInfo.GetParameters().Length == 0)
                {
                    returnValue = toStringMethodInfo.Invoke(instance, null);
                    Console.WriteLine(returnValue);
                }
                else
                {
                    //toStringMethodInfo.Invoke(instance, new object[] { });
                    returnValue = toStringMethodInfo.Invoke(instance, []);
                    Console.WriteLine(returnValue);
                }
            }

        }


        /*
        ConstructorInfo[] allCtors = clsType.GetConstructors();
        ConstructorInfo? parameterizedCtor = null;
        foreach (var constructor in allCtors)
        {
            ParameterInfo[] allParams = constructor.GetParameters();
            if (allParams.Length > 0)
            {
                parameterizedCtor = constructor;
                break;
            }
        }
        if (parameterizedCtor != null)
        {
            //ParameterInfo[] parameters = parameterizedCtor.GetParameters();
            //foreach (var parameter in parameters)
            //{
            //    Type pType = parameter.ParameterType;
            //}
            var instance = Activator.CreateInstance(clsType, 1, "anil", 1000);
        }
        */

        //FieldInfo[] allDataMembers = clsType.GetFields();
        /*
        if (instance != null)
        {
            PropertyInfo[] allProps = clsType.GetProperties();
            foreach (var property in allProps)
            {
                if (property != null)
                {
                    switch (property.PropertyType.Name)
                    {
                        case "Int32":
                            property.SetValue(instance, 1);
                            break;
                    }
                }
            }
        }
        */
    }
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex);
}
