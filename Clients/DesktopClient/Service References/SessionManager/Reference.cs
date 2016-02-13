﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCheap.Clients.DesktopClient.SessionManager {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SessionManager.ISessionManager")]
    public interface ISessionManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionManager/GetSession", ReplyAction="http://tempuri.org/ISessionManager/GetSessionResponse")]
        string GetSession(string login, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionManager/GetSession", ReplyAction="http://tempuri.org/ISessionManager/GetSessionResponse")]
        System.Threading.Tasks.Task<string> GetSessionAsync(string login, string passwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionManager/IsSessionActive", ReplyAction="http://tempuri.org/ISessionManager/IsSessionActiveResponse")]
        bool IsSessionActive(string login, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionManager/IsSessionActive", ReplyAction="http://tempuri.org/ISessionManager/IsSessionActiveResponse")]
        System.Threading.Tasks.Task<bool> IsSessionActiveAsync(string login, string session);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISessionManagerChannel : BookCheap.Clients.DesktopClient.SessionManager.ISessionManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SessionManagerClient : System.ServiceModel.ClientBase<BookCheap.Clients.DesktopClient.SessionManager.ISessionManager>, BookCheap.Clients.DesktopClient.SessionManager.ISessionManager {
        
        public SessionManagerClient() {
        }
        
        public SessionManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SessionManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetSession(string login, string passwd) {
            return base.Channel.GetSession(login, passwd);
        }
        
        public System.Threading.Tasks.Task<string> GetSessionAsync(string login, string passwd) {
            return base.Channel.GetSessionAsync(login, passwd);
        }
        
        public bool IsSessionActive(string login, string session) {
            return base.Channel.IsSessionActive(login, session);
        }
        
        public System.Threading.Tasks.Task<bool> IsSessionActiveAsync(string login, string session) {
            return base.Channel.IsSessionActiveAsync(login, session);
        }
    }
}