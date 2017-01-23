using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio
    {
        public ulong SacarControl(ulong codBarras)
        {
            char[] codBarrasChar = codBarras.ToString().ToCharArray();
            ulong impares = 0;
            ulong pares = 0;

            for (int i = 0; i < codBarrasChar.Length; i++)
            {
                ulong num = (ulong)Char.GetNumericValue(codBarrasChar[i]);

                if (i % 2 == 0)
                {
                    pares += num;
                }
                else
                {
                    impares += num;
                }
            }

            ulong imparesMult = impares * 3;
            ulong suma = imparesMult + pares;

            if (suma % 10 == 0)
            {
                return 0;
            }

            char[] sumaChar = suma.ToString().ToCharArray();
            ulong control = 10 - (ulong)Char.GetNumericValue(sumaChar[sumaChar.Length - 1]);

            return control;
        }

        public bool ComprobarControl(ulong codBarrasConControl)
        {
            ulong codBarras = UInt64.Parse(codBarrasConControl.ToString().Remove(codBarrasConControl.ToString().Length - 1));
            ushort control = UInt16.Parse(codBarrasConControl.ToString().ToCharArray()[codBarrasConControl.ToString().Length - 1].ToString());

            return SacarControl(codBarras) == control;
        }
    
    }

}
