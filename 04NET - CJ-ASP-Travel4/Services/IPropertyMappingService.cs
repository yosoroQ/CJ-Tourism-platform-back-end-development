using System.Collections.Generic;
using _04NET___CJ_ASP_Travel4.Services;

namespace _04NET___CJ_ASP_Travel4.Services
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
        bool IsMappingExists<TSource, TDestination>(string fields);
        bool IsPropertiesExists<T>(string fields);
    }
}