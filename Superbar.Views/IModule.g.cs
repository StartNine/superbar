//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Superbar.Views
{
    
    [System.AddIn.Pipeline.AddInBaseAttribute()]
    public interface IModule
    {
        IConfiguration Configuration
        {
            get;
            set;
        }
        IMessageContract MessageContract
        {
            get;
        }
        IReceiverContract ReceiverContract
        {
            get;
        }
        void Initialize(IHost host);
    }
}

