using InstagramAppExercise.Controller;
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
	public partial class UserNotificationList : ContentPage
	{
        private ActivityService activity = new ActivityService();
		public UserNotificationList ()
		{
			InitializeComponent ();
            InstaListView.ItemsSource = activity.GetActivities();

        }

        async private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)  return;
            //Checkeamos que no sea null, en ese caso no hace falta ni gastar memoria en instanciarlo,
            //en caso contrario casteamos a Actividad.
            var selected = e.SelectedItem as Activity;
            //Marcamos el objeto como null (quitarle la selección)
            InstaListView.SelectedItem = null;
            //Regirigimos el flujo a la nueva Page
            await Navigation.PushAsync(new UserProfilePage(selected.UserId));
        }
    }
}