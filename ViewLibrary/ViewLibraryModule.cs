using ViewLibrary.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace ViewLibrary
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
            _regionManager.RegisterViewWithRegion("ContentA", typeof(ViewA));
            _regionManager.RegisterViewWithRegion("ContentB", typeof(ViewB));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}