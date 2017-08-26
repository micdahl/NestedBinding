using Prism.Mvvm;

using NestedViews.Models;

namespace NestedViews.ViewModels
{
  public class PlaceViewViewModel : BindableBase
  {

    private Place _place;

    public string City
    {
      get => _place.City;
      set
      {
        _place.City = value;
        RaisePropertyChanged("City");
      }
    }

    public string Street
    {
      get => _place.Street;
      set
      {
        _place.Street = value;
        RaisePropertyChanged("Street");
      }
    }

    public PlaceViewViewModel(Place place)
    {
      _place = place;
    }
  }
}
