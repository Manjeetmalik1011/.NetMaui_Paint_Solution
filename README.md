# .NET MAUI Community Toolkit Drawing View Pain Application Sample

The .NET MAU Community Toolkit is a collection of common elements for mobile development with .Net MAUI that people tend to replicate across multiple apps. It simplifies and demonstrates common developer tasks when building apps with Xamarin.Forms.

# Build Status
If you like to live dangerously, you can use our nightly feed to try out the latest and greatest.


# Installation
The Toolkit is available via NuGet, and should be installed into all of your projects (shared and individual platforms):

Browse with the NuGet manager in your IDE to install them or run this command:

Install-Package CommunityToolkit.Maui -Version 1.0.0

Note that the C# Markup Extensions are in a separate package, install that with:

Install-Package CommunityToolkit.CommunityToolkit.Markup

# Getting Started
After installation, start using the features you're after.

In order to use the .NET MAUI Community Toolkit you need to call the extension method in your MauiProgram.cs file as follows:

using CommunityToolkit.Maui;


		
// Initialise the toolkit

builder.UseMauiApp<App>().UseMauiCommunityToolkit();

// the rest of your logic...
	

# XAML usage
In order to make use of the toolkit within XAML you can use this namespace:

xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"

<img width="918" alt="Screenshot 2022-06-05 at 6 01 08 PM" src="https://user-images.githubusercontent.com/100989615/172052791-239ac697-aec5-4b41-b0f8-5f5f78d70e63.png">

![imgonline-com-ua-twotoone-SrJgdmnjCyoAb](https://user-images.githubusercontent.com/100989615/172052809-f417fea1-ed93-4636-b0c2-bebbf17bf088.jpg)
	
![imgonline-com-ua-twotoone-D7kbB4z99gdmg](https://user-images.githubusercontent.com/100989615/172052833-bf60d3db-0d50-439b-8979-4238743ff7ce.jpg)
	
<img width="914" alt="Screenshot 2022-06-05 at 6 02 17 PM" src="https://user-images.githubusercontent.com/100989615/172052866-18661387-5d12-4bcb-89be-1decbd9202f2.png">


