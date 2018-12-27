﻿using MetadataExtractor;
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
using ExifLib;
using ExifReader = ExifLib.ExifReader;

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
           // GetGeoCoordinate("IL_Jerusalem_Havad_haleumi");
           // GetGeoCoordinateExif();
            //string imagepath = @"C:\Users\Moshe\Desktop\exif-samples-master\exif-samples-master\jpg\gps\DSCN0012.jpg";
            string imagepath = @"C:\Users\Moshe\Desktop\exif2.jpg";
           
            GetLatLongFromImage(imagepath);
        }
        private async void GetGeoCoordinate(string address)
        {
            var Coordinate = await ViewModels.GeoCoordinateApi.GetGeoCoordinateAsync(address);
            double let = Coordinate.results[0].geometry.location.lat;
            double lng = Coordinate.results[0].geometry.location.lng;
        }

        public static double[] GetLatLongFromImage(string imagePath)

        {
            ExifReader reader = new ExifReader(imagePath);

            // EXIF lat/long tags stored as [Degree, Minute, Second]
            double[] latitudeComponents;
            double[] longitudeComponents;

            string latitudeRef; // "N" or "S" ("S" will be negative latitude)
            string longitudeRef; // "E" or "W" ("W" will be a negative longitude)

            if (reader.GetTagValue(ExifTags.GPSLatitude, out latitudeComponents)
                && reader.GetTagValue(ExifTags.GPSLongitude, out longitudeComponents)
                && reader.GetTagValue(ExifTags.GPSLatitudeRef, out latitudeRef)
                && reader.GetTagValue(ExifTags.GPSLongitudeRef, out longitudeRef))
            {

                var latitude = ConvertDegreeAngleToDouble(latitudeComponents[0], latitudeComponents[1], latitudeComponents[2], latitudeRef);
                var longitude = ConvertDegreeAngleToDouble(longitudeComponents[0], longitudeComponents[1], longitudeComponents[2], longitudeRef);
                return new[] { latitude, longitude };
            }

            return null;

        }
        public static double ConvertDegreeAngleToDouble(double degrees, double minutes, double seconds, string latLongRef)
        {
            double result = ConvertDegreeAngleToDouble(degrees, minutes, seconds);
            if (latLongRef == "S" || latLongRef == "W")
            {
                result *= -1;
            }
            return result;
        }

        public static double ConvertDegreeAngleToDouble(double degrees, double minutes, double seconds)
        {
            return degrees + (minutes / 60) + (seconds / 3600);
        }
        private void GetGeoCoordinateExif()
        {
            /*
           / //string imagepath = @"C:\Users\Moshe\source\repos\Missile_Project_1\Missile_Project\Missile_Project\images\dcv.jpg";
            //string imagepath = @"C:\Users\Moshe\Desktop\img_2158.jpg";
            //string imagepath = @"C:\Users\Moshe\Desktop\exif-samples-master\exif-samples-master\jpg\exif-org\canon-ixus.jpg";
            string imagepath = @"C:\Users\Moshe\source\repos\Missile_Project_1\Missile_Project\Missile_Project\images\olympus-d320l.jpg";
           string imagepath = @" C:\Users\Moshe\Desktop\exif-samples-master\exif-samples-master\jpg\gps\DSCN0012.jpg
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
          */
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
