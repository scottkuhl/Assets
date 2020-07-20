# Project Name

Project description.

## Learning Resources

If you have never programmed in C# before, this is not the place to start.  I recommend trying one of these paths instead:

- [LaunchCode](https://www.launchcode.org/) offers a complete and free programming course online that is the same version students take.
You can begin with a [Discovery](https://stepik.org/course/4261/promo#toc) course if you have never programmed before, 
move on to the [Intro to Web Development](https://education.launchcode.org/intro-to-professional-web-dev/) which teaches you the basics of programming in JavaScript 
and conclude with the [C# Web Development](https://education.launchcode.org/csharp-web-development/) course. 
While these courses teach web development they also teach you the basics of programming that you will need along the way.
There is even a [Liftoff](https://education.launchcode.org/liftoff/) course you can follow along with after learning Xamarin Forms to build your own project and practice your skills.

- Xamarin University is no more, but their C# course is still available on YouTube along with exercises on [GitHub](https://github.com/XamarinUniversity).
I have collected the C# introduction course lessons in a [Xamarin C# Course](https://www.youtube.com/playlist?list=PLq-muhRbo9by_BBIHIsH9wsfwO7tc469x) playlist.

- Bob Tabor's ever evolving yet still classic course, [C# Fundamentals for Absolute Beginners](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners), is available on Channel 9.

If you have programmed in C# but are new to Xamarin, try one of these options:

- The Xamarin University course on Xamarin Forms is also still available on YouTube along with exercises on [GitHub](https://github.com/XamarinUniversity).
I have colleced those course lessons in a [Xamarin Forms Course](https://www.youtube.com/playlist?list=PLq-muhRbo9bwTS9bgshpcs90oGYtzdaeT).

- Microsoft Learn has created [learning path](https://docs.microsoft.com/en-us/learn/browse/?expanded=dotnet&products=xamarin&resource_type=learning%20path) for Xamarin Forms.

An ongoing wealth of growing information is also available at [Awesome Xamarin Forms](https://github.com/jsuarezruiz/awesome-xamarin-forms).

## Clean code

To keep things consistent, the project uses three Visual Studio extensions for clean code:

1. [CodeMaid](http://www.codemaid.net/) - The solution folder contains a basic configuration for it.
1. [XAML Styler](https://github.com/Xavalon/XamlStyler) - The solution folder contains a configuration developed by [SharpNado](https://www.sharpnado.com/xamarin-forms-xamlstyler-config/) specifically for Xamarin Forms.
1. [Roslynator](https://github.com/JosefPihrt/Roslynator) - A extended collection of Rosyln analyzers.  You don't need to instead the extension for this one, it is included as a NuGet package.
1. [Code Cleanup on Save](https://github.com/madskristensen/CodeCleanupOnSave) - I am using this extension to apply code cleanup rules on every save.  The clean up profile I am using has all option applied.  Unfortunately at this time, these options can't be stored in a solution.
1. A starting .editorconfig file with minimal rule changes.

## Platform Specifics

### Android

The following settings were changed under the Android project settings:

1. Compile using Android version was changed from 9.0 (Pie) to 10.0 (Q).
2. The application name under Manifest was changed.
3. The package name under Manifest was changed.
4. The Target Android version was changed from 9.0 (API Level 28 - Pie) to 10.0 (API Level 29 - Q). 
5. Enable Startup Tracing under Options was enable for the release configuration only.

### iOS

For iOS the manifest was updated:

1. The Application Name was changed.
2. The Bundle Identifier was changed.

### UWP

For UWP the manifest was updated:

1. The Display name and Description was changed.
1. The frame rate counter was removed from the App class's OnLaunched method.

## Core Functionality

- **Standard converters** are available using the [Xamarin.Forms.ConvertersPack](https://www.nuget.org/packages/Xamarin.Forms.ConvertersPack/) NuGet package.
- **Guard clauses** are available using the [Ardalis.GuardClauses](https://github.com/ardalis/guardclauses) NuGet package.
- **Human readable value manipulation** are available with the [Humanizer](https://github.com/Humanizr/Humanizer) NuGet packager.
- **Application settings** can be stored and retrieved using the strongly type static Settings class.
- **Property change notification** can be handled using the [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/) NuGet package.
- **Platform specifics** beyond Xamarin Essentials can be handled using the [Shiny.Core](https://www.nuget.org/packages/Shiny.Core/) NuGet package.

## Visuals

- **Material Visual** can be enabled for an Android feel in iOS.
- **Automatic image resizing** can be done with the included [Resizetizer NT](https://github.com/Redth/ResizetizerNT) NuGet package.
- **Image performance** can be enhanced with the [glidex.forms](https://www.nuget.org/packages/glidex.forms) NuGet package on Android and the [Xamarin.Forms.Nuke](https://www.nuget.org/packages/xamarin.forms.nuke) NuGet packages on iOS.
- **Design ideas** can be found at [Snppts](https://snppts.dev/).
- **Icons** can be found at [Icons8](https://icons8.com/).
- **Bottom navigation** is implemented using the [ThriveGmbH.BottomNavigationBar.XF](https://www.nuget.org/packages/ThriveGmbH.BottomNavigationBar.XF/) Nuget package.

## Pages
- Should scale from phone to tablet.
- Should support pull to refresh.
- Elements should be accessible.