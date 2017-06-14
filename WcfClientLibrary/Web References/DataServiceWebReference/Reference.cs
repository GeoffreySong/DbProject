﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WcfClientLibrary.DataServiceWebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IDataService", Namespace="http://tempuri.org/")]
    public partial class DataService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ProcessDataChangeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DataService() {
            this.Url = global::WcfClientLibrary.Properties.Settings.Default.WcfClientLibrary_DataServiceWebReference_DataService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ProcessDataChangeCompletedEventHandler ProcessDataChangeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IDataService/ProcessDataChange", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ProcessDataChange([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DataChangeMessage message) {
            this.Invoke("ProcessDataChange", new object[] {
                        message});
        }
        
        /// <remarks/>
        public void ProcessDataChangeAsync(DataChangeMessage message) {
            this.ProcessDataChangeAsync(message, null);
        }
        
        /// <remarks/>
        public void ProcessDataChangeAsync(DataChangeMessage message, object userState) {
            if ((this.ProcessDataChangeOperationCompleted == null)) {
                this.ProcessDataChangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessDataChangeOperationCompleted);
            }
            this.InvokeAsync("ProcessDataChange", new object[] {
                        message}, this.ProcessDataChangeOperationCompleted, userState);
        }
        
        private void OnProcessDataChangeOperationCompleted(object arg) {
            if ((this.ProcessDataChangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessDataChangeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServer")]
    public partial class DataChangeMessage {
        
        private int rowIdField;
        
        private bool rowIdFieldSpecified;
        
        private int tableIdField;
        
        private bool tableIdFieldSpecified;
        
        /// <remarks/>
        public int RowId {
            get {
                return this.rowIdField;
            }
            set {
                this.rowIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowIdSpecified {
            get {
                return this.rowIdFieldSpecified;
            }
            set {
                this.rowIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int TableId {
            get {
                return this.tableIdField;
            }
            set {
                this.tableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TableIdSpecified {
            get {
                return this.tableIdFieldSpecified;
            }
            set {
                this.tableIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ProcessDataChangeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591