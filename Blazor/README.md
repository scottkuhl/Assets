# Project Name

Project description.

## Learning Resources

If you have never programmed in C# before, this is not the place to start.  I recommend trying one of these paths instead:

- [LaunchCode](https://www.launchcode.org/) offers a complete and free programming course online that is the same version students take.
You can begin with a [Discovery](https://stepik.org/course/4261/promo#toc) course if you have never programmed before, 
move on to the [Intro to Web Development](https://education.launchcode.org/intro-to-professional-web-dev/) which teaches you the basics of programming in JavaScript 
and conclude with the [C# Web Development](https://education.launchcode.org/csharp-web-development/) course. 
While these courses teach web development with MVC they also teach you the basics of programming that you will need along the way.
There is even a [Liftoff](https://education.launchcode.org/liftoff/) course you can follow along with after learning Blazor to build your own project and practice your skills.

- Bob Tabor's ever evolving yet still classic course, [C# Fundamentals for Absolute Beginners](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners), is available on Channel 9.

If you have programmed in C# but are new to Blazor, try one of these options:

- The [Blazor Workshop](https://github.com/dotnet-presentations/blazor-workshop/) is a hands on lab for building an end-to-end application that is both popular and kept up to date.

- The [Blazor documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/) is straight forward and easy to follow.

An ongoing wealth of growing information is also available at [Awesome Blazor](https://github.com/AdrienTorris/awesome-blazor).

## Clean code

To keep things consistent, the project uses Visual Studio extensions for clean code:

1. [CodeMaid](http://www.codemaid.net/) - The solution folder contains a basic configuration for it.
1. [Roslynator](https://github.com/JosefPihrt/Roslynator) - A extended collection of Rosyln analyzers.  You don't need to instead the extension for this one, it is included as a NuGet package.
1. [Code Cleanup on Save](https://github.com/madskristensen/CodeCleanupOnSave) - I am using this extension to apply code cleanup rules on every save.  The clean up profile I am using has all option applied.  Unfortunately at this time, these options can't be stored in a solution.
1. A starting .editorconfig file with minimal rule changes.

## Platform Specifics

TODO: Indicate what heads are being targeted.  Example: Server-side, Web Assembly, Mobile Bindings, Electron, etc.

## Core Functionality

- **Guard clauses** are available using the [Ardalis.GuardClauses](https://github.com/ardalis/guardclauses) NuGet package.
- **Human readable value manipulation** are available with the [Humanizer](https://github.com/Humanizr/Humanizer) NuGet packager.

## Testing

- Tests should follow a **WhatGivenShould** pattern and be are categorized by Unit or Integration **traits**.
- The site should pass Lighthouse tests.

## Visuals

- **Icons** can be found at [Icons8](https://icons8.com/).
- **Font Icons** can be found at 
[Font Awesome](https://fontawesome.com/), 
[Fluent UI](https://developer.microsoft.com/en-us/fluentui#/styles/web/icons, 
[Bootstrap](https://icons.getbootstrap.com/),
[Feather](https://feathericons.com/) or
[Open Iconic](https://useiconic.com/open).

## UX

- Should scale from phone to desktop.
- Should be accessible.
- Should support dual screen interfaces.