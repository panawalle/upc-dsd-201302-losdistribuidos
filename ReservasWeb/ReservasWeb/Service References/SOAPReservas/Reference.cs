﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasWeb.SOAPReservas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reserva", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Reserva : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string horaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nroReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numCodigoAsesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numExpressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string placaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ReservasWeb.SOAPReservas.ReservaDetalle[] reservaDetalleField;
        
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
        public int codReserva {
            get {
                return this.codReservaField;
            }
            set {
                if ((this.codReservaField.Equals(value) != true)) {
                    this.codReservaField = value;
                    this.RaisePropertyChanged("codReserva");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hora {
            get {
                return this.horaField;
            }
            set {
                if ((object.ReferenceEquals(this.horaField, value) != true)) {
                    this.horaField = value;
                    this.RaisePropertyChanged("hora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nroReserva {
            get {
                return this.nroReservaField;
            }
            set {
                if ((object.ReferenceEquals(this.nroReservaField, value) != true)) {
                    this.nroReservaField = value;
                    this.RaisePropertyChanged("nroReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numCodigoAsesor {
            get {
                return this.numCodigoAsesorField;
            }
            set {
                if ((this.numCodigoAsesorField.Equals(value) != true)) {
                    this.numCodigoAsesorField = value;
                    this.RaisePropertyChanged("numCodigoAsesor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numExpress {
            get {
                return this.numExpressField;
            }
            set {
                if ((this.numExpressField.Equals(value) != true)) {
                    this.numExpressField = value;
                    this.RaisePropertyChanged("numExpress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string placa {
            get {
                return this.placaField;
            }
            set {
                if ((object.ReferenceEquals(this.placaField, value) != true)) {
                    this.placaField = value;
                    this.RaisePropertyChanged("placa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReservasWeb.SOAPReservas.ReservaDetalle[] reservaDetalle {
            get {
                return this.reservaDetalleField;
            }
            set {
                if ((object.ReferenceEquals(this.reservaDetalleField, value) != true)) {
                    this.reservaDetalleField = value;
                    this.RaisePropertyChanged("reservaDetalle");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservaDetalle", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class ReservaDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codDetalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codOperField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codOperSerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codReservaField;
        
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
        public int codDetalle {
            get {
                return this.codDetalleField;
            }
            set {
                if ((this.codDetalleField.Equals(value) != true)) {
                    this.codDetalleField = value;
                    this.RaisePropertyChanged("codDetalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codOper {
            get {
                return this.codOperField;
            }
            set {
                if ((object.ReferenceEquals(this.codOperField, value) != true)) {
                    this.codOperField = value;
                    this.RaisePropertyChanged("codOper");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codOperSer {
            get {
                return this.codOperSerField;
            }
            set {
                if ((object.ReferenceEquals(this.codOperSerField, value) != true)) {
                    this.codOperSerField = value;
                    this.RaisePropertyChanged("codOperSer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codReserva {
            get {
                return this.codReservaField;
            }
            set {
                if ((this.codReservaField.Equals(value) != true)) {
                    this.codReservaField = value;
                    this.RaisePropertyChanged("codReserva");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPReservas.IReserva")]
    public interface IReserva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/fnObtenerReserva", ReplyAction="http://tempuri.org/IReserva/fnObtenerReservaResponse")]
        ReservasWeb.SOAPReservas.Reserva fnObtenerReserva(int codReserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/fnGuardarReserva", ReplyAction="http://tempuri.org/IReserva/fnGuardarReservaResponse")]
        ReservasWeb.SOAPReservas.Reserva fnGuardarReserva(ReservasWeb.SOAPReservas.Reserva objReserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/fnListarReserva", ReplyAction="http://tempuri.org/IReserva/fnListarReservaResponse")]
        ReservasWeb.SOAPReservas.Reserva[] fnListarReserva(int codReserva, string nroReserva, string placa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservaChannel : ReservasWeb.SOAPReservas.IReserva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservaClient : System.ServiceModel.ClientBase<ReservasWeb.SOAPReservas.IReserva>, ReservasWeb.SOAPReservas.IReserva {
        
        public ReservaClient() {
        }
        
        public ReservaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ReservasWeb.SOAPReservas.Reserva fnObtenerReserva(int codReserva) {
            return base.Channel.fnObtenerReserva(codReserva);
        }
        
        public ReservasWeb.SOAPReservas.Reserva fnGuardarReserva(ReservasWeb.SOAPReservas.Reserva objReserva) {
            return base.Channel.fnGuardarReserva(objReserva);
        }
        
        public ReservasWeb.SOAPReservas.Reserva[] fnListarReserva(int codReserva, string nroReserva, string placa) {
            return base.Channel.fnListarReserva(codReserva, nroReserva, placa);
        }
    }
}