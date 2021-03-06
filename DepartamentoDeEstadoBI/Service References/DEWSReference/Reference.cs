﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepartamentoDeEstadoBI.DEWSReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DEWSReference.DeptEstadoDataSoap")]
    public interface DeptEstadoDataSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpClassesByYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpClassesByYear(int filterYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpClassesByYearSeries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpClassesByYearSeries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpJurisdictionsByYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpJurisdictionsByYear(int filterYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpOrganizationTypesByYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpOrganizationTypesByYear(int filterYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpOrganizationTypesByYearSeries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpOrganizationTypesByYearSeries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCorpTypesByYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetCorpTypesByYear(int filterYear);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DeptEstadoDataSoapChannel : DepartamentoDeEstadoBI.DEWSReference.DeptEstadoDataSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeptEstadoDataSoapClient : System.ServiceModel.ClientBase<DepartamentoDeEstadoBI.DEWSReference.DeptEstadoDataSoap>, DepartamentoDeEstadoBI.DEWSReference.DeptEstadoDataSoap {
        
        public DeptEstadoDataSoapClient() {
        }
        
        public DeptEstadoDataSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeptEstadoDataSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeptEstadoDataSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeptEstadoDataSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetCorpClassesByYear(int filterYear) {
            return base.Channel.GetCorpClassesByYear(filterYear);
        }
        
        public System.Data.DataTable GetCorpClassesByYearSeries() {
            return base.Channel.GetCorpClassesByYearSeries();
        }
        
        public System.Data.DataTable GetCorpJurisdictionsByYear(int filterYear) {
            return base.Channel.GetCorpJurisdictionsByYear(filterYear);
        }
        
        public System.Data.DataTable GetCorpOrganizationTypesByYear(int filterYear) {
            return base.Channel.GetCorpOrganizationTypesByYear(filterYear);
        }
        
        public System.Data.DataTable GetCorpOrganizationTypesByYearSeries() {
            return base.Channel.GetCorpOrganizationTypesByYearSeries();
        }
        
        public System.Data.DataTable GetCorpTypesByYear(int filterYear) {
            return base.Channel.GetCorpTypesByYear(filterYear);
        }
    }
}
