using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.FrequencyNavigation
{
    class FrequencyNavigationPlugin : ISharpPlugin
    {
        private const string _displayName = "Frequency Navigation";
        private ISharpControl _controlInterface;
        private FrequencyNavigationPanel _frequencyNavigationPanel;

        #region Implementation of ISharpPlugin

        public void Initialize(ISharpControl control)
        {
            _controlInterface = control;
            _frequencyNavigationPanel = new FrequencyNavigationPanel(_controlInterface);
        }

        public void Close()
        {
        }

        public bool HasGui { get { return true; } }
        public UserControl GuiControl { get { return _frequencyNavigationPanel; } }
        public UserControl Gui { get { return _frequencyNavigationPanel; } }
        public string DisplayName { get { return _displayName; } }

        #endregion
    }
}
