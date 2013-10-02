using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Modelo" en el código, en svc y en el archivo de configuración a la vez.
    public class Modelo : IModelo
    {

        Negocio.ModeloBLL objModeloBLL = new Negocio.ModeloBLL();

        public Dominio.Modelo fnObtenerModelo(string codModelo)
        {
            Dominio.Modelo objModelo = new Dominio.Modelo();

            objModelo = objModeloBLL.fnObtenerModelo(codModelo);

            return objModelo;

        }

    }
}
