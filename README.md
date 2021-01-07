## Description

Unable to navigate back using ```Shell.Current.Navigation.PopAsync()``` on third child Shell page ```MainPage/FirstPage/SecondPage/ThirdPage```.

## Steps to Reproduce

* Start the application
* Click on "Click Me!" buttons 3 times until you get a page with a label displaying "Third Page"
* Use the mobile hardware back button to go back

## Expected Behavior
* User is navigated back to the "Second Page"

## Actual Behavior
* User is unable to go back

## Version with issue: 
* Xamarin.Forms 5.0.0.1874
* Last known good version: Xamarin.Forms (4.8.0)
* IDE: Visual Studio Professional 2019 16.8.3
* Platform Target Frameworks: .NET Standard 2.0.3
* Android: 10
* Nuget Packages:
<ItemGroup> <PackageReference Include="Xamarin.Essentials"> <Version>1.6.0</Version> </PackageReference></ItemGroup>
* Affected Devices: Samsung Galaxy S9+ SM-G965F

## Workaround
* Use ```Shell.Current.Navigation.RemovePage(Shell.Current.Navigation.NavigationStack.LastOrDefault());``` to remove the last page
