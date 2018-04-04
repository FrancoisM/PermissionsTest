using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace PermissionsTest
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		    TestAsync();
		}

	    private static async Task TestAsync()
	    {
	        var photoSStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Photos);
	        var mediaStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.MediaLibrary);

	        if (photoSStatus != PermissionStatus.Granted || mediaStatus != PermissionStatus.Granted)
	        {
	            var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Photos, Permission.MediaLibrary);
	            photoSStatus = results[Permission.Photos];
	            mediaStatus = results[Permission.MediaLibrary];
	        }
        }
	}
}
