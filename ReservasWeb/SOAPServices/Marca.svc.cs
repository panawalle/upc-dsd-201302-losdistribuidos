using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Marca" en el código, en svc y en el archivo de configuración a la vez.
    public class Marca : IMarca
    {
        Negocio.MarcaBLL objMarcaBLL = new Negocio.MarcaBLL();

        public Dominio.Marca fnObtenerMarca(int codMarca)
        {
            Dominio.Marca objMarca = new Dominio.Marca ();

            objMarca = objMarcaBLL.fnObtenerMarca(codMarca);

            return objMarca ;
        }
    }
}
