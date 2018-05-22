using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace TubeServicea
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LineDetails : ContentPage
	{
        public LineDetails(Line lineService)
		{
			InitializeComponent();
            BackgroundColor = Color.White;
            
            Title = lineService.LineName;
            
            lblServiceGoodBad.Text = lineService.LineService ;

            imgServiceGoodBad.Source = lineService.ImageSource;

            lblLineDetails.Text = lineService.LineDetails;

        }
	}
}