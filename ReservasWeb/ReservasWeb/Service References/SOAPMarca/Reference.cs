﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasWeb.SOAPMarca {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPMarca.IMarca")]
    public interface IMarca {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarca/fnObtenerMarca", ReplyAction="http://tempuri.org/IMarca/fnObtenerMarcaResponse")]
        SOAPServices.Dominio.Marca fnObtenerMarca(int codMarca);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarcaChannel : ReservasWeb.SOAPMarca.IMarca, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarcaClient : System.ServiceModel.ClientBase<ReservasWeb.SOAPMarca.IMarca>, ReservasWeb.SOAPMarca.IMarca {
        
        public MarcaClient() {
        }
        
        public MarcaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarcaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.Dominio.Marca fnObtenerMarca(int codMarca) {
            return base.Channel.fnObtenerMarca(codMarca);
        }
    }
}
