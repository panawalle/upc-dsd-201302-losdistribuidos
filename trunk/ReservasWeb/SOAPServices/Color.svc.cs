using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Color" en el código, en svc y en el archivo de configuración a la vez.
    public class Color : IColor
    {
        Negocio.ColorBLL objColorBLL = new Negocio.ColorBLL();

        public Dominio.Color fnObtenerColor(string codColor)
        {
            Dominio.Color objColor = new Dominio.Color();

            objColor  = objColorBLL .fnObtenerColor(codColor);

            return objColor;
        }
    }
}
