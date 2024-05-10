using System.Reflection;

namespace PmsIoc
{
    public class ServiceContainer
    {
        private static ServiceContainer? instance;
        private ServiceContainer() { }
        public static ServiceContainer Instantiate()
        {
            if (instance == null)
            {
                instance = new ServiceContainer();
            }
            return instance;
        }
        /*
        public TInterface Register<TInterface, TClass>()
        {
            Type t = typeof(TClass);
            ConstructorInfo[] all = t.GetConstructors();
            if (all[0].GetParameters().Length > 0)
            {

            }
            return (TInterface)Activator.CreateInstance(typeof(TClass), );
        }
        public object Register(Type interfaceType, Type classType)
        {
            //Type t = typeof(TClass);
            ConstructorInfo[] all = classType.GetConstructors();
            if (all[0].GetParameters().Length > 0)
            {

            }
            return (TInterface)Activator.CreateInstance(typeof(TClass), );
        }
        */
    }
}
