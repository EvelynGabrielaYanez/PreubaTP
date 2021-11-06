using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Interfaces
{
    public interface ICsv
    {
        string ToStringSeparadoPorComa();
        //static T ConvertirDeStringSeparadoPorComa<T>(string cadenaSeparadaPorComa) where T : new();
    }
}
