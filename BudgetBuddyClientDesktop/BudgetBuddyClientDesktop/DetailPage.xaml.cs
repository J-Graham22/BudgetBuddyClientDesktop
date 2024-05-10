using BudgetBuddyClientDesktop.ViewModels;

namespace BudgetBuddyClientDesktop;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}