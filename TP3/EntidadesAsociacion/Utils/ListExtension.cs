using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Utils
{
    public static class ListExtension
    {
        public static string Mostar<T>(this List<T> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach(T item in lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
