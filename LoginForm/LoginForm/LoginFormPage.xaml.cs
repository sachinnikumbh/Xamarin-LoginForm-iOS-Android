using Xamarin.Forms;
using LoginForm.ViewModel;

namespace LoginForm
{
	public partial class LoginFormPage : ContentPage
	{
		public LoginFormPage()
		{
			var objLoginFormPageViewModel = new LoginFormPageViewModel();
			this.BindingContext = objLoginFormPageViewModel;
			objLoginFormPageViewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Alert", "Shree Swami Samarth", "Okay");
			InitializeComponent();
		}
	}
}
