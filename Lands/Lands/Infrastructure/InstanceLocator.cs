using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructure
{
    using ViewModels;
    
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
    #endregion

    #region Contructors

    public InstanceLocator()
    {
            this.Main = new MainViewModel();

    }
    #endregion
}
}
