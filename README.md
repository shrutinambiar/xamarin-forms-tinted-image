# Cross Platform Tinted Image
A simple custom control for tinting images in Xamarin Forms. 

## Supported Platforms
The `TintedImage` control supports native renderer implementations for the following platforms:
- iOS
- Android
- Universal Windows Platform

<p align="center">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/CrossPlatformTintedImage/Screenshots/iOSiPhone6sPlus.png" alt="iPhone 6s Screenshot" width="270" height="480">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/CrossPlatformTintedImage/Screenshots/AndroidNexus6p.png" alt="Nexus 6 Screenshot" width="270" height="480">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/CrossPlatformTintedImage/Screenshots/Windows10MobileLumia920.png" alt="Windows 10 Mobile Screenshot" width="270" height="480">
</p>

## Installation
The UWP project requires installation of <a href="https://www.nuget.org/packages/Win2D.uwp">Win2d<a/> and <a href="https://www.nuget.org/packages/CompositionProToolkit/">CompositionProToolkit<a/> packages. Apart from <a href="https://www.nuget.org/packages/Xamarin.Forms">Xamarin.Forms<a/>, the Android and iOS projects do not require any additional packages.

## Sample Usage
- In Xaml:
```
<ContentPage 
    ...
    xmlns:local="clr-namespace:CrossPlatformTintedImage;assembly=CrossPlatformTintedImage"
    ...>
    ...
    <local:TintedImage TintColor="Blue" />
    ...
</ContentPage>
```

- In Code:
```
var tintedImage = new TintedImage { TintColor = Color.Blue };
```

## Note
Tinting can be disabled by setting `TintColor` to Transparent.
