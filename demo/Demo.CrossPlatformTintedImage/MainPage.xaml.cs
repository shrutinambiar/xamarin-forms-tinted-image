using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.CrossPlatformTintedImage
{
    public partial class MainPage : ContentPage
    {
        bool shouldTint = true;

        public MainPage()
        {
            InitializeComponent();
        }

        void UpdateTint()
        {
            if (redSlider == null || greenSlider == null || blueSlider == null)
                return;

            tintedImage.TintColor = shouldTint ? Color.FromRgb((int)redSlider.Value, (int)greenSlider.Value, (int)blueSlider.Value) : Color.Transparent;
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateTint();
        }

        void OnTintSwitchToggled(object sender, ToggledEventArgs e)
        {
            shouldTint = e.Value;
            UpdateTint();
        }
    }
}
