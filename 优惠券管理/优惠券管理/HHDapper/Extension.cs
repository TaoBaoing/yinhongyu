using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HH.Dapper
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

        public static bool EHasNotMappedAttribute(this PropertyInfo property)
        {
            try
            {
                object obj = property.GetCustomAttributes(typeof(NotMappedAttribute), true)[0];
                return obj is NotMappedAttribute;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
