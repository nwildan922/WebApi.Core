
using Jil;
using System.IO;


namespace Helper
{
    public static class JilHelper
    {
        public static string Serialize(object model)
        {
            using (var json = new StringWriter())
            {
                JSON.Serialize(
                   model,
                    json,
                    Options.ISO8601ExcludeNullsJSONPIncludeInheritedUtcCamelCase
                );
                return json.ToString();
            }

        }

    }
}
