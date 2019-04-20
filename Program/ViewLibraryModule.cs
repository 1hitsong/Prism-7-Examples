using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Program
{
    public class ViewLibraryModule : IModule
    {
        IRegionManager _regionManager;

        public ViewLibraryModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("ContentA", typeof(Views.ViewA));
            _regionManager.RegisterViewWithRegion("ContentB", typeof(Views.ViewB));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}