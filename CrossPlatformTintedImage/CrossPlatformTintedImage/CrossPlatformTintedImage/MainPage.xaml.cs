using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossPlatformTintedImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            redSlider.Value = 128;
            greenSlider.Value = 128;
            blueSlider.Value = 128;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Change Tint Color
            tintedImage.TintColor = Color.FromRgb((int) redSlider.Value, (int) greenSlider.Value, (int) blueSlider.Value);
        }
    }
}
