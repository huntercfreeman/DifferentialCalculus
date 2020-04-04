using DifferentialCalculus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentialCalculus.Shared
{
    public class SiteState
    {
        public SiteState()
        {
            CurrentSectionTitle = "1.1";
            CurrentProblem = new Problem { Number = 0, Answer = "Select a Section and Problem from the top left menu.", Images = new List<string> { "content/aawdas.png" } };
        }

        private Problem _currentProblem;
        public Problem CurrentProblem 
        {
            get => _currentProblem;
            set
            {
                _currentProblem = value;
                CurrentProblemEventInvoke(new EventArgs());
            }
        }
        public event EventHandler CurrentProblemEventHandler;
        public void CurrentProblemEventInvoke(EventArgs e)
        {
            EventHandler handler = CurrentProblemEventHandler;
            handler?.Invoke(this, e);
        }

        private string _currentSectionTitle;
        public string CurrentSectionTitle 
        {
            get => _currentSectionTitle;
            set
            {
                _currentSectionTitle = value;
                CurrentSectionTitleEventInvoke(new EventArgs());
            }
        }
        public event EventHandler CurrentSectionTitleEventHandler;
        public void CurrentSectionTitleEventInvoke(EventArgs e)
        {
            EventHandler handler = CurrentSectionTitleEventHandler;
            handler?.Invoke(this, e);
        }

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
