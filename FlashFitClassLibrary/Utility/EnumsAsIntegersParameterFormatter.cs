using FlashFitClassLibrary.Enumz;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Utility;

public class EnumsAsIntegersParameterFormatter : IUrlParameterFormatter
{
    public string? Format(object parameterValue, ParameterInfo parameterInfo)
    {
        if (parameterValue == null)
            return null;

        var parameterType = Denullify(parameterInfo.ParameterType);

        // Option 1) Format only Foo
        if (parameterType == typeof(GenderTypeEnum))
            return ((int)parameterValue).ToString();

        // or Option 2) Format all enums
        if (parameterType.IsEnum)
            return ((int)parameterValue).ToString();

        return parameterValue.ToString();
    }

    // Just makes sure you have the generic type arg for Nullable<T>
    static Type Denullify(Type type)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            return type.GetGenericArguments()[0];

        return type;
    }

    public string? Format(object? value, ICustomAttributeProvider attributeProvider, Type type)
    {
        throw new NotImplementedException();
    }


    // Use it like this
    //var settings = new RefitSettings
    //{
    //    UrlParameterFormatter = new EnumsAsIntegersParameterFormatter()
    //};
    //var api = RestService.For<IApi>("http://someapi.com", settings);
}
