using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Lab.PrismLifecycle.ViewModels
{
    public class MainPageViewModel : ViewModelBase, IApplicationLifecycleAware,IPageLifecycleAware
    {
        public ICommand OnNext { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            this.OnNext = new DelegateCommand(() =>
              {
                  this.NavigationService.NavigateAsync("PrismContentPage1");
              });
        }

        public void OnAppearing()
        {
          
        }

        public void OnDisappearing()
        {
            
        }

        public void OnResume()
        {
           
        }

        public void OnSleep()
        {
           
        }
    }
}
