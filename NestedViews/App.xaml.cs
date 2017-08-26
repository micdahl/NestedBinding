using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;

using NestedViews.ViewModels;
using NestedViews.Views;

namespace NestedViews
{
  public partial class App : PrismApplication
  {
    public App(IPlatformInitializer initializer = null) : base(initializer) {}

    protected override void OnInitialized()
    {
      InitializeComponent();
      NavigationService.NavigateAsync("RouteView");
    }

    protected override void RegisterTypes()
    {
      Container.RegisterTypeForNavigation<RouteView, RouteViewViewModel>();
		}
  }
}
