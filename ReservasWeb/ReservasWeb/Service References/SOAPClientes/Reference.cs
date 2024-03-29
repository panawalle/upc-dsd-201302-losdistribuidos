﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18052
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasWeb.SOAPClientes {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPClientes.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/RegistrarCliente", ReplyAction="http://tempuri.org/IClienteService/RegistrarClienteResponse")]
        SOAPServices.Dominio.Cliente RegistrarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObtenerCliente", ReplyAction="http://tempuri.org/IClienteService/ObtenerClienteResponse")]
        SOAPServices.Dominio.Cliente ObtenerCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        SOAPServices.Dominio.Cliente ModificarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Eliminar", ReplyAction="http://tempuri.org/IClienteService/EliminarResponse")]
        void Eliminar(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ListarCliente", ReplyAction="http://tempuri.org/IClienteService/ListarClienteResponse")]
        SOAPServices.Dominio.Cliente[] ListarCliente();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : ReservasWeb.SOAPClientes.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<ReservasWeb.SOAPClientes.IClienteService>, ReservasWeb.SOAPClientes.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.Dominio.Cliente RegistrarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular) {
            return base.Channel.RegistrarCliente(codigo, dni, tipo, nombre, apellidopaterno, apellidomaterno, correo, direccion, telefono, celular);
        }
        
        public SOAPServices.Dominio.Cliente ObtenerCliente(int codigo) {
            return base.Channel.ObtenerCliente(codigo);
        }
        
        public SOAPServices.Dominio.Cliente ModificarCliente(int codigo, string dni, int tipo, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, string telefono, string celular) {
            return base.Channel.ModificarCliente(codigo, dni, tipo, nombre, apellidopaterno, apellidomaterno, correo, direccion, telefono, celular);
        }
        
        public void Eliminar(int codigo) {
            base.Channel.Eliminar(codigo);
        }
        
        public SOAPServices.Dominio.Cliente[] ListarCliente() {
            return base.Channel.ListarCliente();
        }
    }
}
