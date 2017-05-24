using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace LoginForm.ViewModel
{
	public class LoginFormPageViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChange Implementation
		public event PropertyChangedEventHandler PropertyChanged = delegate
		{

		};
		#endregion

		public Action DisplayInvalidLoginPrompt;

		private string emailAddress;

		public string EmailAddress
		{
			get
			{
				return emailAddress;
			}
			set
			{
				emailAddress = value;
				PropertyChanged(this, new PropertyChangedEventArgs("EmailAddress"));
			}
		}


		private string password;

		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Password"));
			}
		}

		public ICommand SubmitCommand { get; protected set; }

		public LoginFormPageViewModel()
		{
			SubmitCommand = new Command(OnSubmit);
		}

		public void OnSubmit()
		{
			if (emailAddress != "sss" || password != "s")
			{
				DisplayInvalidLoginPrompt();
			}
		}


	}
}
