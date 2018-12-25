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
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        public Map()
        {
            InitializeComponent();
        }

        private void serch_data_click(object sender, RoutedEventArgs e)
        {
           
                string street = txt_street.Text;
                string city = txt_city.Text;
                string  state= txt_state.Text;
                string zip = txt_zip.Text;
            try
            {
                StringBuilder quarryAddress = new StringBuilder();
                quarryAddress.Append("https://www.google.com/maps?q=");
                //street
                if (street!=string.Empty)
                {
                    quarryAddress.Append(street + "," + "+"); 
                }
                //city
                if (city != string.Empty)
                {
                    quarryAddress.Append(city + "," + "+");
                }
                //state
                if (state != string.Empty)
                {
                    quarryAddress.Append(state + "," + "+");
                }
                //zip
                if (zip != string.Empty)
                {
                    quarryAddress.Append(zip + "," + "+");
                }
                WebBrowserGoogleMap.Navigate(quarryAddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
