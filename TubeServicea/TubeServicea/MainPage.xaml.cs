using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TubeServicea
{
	public partial class MainPage : ContentPage
	{
        public List<Line> LineServices { get; set; }

        public MainPage()
		{
			InitializeComponent();
            
            try
            {
                Line lineBakerloo = new Line("Bakerloo", "Severe delays", "Some severe delay text");
                Line lineCentral = new Line("Central", "Severe delays", "Some severe delay text");
                Line lineCircle = new Line("Circle", "Minor delays", "Some minor delay text");
                Line lineDistrict = new Line("District", "Minor delays", "Some minor delay text");
                Line lineHammersmithAndCity = new Line("Hammersmith & City", "Good service", "Some good service text");
                Line lineJubilee = new Line("Jubilee", "Good service", "Some good service text");
                Line lineMetropolitan = new Line("Metropolitan", "Good service", "Some good service text");
                Line lineNorthen = new Line("Northen", "Good service", "Some good service text");
                Line linePiccadilly = new Line("Piccadilly", "Good service", "Some good service text");
                Line lineVictoria = new Line("Victoria", "Good service", "Some good service text");
                Line lineWaterlooAndCity = new Line("Waterloo & City", "Good service", "Some good service text");

                LineServices = new List<Line>();
                
                LineServices.Add(lineJubilee);
                LineServices.Add(lineMetropolitan);
                LineServices.Add(lineNorthen);
                LineServices.Add(linePiccadilly);
                LineServices.Add(lineVictoria);
                LineServices.Add(lineWaterlooAndCity);
                LineServices.Add(lineBakerloo);
                LineServices.Add(lineCentral);
                LineServices.Add(lineCircle);
                LineServices.Add(lineDistrict);
                LineServices.Add(lineHammersmithAndCity);

                LineServices = LineServices.OrderByDescending(x => x.LineServiceNumber).ThenBy(x => x.LineName).ToList();


                lstLineServices.ItemsSource = LineServices;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void lstLineServices_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lstLineServices.SelectedItem != null)
            {

                Line line = (Line)lstLineServices.SelectedItem;
                var lineDetails = new LineDetails(line);
                //lineDetails.BarBackgroundColor = Color.White;
                //lineDetails.BarTextColor = Color.Black;
                lineDetails.Title = line.LineName;
                Navigation.PushAsync(lineDetails);
                lstLineServices.SelectedItem = null;


            }

        }
    }
}
