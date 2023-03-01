
<a name="readme-top"></a>

<br />
<div align="center">
  <a href="">
  </a>

<h3 align="center">Brainsafe</h3>

  <p align="center">
    Android Mobile Automation User Manual 
    <br />
    <a href=""><strong>Explore the docs</strong></a>
    <br />
    <br />
  </p>
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#Test_Environment">Test Environment Setup(WINDOWS OS)</a>
      <ul>
	  <li><a href="#Install-Visual-Studio">Install Visual Studio</a></li>
        <li><a href="#Install-Appium-Server">Install Appium Server</a></li>
        <li><a href="#Install-JAVA-JDK">Install JAVA JDK</a></li>
        <li><a href="#Android_Software_Dependencies">Android Software Dependencies</a></li>
      </ul>
    </li>
    <li><a href="#Project_Structure">Project Structure</a></li>
    <li><a href="#Execute_Tests">Execute Tests</a></li>
    <li><a href="#Reporting_Test_Results">Reporting Test Results</a></li>
    <li><a href="#Special_Notes">Special Notes</a></li>
    <li><a href="#Author">Author</a></li>
    <li><a href="#References">References</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

Brainsafe is a mobile application which use to increase safety in sports where head injuries occur and minimize long-term effect after getting a concussion.
This is a platform to educate the users about concussions, offer a 6-step rehabilitation program etc. 

Automation project built for the Android platform.
Test Scripts can be executed in real devices as well as emulators.

### Built With

The test automation project comprises following tools and libraries :

* **Design Pattern** - Paje Object Model
* **Appium** - Mobile Hybrid App (as a Driver)
* **C#** - Programming language
* **Visual Studio** - Integrated Development Environment
* **Nunit** - unit testing framework
* **Andriod Studio** - emulator

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started


## Test Environment Setup (WINDOWS OS)

### 1. Install Visual Studio

* Download Visual Studio :
```
https://visualstudio.microsoft.com/downloads/
```

### 2. Install Appium Server

* Install node.js and npm :
```
https://nodejs.org/en/
```
* Check node.js and npm are installed :
```
node --version
npm --version
```
* Install Appium by npm :
```
npm install -g appium
```
* Check Appium is installed :
```
appium --version
```
* Install Appium GUI version by downloading :
```
https://github.com/appium/appium-desktop/releases/tag/v1.22.3-4
```
* Install Appium doctor :
```
npm install appium-doctor -g
```
* Check Appium doctor is installed :
```
appium-doctor --version
```

### 3. Install JAVA JDK

Check java jdk is already installed :
```
java -version
```
You should see following output if java is already installed :
```
java version "19.0.1" 2022-10-18
Java(TM) SE Runtime Environment (build 19.0.1+10-21)
Java HotSpot(TM) 64-Bit Server VM (build 19.0.1+10-21, mixed mode, sharing)
```
Download and install JAVA SDK if it is not installed (choose windows version)
```
https://www.oracle.com/java/technologies/downloads/
```

