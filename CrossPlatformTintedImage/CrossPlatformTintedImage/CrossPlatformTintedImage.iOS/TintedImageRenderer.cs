using CrossPlatformTintedImage;
using CrossPlatformTintedImage.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRendererAttribute(typeof(TintedImage), typeof(TintedImageRenderer))]

namespace CrossPlatformTintedImage.iOS
{

    public class TintedImageRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            SetTint();
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == TintedImage.TintColorProperty.PropertyName)
                SetTint();
        }

        void SetTint()
        {
            if (Control?.Image != null && Element != null)
            {
                Control.Image = Control.Image.ImageWithRenderingMode(UIKit.UIImageRenderingMode.AlwaysTemplate);
                Control.TintColor = ((TintedImage) Element).TintColor.ToUIColor();
            }
        }
    }
}