//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Superbar.Adapters
{
    
    public class IModuleAssemblyViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IModuleAssemblyContract
    {
        private Superbar.Views.IModuleAssembly _view;
        public IModuleAssemblyViewToContractAddInAdapter(Superbar.Views.IModuleAssembly view)
        {
            _view = view;
        }
        public string Name
        {
            get
            {
                return _view.Name;
            }
        }
        public string Description
        {
            get
            {
                return _view.Description;
            }
        }
        public string Publisher
        {
            get
            {
                return _view.Publisher;
            }
        }
        public System.Version Version
        {
            get
            {
                return _view.Version;
            }
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IModuleInstanceContract> Instances
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Superbar.Views.IModuleInstance, Start9.Api.Contracts.IModuleInstanceContract>(_view.Instances, Superbar.Adapters.IModuleInstanceAddInAdapter.ViewToContractAdapter, Superbar.Adapters.IModuleInstanceAddInAdapter.ContractToViewAdapter);
            }
        }
        public Start9.Api.Contracts.IConfigurationContract SavedConfiguration
        {
            get
            {
                return Superbar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.SavedConfiguration);
            }
        }
        public Start9.Api.Contracts.IConfigurationContract CurrentConfiguration
        {
            get
            {
                return Superbar.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.CurrentConfiguration);
            }
        }
        public Start9.Api.Contracts.IMessageContractContract MessageContract
        {
            get
            {
                return Superbar.Adapters.IMessageContractAddInAdapter.ViewToContractAdapter(_view.MessageContract);
            }
        }
        public Start9.Api.Contracts.IReceiverContractContract ReceiverContract
        {
            get
            {
                return Superbar.Adapters.IReceiverContractAddInAdapter.ViewToContractAdapter(_view.ReceiverContract);
            }
        }
        public virtual void Kill(Start9.Api.Contracts.IModuleInstanceContract instance)
        {
            _view.Kill(Superbar.Adapters.IModuleInstanceAddInAdapter.ContractToViewAdapter(instance));
        }
        public virtual void KillAll()
        {
            _view.KillAll();
        }
        public virtual void Activate(bool initialize)
        {
            _view.Activate(initialize);
        }
        internal Superbar.Views.IModuleAssembly GetSourceView()
        {
            return _view;
        }
    }
}

