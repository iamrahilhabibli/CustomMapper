using System.Reflection;

namespace ConsoleApp.Helpers;

public class Mapper
{
    //public T Map<T>(object from) where T : class
    //{
    //    T to = (T)Activator.CreateInstance(typeof(T));
    //    PropertyInfo[] fromInfo = from.GetType().GetProperties();
    //    PropertyInfo[] toInfo = typeof(T).GetProperties();

    //    foreach (var fromProp in fromInfo)
    //    {
    //        foreach (var toProp in toInfo)
    //        {
    //            if (fromProp.Name.Equals(toProp.Name))
    //            {
    //                var value = fromProp.GetValue(from);
    //                toProp.SetValue(to,value,null);
    //            }
    //        }
    //    }
    //    return to;
    //}
}
