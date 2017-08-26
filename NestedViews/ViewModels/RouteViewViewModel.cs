using Prism.Mvvm;

using NestedViews.Models;

namespace NestedViews.ViewModels
{
  public class RouteViewViewModel : BindableBase
  {
    private PlaceViewViewModel _startingPlace;
    public PlaceViewViewModel StartingPlace
    {
      get => _startingPlace;
      set => SetProperty(ref _startingPlace, value);
    }
    private PlaceViewViewModel _targetPlace;
    public PlaceViewViewModel TargetPlace
    {
      get => _targetPlace;
      set => SetProperty(ref _targetPlace, value);
    }

    public RouteViewViewModel()
    {
      _startingPlace = new PlaceViewViewModel(new Place());
			_targetPlace = new PlaceViewViewModel(new Place());
		}
  }
}
