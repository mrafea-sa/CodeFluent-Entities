﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.AngularJs.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 03 February 2015 11:18.
    // Build:1.0.61214.0786
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.softfluent.com/samples/angularjs")]
    public partial interface ICustomerService
    {
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Validate", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        string Validate(SoftFluent.Samples.AngularJs.Customer customer, string culture);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Delete", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool Delete(SoftFluent.Samples.AngularJs.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Load", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.Customer Load(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadById", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.Customer LoadById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="Save", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool Save(SoftFluent.Samples.AngularJs.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadByEntityKey", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.Customer LoadByEntityKey(string key);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="DeleteByKey", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        bool DeleteByKey(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="SaveAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        void SaveAll(SoftFluent.Samples.AngularJs.CustomerCollection customerCollection);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="PageLoadAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.CustomerCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(UriTemplate="LoadAll", ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Json, RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped)]
        SoftFluent.Samples.AngularJs.CustomerCollection LoadAll();
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute(RequestFormat=System.ServiceModel.Web.WebMessageFormat.Json, Method="GET")]
        System.IO.Stream JsonGet(CodeFluent.Runtime.Model.ProjectInvokeOptions options);
        
        [System.ServiceModel.OperationContractAttribute()]
        [System.ServiceModel.Web.WebInvokeAttribute()]
        System.IO.Stream JsonPost(System.IO.Stream data);
    }
}
