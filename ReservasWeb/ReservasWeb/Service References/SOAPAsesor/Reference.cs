﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasWeb.SOAPAsesor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPAsesor.IAsesor")]
    public interface IAsesor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesor/fnObtenerAsesor", ReplyAction="http://tempuri.org/IAsesor/fnObtenerAsesorResponse")]
        SOAPServices.Dominio.Asesor fnObtenerAsesor(int numCodigoAsesor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAsesorChannel : ReservasWeb.SOAPAsesor.IAsesor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsesorClient : System.ServiceModel.ClientBase<ReservasWeb.SOAPAsesor.IAsesor>, ReservasWeb.SOAPAsesor.IAsesor {
        
        public AsesorClient() {
        }
        
        public AsesorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsesorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsesorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsesorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.Dominio.Asesor fnObtenerAsesor(int numCodigoAsesor) {
            return base.Channel.fnObtenerAsesor(numCodigoAsesor);
        }
    }
}
