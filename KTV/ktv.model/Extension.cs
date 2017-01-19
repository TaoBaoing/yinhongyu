using System;
using System.Reflection;

namespace ktv.model
{
    public static class Extension
    {
        public static string EGetColumnTypeName(this PropertyInfo property)
        {
            if (property.PropertyType.Name.Contains("Nullable"))
            {
                //可空类型
                string fullname = property.PropertyType.FullName;
                if (fullname != null)
                {
                    fullname = fullname.Substring(16);
                    int first = fullname.LastIndexOf("System.") + 7;
                    int last = fullname.IndexOf(", ");
                    string netTypeName = fullname.Substring(first, (last - first));

                    return netTypeName;
                }
            }
            else
            {
                return property.PropertyType.Name;
            }
            return string.Empty;
        }
    }
}
