using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMarca" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMarca
    {
        [OperationContract]
        Dominio.Marca fnObtenerMarca(int codMarca);
    }
}
