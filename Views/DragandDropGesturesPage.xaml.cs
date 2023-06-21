using GesturesSample.ViewModels;

namespace GesturesSample.Views;

public partial class DragandDropGesturesPage : ContentPage
{
	DragandDropViewModel dragandDropViewModel = new DragandDropViewModel();
    public DragandDropGesturesPage()
	{
		InitializeComponent();
		this.BindingContext = dragandDropViewModel;

    }
}
