﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TennisOrganizer4Web.AccountService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateAccount", ReplyAction="http://tempuri.org/IAccountService/CreateAccountResponse")]
        TennisOrganizerServices.Account CreateAccount(TennisOrganizerServices.Player p, string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CreateAccount", ReplyAction="http://tempuri.org/IAccountService/CreateAccountResponse")]
        System.Threading.Tasks.Task<TennisOrganizerServices.Account> CreateAccountAsync(TennisOrganizerServices.Player p, string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccount", ReplyAction="http://tempuri.org/IAccountService/GetAccountResponse")]
        TennisOrganizerServices.Account GetAccount(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccount", ReplyAction="http://tempuri.org/IAccountService/GetAccountResponse")]
        System.Threading.Tasks.Task<TennisOrganizerServices.Account> GetAccountAsync(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountByLogin", ReplyAction="http://tempuri.org/IAccountService/GetAccountByLoginResponse")]
        TennisOrganizerServices.Account GetAccountByLogin(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetAccountByLogin", ReplyAction="http://tempuri.org/IAccountService/GetAccountByLoginResponse")]
        System.Threading.Tasks.Task<TennisOrganizerServices.Account> GetAccountByLoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccountPassword", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountPasswordResponse")]
        bool UpdateAccountPassword(string login, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateAccountPassword", ReplyAction="http://tempuri.org/IAccountService/UpdateAccountPasswordResponse")]
        System.Threading.Tasks.Task<bool> UpdateAccountPasswordAsync(string login, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CheckAvailability", ReplyAction="http://tempuri.org/IAccountService/CheckAvailabilityResponse")]
        bool CheckAvailability(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/CheckAvailability", ReplyAction="http://tempuri.org/IAccountService/CheckAvailabilityResponse")]
        System.Threading.Tasks.Task<bool> CheckAvailabilityAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : TennisOrganizer4Web.AccountService.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<TennisOrganizer4Web.AccountService.IAccountService>, TennisOrganizer4Web.AccountService.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TennisOrganizerServices.Account CreateAccount(TennisOrganizerServices.Player p, string login, string password) {
            return base.Channel.CreateAccount(p, login, password);
        }
        
        public System.Threading.Tasks.Task<TennisOrganizerServices.Account> CreateAccountAsync(TennisOrganizerServices.Player p, string login, string password) {
            return base.Channel.CreateAccountAsync(p, login, password);
        }
        
        public TennisOrganizerServices.Account GetAccount(int id, string password) {
            return base.Channel.GetAccount(id, password);
        }
        
        public System.Threading.Tasks.Task<TennisOrganizerServices.Account> GetAccountAsync(int id, string password) {
            return base.Channel.GetAccountAsync(id, password);
        }
        
        public TennisOrganizerServices.Account GetAccountByLogin(string login, string password) {
            return base.Channel.GetAccountByLogin(login, password);
        }
        
        public System.Threading.Tasks.Task<TennisOrganizerServices.Account> GetAccountByLoginAsync(string login, string password) {
            return base.Channel.GetAccountByLoginAsync(login, password);
        }
        
        public bool UpdateAccountPassword(string login, string oldPassword, string newPassword) {
            return base.Channel.UpdateAccountPassword(login, oldPassword, newPassword);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAccountPasswordAsync(string login, string oldPassword, string newPassword) {
            return base.Channel.UpdateAccountPasswordAsync(login, oldPassword, newPassword);
        }
        
        public bool CheckAvailability(string login) {
            return base.Channel.CheckAvailability(login);
        }
        
        public System.Threading.Tasks.Task<bool> CheckAvailabilityAsync(string login) {
            return base.Channel.CheckAvailabilityAsync(login);
        }
    }
}
