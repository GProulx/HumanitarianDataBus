﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetHumanitarianEventRequest", Namespace="http://schemas.datacontract.org/2004/07/Humanitarian.DataContracts.Requests")]
    [System.SerializableAttribute()]
    public partial class GetHumanitarianEventRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetHumanitarianEventResponse", Namespace="http://schemas.datacontract.org/2004/07/Humanitarian.DataContracts.Responses")]
    [System.SerializableAttribute()]
    public partial class GetHumanitarianEventResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.HumanitarianEvent> EventsField;
        
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
        public System.Collections.Generic.List<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.HumanitarianEvent> Events {
            get {
                return this.EventsField;
            }
            set {
                if ((object.ReferenceEquals(this.EventsField, value) != true)) {
                    this.EventsField = value;
                    this.RaisePropertyChanged("Events");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HumanitarianEvent", Namespace="http://schemas.datacontract.org/2004/07/Humanitarian.DataContracts")]
    [System.SerializableAttribute()]
    public partial class HumanitarianEvent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventXmlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyXmlField;
        
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
        public string EventXml {
            get {
                return this.EventXmlField;
            }
            set {
                if ((object.ReferenceEquals(this.EventXmlField, value) != true)) {
                    this.EventXmlField = value;
                    this.RaisePropertyChanged("EventXml");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyXml {
            get {
                return this.PropertyXmlField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyXmlField, value) != true)) {
                    this.PropertyXmlField = value;
                    this.RaisePropertyChanged("PropertyXml");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AddHumanitarianEventRequest", Namespace="http://schemas.datacontract.org/2004/07/Humanitarian.DataContracts.Requests")]
    [System.SerializableAttribute()]
    public partial class AddHumanitarianEventRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.HumanitarianEvent EventToAddField;
        
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
        public Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.HumanitarianEvent EventToAdd {
            get {
                return this.EventToAddField;
            }
            set {
                if ((object.ReferenceEquals(this.EventToAddField, value) != true)) {
                    this.EventToAddField = value;
                    this.RaisePropertyChanged("EventToAdd");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AddHumanitarianEventResponse", Namespace="http://schemas.datacontract.org/2004/07/Humanitarian.DataContracts.Responses")]
    [System.SerializableAttribute()]
    public partial class AddHumanitarianEventResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HumanitarianPublicationServices.IHumanitarianPublicationServices")]
    public interface IHumanitarianPublicationServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHumanitarianPublicationServices/GetHumanitarianEvents", ReplyAction="http://tempuri.org/IHumanitarianPublicationServices/GetHumanitarianEventsResponse" +
            "")]
        Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventResponse GetHumanitarianEvents(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHumanitarianPublicationServices/GetHumanitarianEvents", ReplyAction="http://tempuri.org/IHumanitarianPublicationServices/GetHumanitarianEventsResponse" +
            "")]
        System.Threading.Tasks.Task<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventResponse> GetHumanitarianEventsAsync(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHumanitarianPublicationServices/AddHumanitarianEvent", ReplyAction="http://tempuri.org/IHumanitarianPublicationServices/AddHumanitarianEventResponse")]
        Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventResponse AddHumanitarianEvent(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHumanitarianPublicationServices/AddHumanitarianEvent", ReplyAction="http://tempuri.org/IHumanitarianPublicationServices/AddHumanitarianEventResponse")]
        System.Threading.Tasks.Task<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventResponse> AddHumanitarianEventAsync(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHumanitarianPublicationServicesChannel : Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.IHumanitarianPublicationServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HumanitarianPublicationServicesClient : System.ServiceModel.ClientBase<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.IHumanitarianPublicationServices>, Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.IHumanitarianPublicationServices {
        
        public HumanitarianPublicationServicesClient() {
        }
        
        public HumanitarianPublicationServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HumanitarianPublicationServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HumanitarianPublicationServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HumanitarianPublicationServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventResponse GetHumanitarianEvents(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventRequest request) {
            return base.Channel.GetHumanitarianEvents(request);
        }
        
        public System.Threading.Tasks.Task<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventResponse> GetHumanitarianEventsAsync(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.GetHumanitarianEventRequest request) {
            return base.Channel.GetHumanitarianEventsAsync(request);
        }
        
        public Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventResponse AddHumanitarianEvent(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventRequest request) {
            return base.Channel.AddHumanitarianEvent(request);
        }
        
        public System.Threading.Tasks.Task<Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventResponse> AddHumanitarianEventAsync(Humanitarian.Publication.Integration.Test.HumanitarianPublicationServices.AddHumanitarianEventRequest request) {
            return base.Channel.AddHumanitarianEventAsync(request);
        }
    }
}
