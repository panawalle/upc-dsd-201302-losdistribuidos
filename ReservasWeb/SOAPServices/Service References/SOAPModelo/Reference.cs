﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServices.SOAPModelo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Modelo", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Modelo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codMarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codMarca {
            get {
                return this.codMarcaField;
            }
            set {
                if ((this.codMarcaField.Equals(value) != true)) {
                    this.codMarcaField = value;
                    this.RaisePropertyChanged("codMarca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codModelo {
            get {
                return this.codModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.codModeloField, value) != true)) {
                    this.codModeloField = value;
                    this.RaisePropertyChanged("codModelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoField, value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPModelo.IModelo")]
    public interface IModelo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelo/fnObtenerModelo", ReplyAction="http://tempuri.org/IModelo/fnObtenerModeloResponse")]
        SOAPServices.SOAPModelo.Modelo fnObtenerModelo(string codModelo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModeloChannel : SOAPServices.SOAPModelo.IModelo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModeloClient : System.ServiceModel.ClientBase<SOAPServices.SOAPModelo.IModelo>, SOAPServices.SOAPModelo.IModelo {
        
        public ModeloClient() {
        }
        
        public ModeloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ModeloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModeloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModeloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.SOAPModelo.Modelo fnObtenerModelo(string codModelo) {
            return base.Channel.fnObtenerModelo(codModelo);
        }
    }
}
