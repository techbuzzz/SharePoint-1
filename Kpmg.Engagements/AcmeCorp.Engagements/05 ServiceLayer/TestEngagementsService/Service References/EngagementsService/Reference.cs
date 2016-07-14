﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.19050
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEngagementsService.EngagementsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/AcmeCorp.Engagements.EngagementsService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EngagementsService.IEngagementsService")]
    public interface IEngagementsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/GetData", ReplyAction="http://tempuri.org/IEngagementsService/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IEngagementsService/GetDataUsingDataContractResponse")]
        TestEngagementsService.EngagementsService.CompositeType GetDataUsingDataContract(TestEngagementsService.EngagementsService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/CreateNewEngagementSite", ReplyAction="http://tempuri.org/IEngagementsService/CreateNewEngagementSiteResponse")]
        string CreateNewEngagementSite(long engagementId, int engagementFoldersType, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> engagementProperties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/UpdateEngagementSiteProperties", ReplyAction="http://tempuri.org/IEngagementsService/UpdateEngagementSitePropertiesResponse")]
        string UpdateEngagementSiteProperties(long engagementId, int engagementFoldersType, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> engagementProperties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/GetEngagementStatus", ReplyAction="http://tempuri.org/IEngagementsService/GetEngagementStatusResponse")]
        string GetEngagementStatus(long engagementId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/CloseEngagement", ReplyAction="http://tempuri.org/IEngagementsService/CloseEngagementResponse")]
        string CloseEngagement(long engagementId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/ReopenEngagement", ReplyAction="http://tempuri.org/IEngagementsService/ReopenEngagementResponse")]
        string ReopenEngagement(long engagementId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/CreateNewOpportunitySite", ReplyAction="http://tempuri.org/IEngagementsService/CreateNewOpportunitySiteResponse")]
        string CreateNewOpportunitySite(long opportunityId, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> opportunityProperties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/UpdateOpportunitySiteProperties", ReplyAction="http://tempuri.org/IEngagementsService/UpdateOpportunitySitePropertiesResponse")]
        string UpdateOpportunitySiteProperties(long opportunityId, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> opportunityProperties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEngagementsService/CreateEngagementFromOpportunity", ReplyAction="http://tempuri.org/IEngagementsService/CreateEngagementFromOpportunityResponse")]
        string CreateEngagementFromOpportunity(long opportunityId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEngagementsServiceChannel : TestEngagementsService.EngagementsService.IEngagementsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EngagementsServiceClient : System.ServiceModel.ClientBase<TestEngagementsService.EngagementsService.IEngagementsService>, TestEngagementsService.EngagementsService.IEngagementsService {
        
        public EngagementsServiceClient() {
        }
        
        public EngagementsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EngagementsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EngagementsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EngagementsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public TestEngagementsService.EngagementsService.CompositeType GetDataUsingDataContract(TestEngagementsService.EngagementsService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public string CreateNewEngagementSite(long engagementId, int engagementFoldersType, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> engagementProperties) {
            return base.Channel.CreateNewEngagementSite(engagementId, engagementFoldersType, managers, partners, staff, engagementProperties);
        }
        
        public string UpdateEngagementSiteProperties(long engagementId, int engagementFoldersType, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> engagementProperties) {
            return base.Channel.UpdateEngagementSiteProperties(engagementId, engagementFoldersType, managers, partners, staff, engagementProperties);
        }
        
        public string GetEngagementStatus(long engagementId) {
            return base.Channel.GetEngagementStatus(engagementId);
        }
        
        public string CloseEngagement(long engagementId) {
            return base.Channel.CloseEngagement(engagementId);
        }
        
        public string ReopenEngagement(long engagementId) {
            return base.Channel.ReopenEngagement(engagementId);
        }
        
        public string CreateNewOpportunitySite(long opportunityId, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> opportunityProperties) {
            return base.Channel.CreateNewOpportunitySite(opportunityId, managers, partners, staff, opportunityProperties);
        }
        
        public string UpdateOpportunitySiteProperties(long opportunityId, string[] managers, string[] partners, string[] staff, System.Collections.Generic.Dictionary<string, object> opportunityProperties) {
            return base.Channel.UpdateOpportunitySiteProperties(opportunityId, managers, partners, staff, opportunityProperties);
        }
        
        public string CreateEngagementFromOpportunity(long opportunityId) {
            return base.Channel.CreateEngagementFromOpportunity(opportunityId);
        }
    }
}
