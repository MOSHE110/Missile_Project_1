using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using Missile_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Missile_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetGeoCoordinate("IL_Jerusalem_Havad_haleumi");
            GetGeoCoordinateExif();
        }
        private async void GetGeoCoordinate(string address)
        {
           var Coordinate = await ViewModels.GeoCoordinateApi.GetGeoCoordinateAsync(address);
            double let = Coordinate.results[0].geometry.location.lat;
            double lng = Coordinate.results[0].geometry.location.lng;

           

        }
        private  void GetGeoCoordinateExif()
        {
            //string imagepath = @"C:\Users\Moshe\source\repos\Missile_Project_1\Missile_Project\Missile_Project\images\dcv.jpg";
            //string imagepath = @"C:\Users\Moshe\Desktop\img_2158.jpg";
            //string imagepath = @"C:\Users\Moshe\Desktop\exif-samples-master\exif-samples-master\jpg\exif-org\canon-ixus.jpg";
            string imagepath = @"C:\Users\Moshe\source\repos\Missile_Project_1\Missile_Project\Missile_Project\images\olympus-d320l.jpg";

            var directories = ImageMetadataReader.ReadMetadata(imagepath);

            // print out all metadata
            foreach (var directory in directories)
                foreach (var tag in directory.Tags)
                    Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");

        //    // access the date time
        //    var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
        //    var dateTime = subIfdDirectory?.GetDateTime(ExifDirectoryBase.TagDateTime);
        //    var gpsDirectories = directories.OfType<GpsDirectory>().FirstOrDefault();





        //    var gps =  ImageMetadataReader.ReadMetadata(imagepath)
        //                    .OfType<GpsDirectory>()
        //                    .FirstOrDefault();

        //    var location = gps.GetGeoLocation();

        //    //Console.WriteLine("Image at {0},{1}", location.Latitude, location.Longitude);
          
        }

        private void ButtonClikP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new callerCenterPanel();
        }

        private void ButtonClikP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new AnalistPanel();
        }

        private void ButtonClikP3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Map();

        }
    }
}
