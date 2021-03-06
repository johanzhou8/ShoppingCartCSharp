﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/readTable", ReplyAction="http://tempuri.org/IService1/readTableResponse")]
        string[] readTable(string tableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/readTable", ReplyAction="http://tempuri.org/IService1/readTableResponse")]
        System.Threading.Tasks.Task<string[]> readTableAsync(string tableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listPurchases", ReplyAction="http://tempuri.org/IService1/listPurchasesResponse")]
        string[] listPurchases(string cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listPurchases", ReplyAction="http://tempuri.org/IService1/listPurchasesResponse")]
        System.Threading.Tasks.Task<string[]> listPurchasesAsync(string cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/placeOrder", ReplyAction="http://tempuri.org/IService1/placeOrderResponse")]
        void placeOrder(string customerId, string[] productIds, int[] quantities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/placeOrder", ReplyAction="http://tempuri.org/IService1/placeOrderResponse")]
        System.Threading.Tasks.Task placeOrderAsync(string customerId, string[] productIds, int[] quantities);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.IService1>, ConsoleApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] readTable(string tableName) {
            return base.Channel.readTable(tableName);
        }
        
        public System.Threading.Tasks.Task<string[]> readTableAsync(string tableName) {
            return base.Channel.readTableAsync(tableName);
        }
        
        public string[] listPurchases(string cid) {
            return base.Channel.listPurchases(cid);
        }
        
        public System.Threading.Tasks.Task<string[]> listPurchasesAsync(string cid) {
            return base.Channel.listPurchasesAsync(cid);
        }
        
        public void placeOrder(string customerId, string[] productIds, int[] quantities) {
            base.Channel.placeOrder(customerId, productIds, quantities);
        }
        
        public System.Threading.Tasks.Task placeOrderAsync(string customerId, string[] productIds, int[] quantities) {
            return base.Channel.placeOrderAsync(customerId, productIds, quantities);
        }
    }
}
