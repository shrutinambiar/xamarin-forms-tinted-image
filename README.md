# Cross Platform Tinted Image
A simple custom control for tinting images in Xamarin Forms. 

## Supported Platforms
The `TintedImage` control supports native renderer implementations for the following platforms:
- iOS
- Android
- Universal Windows Platform

<p align="center">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/demo/Screenshots/iOSiPhone6sPlus.png" alt="iPhone 6s Screenshot" width="270" height="480">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/demo/Screenshots/AndroidNexus6p.png" alt="Nexus 6 Screenshot" width="270" height="480">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/demo/Screenshots/Windows10MobileLumia920.png" alt="Windows 10 Mobile Screenshot" width="270" height="480">
</p>

## Installation
* Available on NuGet: [Plugin.CrossPlatformTintedImage](https://www.nuget.org/packages/Plugin.CrossPlatformTintedImage/)
* Install into your shared PCL project and Platform projects.
* Make sure to initialize the renderer in your iOS, Android, and UWP projects as shown below:

```
Xamarin.Forms.Init();
TintedImageRenderer.Init();
```

## Sample Usage
- In Xaml:
```
<ContentPage 
    ...
    xmlns:controls="clr-namespace:Plugin.CrossPlatformTintedImage.Abstractions;assembly=Plugin.CrossPlatformTintedImage.Abstractions"
    ...>
    ...
    <controls:TintedImage TintColor="Blue" />
    ...
</ContentPage>
```

- In Code:
```
var tintedImage = new TintedImage { TintColor = Color.Blue };
```

## Note
Tinting can be disabled by setting `TintColor` to Transparent. This is demonstrated in the demo app.

<p align="center">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/demo/Screenshots/iOSiPhone6sPlusTintingOn.png" alt="iPhone 6s Screenshot Tinting On" width="270" height="480">
<img src="https://github.com/shrutinambiar/xamarin-forms-tinted-image/blob/master/demo/Screenshots/iOSiPhone6sPlusTintingOff.png" alt="iPhone 6s Screenshot Tinting Off" width="270" height="480">
</p>
