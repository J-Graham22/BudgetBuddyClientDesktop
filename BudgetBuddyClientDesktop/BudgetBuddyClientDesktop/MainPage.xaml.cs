using BudgetBuddyClientDesktop.ViewModels;

namespace BudgetBuddyClientDesktop
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}
