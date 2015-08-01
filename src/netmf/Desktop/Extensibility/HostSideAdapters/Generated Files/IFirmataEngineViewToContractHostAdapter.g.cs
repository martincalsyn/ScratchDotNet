//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PervasiveDigital.Scratch.DeploymentHelper.Extensibility.HostSideAdapters
{
    
    public class IFirmataEngineViewToContractHostAdapter : System.AddIn.Pipeline.ContractBase, PervasiveDigital.Scratch.DeploymentHelper.Extensibility.Contracts.IFirmataEngineContract
    {
        private PervasiveDigital.Scratch.DeploymentHelper.Extensibility.IFirmataEngine _view;
        public IFirmataEngineViewToContractHostAdapter(PervasiveDigital.Scratch.DeploymentHelper.Extensibility.IFirmataEngine view)
        {
            _view = view;
        }
        public virtual void ReportDigital(byte port, int value)
        {
            _view.ReportDigital(port, value);
        }
        public virtual void SendDigitalMessage(byte port, int value)
        {
            _view.SendDigitalMessage(port, value);
        }
        public virtual void SendExtendedMessage(byte command, byte[] data)
        {
            _view.SendExtendedMessage(command, data);
        }
        internal PervasiveDigital.Scratch.DeploymentHelper.Extensibility.IFirmataEngine GetSourceView()
        {
            return _view;
        }
    }
}

