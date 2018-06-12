using InstagramAppExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramAppExercise.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
        private UserService userService = new UserService();
		public UserProfilePage ()
		{
			InitializeComponent ();
		}
        public UserProfilePage(int UserId)
        {
            BindingContext = userService.GetUser(UserId);
            InitializeComponent();
        }
	}
}