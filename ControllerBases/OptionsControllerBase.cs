using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace WEB_1005_Fall_2023_WebAPI.ControllerBases;

public class OptionsControllerBase : ControllerBase
{
    [HttpOptions]
    public string OptionsControllerBaseOptions()
    {
        List<String> methods = new List<string>();

        MethodInfo[] methodArray = this.GetType().GetMethods();

        foreach(MethodInfo method in methodArray)
        {
            var attrs = System.Attribute.GetCustomAttributes(method);

            foreach (var attr in attrs)
            {
                if (attr is HttpMethodAttribute)
                {
                    Type t = attr.GetType();
                    string tName = t.Name.Replace("Http", "").Replace("Attribute", "").ToUpper();
                    
                    if (!methods.Any(m => m == tName))
                    {
                        methods.Add(tName);
                    }
                    
                }
            }
        }

        Response.Headers.Allow = methods.ToArray(); 

        return String.Join(',', methods.AsEnumerable());
    }

}