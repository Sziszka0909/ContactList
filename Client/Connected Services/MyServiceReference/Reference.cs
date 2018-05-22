﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Message", ReplyAction="http://tempuri.org/IMyService/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Message", ReplyAction="http://tempuri.org/IMyService/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Login", ReplyAction="http://tempuri.org/IMyService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Login", ReplyAction="http://tempuri.org/IMyService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Logout", ReplyAction="http://tempuri.org/IMyService/LogoutResponse")]
        void Logout(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Logout", ReplyAction="http://tempuri.org/IMyService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/initUsers", ReplyAction="http://tempuri.org/IMyService/initUsersResponse")]
        void initUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/initUsers", ReplyAction="http://tempuri.org/IMyService/initUsersResponse")]
        System.Threading.Tasks.Task initUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/addContact", ReplyAction="http://tempuri.org/IMyService/addContactResponse")]
        string addContact(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/addContact", ReplyAction="http://tempuri.org/IMyService/addContactResponse")]
        System.Threading.Tasks.Task<string> addContactAsync(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/deleteContact", ReplyAction="http://tempuri.org/IMyService/deleteContactResponse")]
        string deleteContact(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/deleteContact", ReplyAction="http://tempuri.org/IMyService/deleteContactResponse")]
        System.Threading.Tasks.Task<string> deleteContactAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/showContact", ReplyAction="http://tempuri.org/IMyService/showContactResponse")]
        System.Collections.Generic.Dictionary<string, string> showContact();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/showContact", ReplyAction="http://tempuri.org/IMyService/showContactResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> showContactAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : Client.MyServiceReference.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<Client.MyServiceReference.IMyService>, Client.MyServiceReference.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public void Logout(string username) {
            base.Channel.Logout(username);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string username) {
            return base.Channel.LogoutAsync(username);
        }
        
        public void initUsers() {
            base.Channel.initUsers();
        }
        
        public System.Threading.Tasks.Task initUsersAsync() {
            return base.Channel.initUsersAsync();
        }
        
        public string addContact(string username, string phonenumber) {
            return base.Channel.addContact(username, phonenumber);
        }
        
        public System.Threading.Tasks.Task<string> addContactAsync(string username, string phonenumber) {
            return base.Channel.addContactAsync(username, phonenumber);
        }
        
        public string deleteContact(string username) {
            return base.Channel.deleteContact(username);
        }
        
        public System.Threading.Tasks.Task<string> deleteContactAsync(string username) {
            return base.Channel.deleteContactAsync(username);
        }
        
        public System.Collections.Generic.Dictionary<string, string> showContact() {
            return base.Channel.showContact();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> showContactAsync() {
            return base.Channel.showContactAsync();
        }
    }
}
