using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public class SiteState
    {
        private bool _displaySideMenu;
        public bool DisplaySideMenu 
        {
            get => _displaySideMenu;
            set
            {
                _displaySideMenu = value;
                DisplaySideMenuEventInvoke(new EventArgs());
            }
        }
        public event EventHandler DisplaySideMenuEventHandler;
        public void DisplaySideMenuEventInvoke(EventArgs e)
        {
            EventHandler handler = DisplaySideMenuEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