### Android Software Dependencies
#### - Android Emulator
* Download Android Studio : https://developer.android.com/studio
* Launch Android Studio - Tools - SDK Manager, update and download latest SDK tools
* Add JAVA JDK and Android SDK environment variables :
```
JAVA_HOME = C:\Program Files\Java\jdk-19 
ANDROID_HOME as an user variable = C:\Users\User\AppData\Local\Android\Sdk
PATH = %JAVA_HOME%\bin:%ANDROID_HOME%\platform-tools:%ANDROID_HOME%\platform-tools\adb
```
* Run appium doctor :
```
appium-doctor --android
```
* If everything install successfully, you should see output like this :
```
✔ The Node.js binary was found at: C:\Program Files\nodejs\node.EXE
✔ Node version is 18.12.1
✔ ANDROID_HOME is set to: C:\Users\User\AppData\Local\Android\Sdk
✔ JAVA_HOME is set to: C:\Program Files\Java\jdk-19
   Checking adb, android, emulator, apkanalyzer.bat
	'adb' is in C:\Users\User\AppData\Local\Android\Sdk\platform-tools\adb.exe
	'android' is in C:\Users\User\AppData\Local\Android\Sdk\tools\android.bat
	'emulator' is in C:\Users\User\AppData\Local\Android\Sdk\emulator\emulator.exe
	'apkanalyzer.bat' is in C:\Users\User\AppData\Local\Android\Sdk\cmdline-tools\latest\bin\apkanalyzer.bat
✔ adb, android, emulator, apkanalyzer.bat exist: C:\Users\User\AppData\Local\Android\Sdk
✔ 'bin' subfolder exists under 'C:\Program Files\Java\jdk-19
```
#### - Android real device
* Install Vysor :
```
https://www.vysor.io/download/
```
* Download andriod-sdk from command line tools and extract :
```
https://developer.android.com/studio
```
* Find the API level aligned with your device andriod version :
```
https://en.wikipedia.org/wiki/Android_version_history
```
* Navigate to \cmdline-tools\bin folder in downloaded andriod-sdk from commandline and execute :
```
sdkmanager "platform-tools" "platforms;android-<<API level>>"
```
* Check platform-tools is installed :
```
C:\Program Files\android-sdk
```
* Add Android SDK environment variables :
```
ANDROID_HOME as a system variable = C:\Program Files\android-sdk
PATH = C:\Program Files\android-sdk\platform-tools
```

<!-- Project Structure -->
## Project Structure

```
brainsafe_automation
|-- BrainSafe_POC
	|-- Apps
		|-- app-test-release.apk           
	|-- Base
		|-- Base.cs
		|-- ExtentReport.cs
	|-- Hooks
		|-- TestInitialize.cs
	|-- Pages 
		|-- BaseLine
			|-- BaseLine.cs
		|-- Home
			|-- AppHome.cs
		|-- Login
			|-- AppLogin.cs
		|-- Rehabilitation
			|-- BuffaloTreadmillTest.cs
			|-- CognitiveTest.cs
			|-- RehabilitationGeneral.cs
			|-- RetrunToPlayTest.cs
		|-- Welcome
			|-- AppWelcome.cs
	|-- TestResults
		|-- TestResults.xml  
	|-- Tests
		|-- TestRunner.cs  
		|-- TestWrapper.cs     
|-- README.md
```

#### Apps
Store the .apk files.

#### Hooks
Intializing and closing driver. 

#### Pages
PageObjects are used to store the Elements for a Page.

#### TestResults
Store test results as .xml file.

#### Tests
Test runner class where test cases are written and execution order is mentioned.
Test wrapper classes where methods are wrapped meaningfully to perform a specifc functionality.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Run Tests -->
## Execute Tests
#### - From Visual Studio

1. Open the Solution Explorer view
2. Right click on project folder 
3. Select Build 
4. Check if build is successful in the output panel
5. Open the Test Explorer view
6. Click on Run All Test In View or Run option

#### - From Developer PowerShell

1. Open Developer PowerShell from View->Terminal
2. Build project
```
dotnet build
```
3. Run all test
```
dotnet test --logger:nunit
```


## Reporting Test Results

After the tests have been executed an XML report will be generated in TestResult folder.


## Special Notes

If the analysis results do not match the expected results, the scripts will fail but in the test report the reason for the script failure will be mentioned.


Eg: If baseline test is not completed successfully.
```
**[Error in the Results: Expected Result should be 'Completed', But the given result is wrong**
```


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Author -->
## Author

Thara Perera - thara.perera@ascentic.se
<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- References -->
## References

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

* [Stack Overflow](https://stackoverflow.com/)
* [Automation Step By Step](https://www.youtube.com/c/AutomationStepByStep)
* [Execute Automation](https://www.youtube.com/@ExecuteAutomation)
* [GitHub Pages](https://pages.github.com)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

