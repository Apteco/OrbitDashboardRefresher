# OrbitDashboardRefresher
This is a sample application to fetch dashboard results.

### Background
Apteco FastStats® is part of the [Apteco Marketing Suite](http://www.apteco.com).  It provides a unique
combination of speed and power for data exploration, data mining analysis and customer understanding.

The Apteco API provides programmatic access to information held in an Apteco FastStats® database, as
well as reporting information generated from [Apteco PeopleStage™](https://www.apteco.com/products/peoplestage),
the powerful multi channel campaign automation software.

### Usage
To use the OrbitDashboardRefresher, download the latest release from [GitHub](https://github.com/Apteco/OrbitDashboardRefresher/releases)
or build the software via Visual Studio or the .Net Core CLI (see [below](#Build)).

To find out what command line parameters are required, run the console application with no parameters:

You will need the following pieces of information:

* The name of a DataView to connect to and a valid username and password for that DataView
* The API URL

### Build
To build the project, either do so via Visual Studio (2017 or later) or using the dotnet CLI tool.

##### Visual Studio
Open the OrbitDashboardRefresher.sln file in Visual Studio and build the project.

To generate the standalone executable, right-click on the Apteco.OrbitDashboardRefresher.Console project and choose "Publish...".
Then choose the "Folder Profile" and publish that.  The binaries will be compiled into
`Apteco.OrbitDashboardRefresher.Console\bin\Release\netcoreapp3.1`

##### dotnet CLI
To build the project so that it will run under any archirecture that .Net Core supports (Windows, Mac OSX, Linux), go to the
root directory and run `dotnet build`.  This will compile the code so that it can be run using the commands:

```
cd Apteco.OrbitDashboardRefresher.Console\bin\Debug\netcoreapp3.1
dotnet OrbitDashboardRefresher-Console.dll
```

To build a .exe file that will run on the Windows 64 bit platform, go to the root directory and run 
```
dotnet publish -c Release -r win-x64
```

The binaries will be compiled into
`Apteco.OrbitDashboardRefresher.Console\bin\Release\netcoreapp3.1`