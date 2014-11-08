using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDynamicForm.Utils
{
    public static class EnumHelper
    {
        public static IList<T> GetEnumList<T>()
        {
            var array = (T[])Enum.GetValues(typeof(T));
            return new List<T>(array);
        }
    }
}