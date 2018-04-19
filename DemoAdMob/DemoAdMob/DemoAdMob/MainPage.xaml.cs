using Xamarin.Forms;

namespace DemoAdMob
{
	public partial class MainPage : ContentPage
	{

        public MainPage()
		{
			InitializeComponent();

		    BindingContext = this;

		    if (Device.RuntimePlatform == Device.Android)
		        adMobView.AdUnitId = "SEU ID ANDROID";
		    else if (Device.RuntimePlatform == Device.iOS)
		        adMobView.AdUnitId = "SEU ID iOS";
        }
	}
}
