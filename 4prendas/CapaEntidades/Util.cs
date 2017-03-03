using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Util
    {

        public static DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }


        public static ulong SacarControl(ulong codBarras)
        {
            //Supongamos que estamos utilizando el código ficticio de 05432122345.
            //Sumar todos los dígitos en las posiciones impares(dígitos en la posición 1, 3, 5, 7, 9 y 11)
            //0 + 4 + 2 + 2 + 3 + 5 = 16
            //Multiplicar por 3.
            //16 * 3 = 48
            //Sumar todos los dígitos en las posiciones pares (dígitos en la posición 2, 4, 6, 8 y 10).
            //5 + 3 + 1 + 2 + 4 = 15
            //Sumar los resultados de los pasos 3 y 2.
            //48 + 15 = 63
            //Determinar qué número hay que añadir al resultado de la etapa 4 para crear un múltiplo de 10.
            //63 + 7 = 70
            //Por lo tanto, el dígito de control es 7.

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

        public static bool ComprobarControl(ulong codBarrasConControl)
        {
            ulong codBarras = UInt64.Parse(codBarrasConControl.ToString().Remove(codBarrasConControl.ToString().Length - 1));
            ushort control = UInt16.Parse(codBarrasConControl.ToString().ToCharArray()[codBarrasConControl.ToString().Length - 1].ToString());

            return SacarControl(codBarras) == control;
        }

        public static Bitmap CropImage(Image originalImage, Rectangle sourceRectangle,
     Rectangle? destinationRectangle = null)
        {
            if (destinationRectangle == null)
            {
                destinationRectangle = new Rectangle(Point.Empty, sourceRectangle.Size);
            }

            var croppedImage = new Bitmap(destinationRectangle.Value.Width,
                destinationRectangle.Value.Height);
            using (var graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(originalImage, destinationRectangle.Value,
                    sourceRectangle, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }

    }
}
