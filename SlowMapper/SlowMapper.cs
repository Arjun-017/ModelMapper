using System.Linq;
using System.Reflection;

namespace SlowMapper;

public static class SlowMapper
{
    /// <summary>
    /// Maps an object from one type to another
    /// </summary>
    /// <param name="source">The object to be mapped of type TSource</param>
    /// <returns>A new object of type TDestination</returns>
    public static TDestination Map<TSource, TDestination>(TSource source) where TDestination : class, new()
    {
        var sourcePropsDictionary = typeof(TSource).GetProperties().ToDictionary(x => x.Name);
        var destinationProps = typeof(TDestination).GetProperties();

        var destination = new TDestination();

        foreach (PropertyInfo destinationProp in destinationProps)
        {
            if (sourcePropsDictionary.TryGetValue(destinationProp.Name, out var sourceProp))
            {
                if (destinationProp.PropertyType == sourceProp.PropertyType)
                {
                    destinationProp.SetValue(destination, sourceProp.GetValue(source));
                }
            }
        }

        return destination;
    }
}
