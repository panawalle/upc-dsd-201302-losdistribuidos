using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SOAPServices.Dominio {

  [DataContract]
  public class Cliente {

    [DataMember]
    public int codigocliente { get; set; }

    [DataMember]
    [StringLength(20), Required(ErrorMessage = "Por favor ingrese el Número de Documento (DNI)")]
    public string dnicliente { get; set; }

    [DataMember]
    public int tipo { get; set; }

    [DataMember]
    [StringLength(50), Required]
    public string nombrecliente { get; set; }

    [DataMember]
    [StringLength(50), Required]
    public string apellidopaterno { get; set; }

    [DataMember]
    [StringLength(50), Required]
    public string apellidomaterno { get; set; }

    [DataMember]
    public string direccioncliente { get; set; }

    [DataMember]
    public string telefono { get; set; }

    [DataMember]
    public string celular { get; set; }

    [DataMember]
    [Email, Required]
    public string correo { get; set; }


    //[DataMember]
    //[StringLength(50), Required]
    //public string sexocliente { get; set; }

    //[DataMember]
    //[StringLength(50), Required]
    //public string fechaNacimientoCliente { get; set; }

    //[DataMember]
    //public Distrito distritocliente { get; set; }

    //[DataMember]
    //public Provincia provinciacliente { get; set; }

    //[DataMember]
    //public Departamento departamentocliente { get; set; }

  }
}