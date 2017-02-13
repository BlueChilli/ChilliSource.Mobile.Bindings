# ChilliSource.Mobile.Bindings #

This project is part of the ChilliSource framework developed by [BlueChilli](https://github.com/BlueChilli).

## Summary ##

ChilliSource.Mobile.Bindings provides Xamarin bindings to iOS and Android third-party libraries that are used in ChilliSource.Mobile as well as other [BlueChilli](https://github.com/BlueChilli) mobile apps.

## Usage ##

1. Xamarin.iOS only: run the `make` command in the library's iOS subfolder. This will download the latest version of the cocoapod, compile the framework, and run [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/) to re-generate the binding C# files.
2. open the ChilliSource.Mobile.Bindings solution and build the library's project
3. reference the generated dll file in the library's `bin/` folder 

## Contributing ##

### Updating an existing Binding Project ###

1. fork this repo
2. for iOS, run the `make` command in the library's iOS subfolder. This will download the latest version of the cocoapod, compile the framework, and run [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/) to re-generate the binding C# files.
3. for Android, update `Android/Binding/Jars/[library name].aar` file with the latest from  [Maven](search.maven.org)
4. open the ChilliSource.Mobile.Bindings solution, rebuild the library's project in release mode, and fix any compile errors. Please see [Binding Objective-C Libraries](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-c-libraries/) for help with any iOS compile errors.
5. copy the generated dll file from the library's `bin/Release` folder and paste it over the one in the `/Nuget/[library name]` folder.
6. update the version number in the `/Nuget/[library name]/[library name].nuspec` file to match the version number of the updated native library
7. submit a pull request

### Adding a new Binding Project ###

To add a new third-party library (with the intention to use it in ChilliSource.Mobile) use the existing [projects](https://github.com/BlueChilli/ChilliSource.Mobile.Bindings/tree/master/Libraries) as examples to create the binding project and the corresponding folder and file structure, and send us a pull request from your fork.

## License ##

ChilliSource.Mobile.Bindings is licensed under the [MIT license](LICENSE).

## Feedback and Contact ##

For questions or feedback, please contact chillisource@bluechilli.com.

