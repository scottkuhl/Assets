# Project Name

Project description.

## Learning Resources

If you have never programmed in C# before, this is not the place to start.  I recommend trying one of these paths instead:

- [LaunchCode](https://www.launchcode.org/) offers a complete and free programming course online that is the same version students take.
You can begin with a [Discovery](https://stepik.org/course/4261/promo#toc) course if you have never programmed before, 
move on to the [Intro to Web Development](https://education.launchcode.org/intro-to-professional-web-dev/) which teaches you the basics of programming in JavaScript 
and conclude with the [C# Web Development](https://education.launchcode.org/csharp-web-development/) course. 
While these courses teach web development they also teach you the basics of programming that you will need along the way.
There is even a [Liftoff](https://education.launchcode.org/liftoff/) course you can follow along with after learning UWP to build your own project and practice your skills.

- Bob Tabor's ever evolving yet still classic course, [C# Fundamentals for Absolute Beginners](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners), is available on Channel 9.

If you have programmed in C# but are new to UWP, try one of these options:

- Bob Tabor's follow up course for UWP, [Windows 10 development for absolute beginners](https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners), is available on Channel 9.

- Microsoft Learn has created the [Develop Windows 10 applications](https://docs.microsoft.com/en-us/learn/paths/develop-windows10-apps/) learning path UWP.

- SyncFusion has a 5 part free eBook series you can get here: [UWP Succinctly](https://www.syncfusion.com/ebooks/uwp_succinctly), [More UWP Succinctly](https://www.syncfusion.com/ebooks/more_uwp_succinctly), Advanced UWP [Part 1](https://www.syncfusion.com/resources/techportal/whitepapers/Advanced_UWP_Part_1), [Part 2](https://www.syncfusion.com/resources/techportal/whitepapers/Advanced_UWP_Part_2), [Part 3](https://www.syncfusion.com/resources/techportal/whitepapers/Advanced_UWP_Part_3), [Part 4](https://www.syncfusion.com/resources/techportal/whitepapers/Advanced_UWP_Part_4) and [Part 5](https://www.syncfusion.com/resources/techportal/whitepapers/Advanced_UWP_Part_5).

An ongoing wealth of growing information is also available at [Awesome UWP](https://github.com/tomzorz/awesome-uwp) and Awesome [WinUI](https://github.com/scottkuhl/awesome-winui).

## Clean code

To keep things consistent, the project uses three Visual Studio extensions for clean code:

1. [CodeMaid](http://www.codemaid.net/) - The solution folder contains a basic configuration for it.
1. [XAML Styler](https://github.com/Xavalon/XamlStyler) - The solution folder contains a configuration developed for [Windows Template Studio](https://github.com/microsoft/windowsTemplateStudio).
1. [Roslynator](https://github.com/JosefPihrt/Roslynator) - A extended collection of Rosyln analyzers.  You don't need to instead the extension for this one, it is included as a NuGet package.
1. [Code Cleanup on Save](https://github.com/madskristensen/CodeCleanupOnSave) - I am using this extension to apply code cleanup rules on every save.  The clean up profile I am using has all option applied.  Unfortunately at this time, these options can't be stored in a solution.
1. A starting .editorconfig file with minimal rule changes.

## Core Functionality

- A **solution framework** is available with [Windows Template Studio](https://github.com/microsoft/windowsTemplateStudio).
- **Standard converters** are available using the [Xamarin.Forms.ConvertersPack](https://www.nuget.org/packages/Xamarin.Forms.ConvertersPack/) NuGet package.
- **Guard clauses** are available using the [Ardalis.GuardClauses](https://github.com/ardalis/guardclauses) NuGet package.
- **Human readable value manipulation** are available with the [Humanizer](https://github.com/Humanizr/Humanizer) NuGet packager.
- **Property change notification** can be handled using the [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/) NuGet package.
- A basic **MVVM** can be found in [Windows Template Studio](https://github.com/microsoft/windowsTemplateStudio) which can be extended with [Dependency Injection](https://medium.com/@scottkuhl/windows-template-studio-extending-mvvm-basic-with-dependency-injection-6b010afd695f) and [Messaging](https://medium.com/@scottkuhl/windows-template-studio-extending-mvvm-basic-with-messaging-8c225143bb83).

## Test Projects

- Tests should follow a **WhatGivenShould** pattern and be are categorized by Unit or Integration **traits**.

### UWP

For UWP the manifest was updated:

1. The Display name and Description was changed.
1. The frame rate counter was removed from the App class's OnLaunched method.