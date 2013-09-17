using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.SOAPServiceTest;

namespace TestProject {
  [TestClass]
  public class TestClient {

    [TestMethod]
    public void Crear() {

      SOAPServiceTest.ClienteServiceClient proxy = new SOAPServiceTest.ClienteServiceClient();

      // 2. Invocar el metodo de prueba
      Cliente resultado = proxy.RegistrarCliente(1, "44513800", 1, "Lesly", "Ormeño", "Varillas", "lesly.varillas@gmail.com", "Av. Los Pinos 666", "3428320", "96574-6210");
      
      // 3.  Validar el/los resultados
      Assert.IsNotNull(resultado);
    }

    [TestMethod]
    public void Modificar() {

      SOAPServiceTest.ClienteServiceClient proxy = new SOAPServiceTest.ClienteServiceClient();

      // 2. Invocar el metodo de prueba
      Cliente resultado = proxy.ModificarCliente(1, "44513800", 1, "Leslys", "Ormeño", "Varillas", "lesly.varillas@gmail.com", "Av. Los Pinos 666", "3428320", "96574-6210");

      // 3.  Validar el/los resultados
      Assert.IsNotNull(resultado);
    }

    [TestMethod]
    public void Obtener() {

      SOAPServiceTest.ClienteServiceClient proxy = new SOAPServiceTest.ClienteServiceClient();

      // 2. Invocar el metodo de prueba
      Cliente resultado = proxy.ObtenerCliente(1);

      // 3.  Validar el/los resultados
      Assert.IsNotNull(resultado);
    }

    [TestMethod]
    public void Eliminar() {

      SOAPServiceTest.ClienteServiceClient proxy = new SOAPServiceTest.ClienteServiceClient();

      // 2. Invocar el metodo de prueba
      proxy.Eliminar(1);

      // 3.  Validar el/los resultados
      //Assert.();
    }

    [TestMethod]
    public void Listar() {

      SOAPServiceTest.ClienteServiceClient proxy = new SOAPServiceTest.ClienteServiceClient();

      // 2. Invocar el metodo de prueba
      List<Cliente> resultado = proxy.ListarCliente().ToList();

      //3.  Validar el/los resultados
      Assert.IsNotNull(resultado);
    }

  }
}
