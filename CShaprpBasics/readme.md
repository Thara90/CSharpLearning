
<a name="readme-top"></a>





<br />
<div align="center">
  <a href="https://dev.azure.com/Dermalyzer/Dermalyzer-Frontend/_git/dermalytics-mobile?path=/automation">
  </a>

<h3 align="center">Dermalyser</h3>

  <p align="center">
    Automation Framework User Manual 
    <br />
    <a href="https://dev.azure.com/Dermalyzer/Dermalyzer-Frontend/_git/dermalytics-mobile?path=/automation"><strong>Explore the docs »</strong></a>
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
      <a href="#Test_Environment">Test Environment Setup(MAC OS)</a>
      <ul>
        <li><a href="#Install_Appium_Server">Install Appium Server</a></li>
        <li><a href="#Install_JAVA_JDK_and_Maven">Install JAVA JDK and Maven</a></li>
        <li><a href="#BrowserStack_Configuration">BrowserStack Configuration</a></li>
        <li><a href="#Environment_Variables">Environment Variables</a></li>
      </ul>
    </li>
    <li><a href="#Project_Structure">Project Structure</a></li>
    <li><a href="#Execute_Tests">Execute Tests</a></li>
    <li><a href="#Pipeline_Configurations">Pipeline Configurations</a></li>
      <ul>
        <li><a href="#Pipeline_Tasks">Pipeline Tasks</a></li>
        <li><a href="#Pipeline_Variable_Groups">Pipeline Variable Groups</a></li>
        <li><a href="#Execution">Execution</a></li>
      </ul>
    <li><a href="#Reporting_Test_Results">Reporting Test Results</a></li>
    <li><a href="#Special_Notes">Special Notes</a></li>
    <li><a href="#Author">Author</a></li>
    <li><a href="#References">References</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

Dermalyser is an image analysing software application functioning as decision support to healthcare professionals on assessing suspected
lesions for skin cancer.
The software application uses a mobile camera to capture images of skin lesions.

Automation project built for the Android & iOS platforms.
Test Scripts will be executed in real devices in BrowserStack and able to run parallel execution.

### Built With

The test automation framework comprises following tools and libraries :

* **Cucumber** - BDD Framework
* **Design Pattern** - Custom Page Object Pattern with Page Factory
* **Appium** - Mobile Native app, Hybrid App (as a Driver)
* **JAVA** - Programming language
* **Maven** - Build Tool
* **Intellij** - Integrated Development Environment
* **BrowserStack** - Cloud Based Hosted mobile real devices
* **TestNg** - TestNg Java testing framework


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started


## Test Environment Setup (MAC OS)


### 1. Install Appium Server


* Install Homebrew:
```
ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```
* Install node.js and npm :
```
brew install node
```
* Install Appium by npm
```
npm install -g appium@1.4.13
```

* Install Appium GUI version by downloading
```
https://bitbucket.org/appium/appium.app/downloads/
```



### 2. Install JAVA JDK and Maven

Check if java jdk (v11) is already install on your mac:
```
java -version
```
You should see following output if java already installed
```
openjdk 11.0.16.1 2022-08-12
OpenJDK Runtime Environment Homebrew (build 11.0.16.1+0)
OpenJDK 64-Bit Server VM Homebrew (build 11.0.16.1+0, mixed mode)
```
Download and install JAVA SDK if it is not yet installed (choose Mac OS X version)
```
http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html
```
Install Maven
```
brew install maven
```

#### Android & iOS Software Dependencies
#### - Android
* Download Android Studio : http://developer.android.com/sdk/index.html
* Launch Android Studio - Tools - SDK Manager, update and download latest SDK tools
* Add JAVA JDK and Android SDK environment variable to ~/.bash_profile:
```
export JAVA_HOME=/Library/Java/JavaVirtualMachines/jdk11.0.16.1.jdk/Contents/Home 
export ANDROID_HOME=~/Library/Android/sdk
export PATH=$PATH:$JAVA_HOME:$JAVA_HOME/bin:$ANDROID_HOME:$ANDROID_HOME/platform-tools:$ANDROID_HOME/platform-tools/adb
```
* Save `.bash_profile` and run:
```
source ~/.bash_profile
```

#### - iOS
1. Download `xCode7.3` stable release version: https://developer.apple.com/xcode/download/
2. Under xcode, Add simulator `iPhone 12 Pro + OS version 14.0`

If everything install successfully, you should see output like this:
```
Running Android Checks
✔ ANDROID_HOME is set to "/Users/***/Library/Android/sdk"
✔ JAVA_HOME is set to "/Library/Java/JavaVirtualMachines/jdk11.0.16.1.jdk/Contents/Home."
✔ ADB exists at /Users/***/Library/Android/sdk/platform-tools/adb
✔ Android exists at /Users/***/Library/Android/sdk/tools/android
✔ Emulator exists at /Users/***/Library/Android/sdk/tools/emulator
✔ Android Checks were successful.

✔ All Checks were successful
MacBook-Pro:Project AIM$ appium-doctor --ios
Running iOS Checks
✔ Xcode is installed at /Applications/Xcode.app/Contents/Developer
✔ Xcode Command Line Tools are installed.
✔ DevToolsSecurity is enabled.
✔ The Authorization DB is set up properly.
✔ Node binary found at /usr/local/bin/node
✔ iOS Checks were successful.

✔ All Checks were successful
```

### 3. BrowserStack Configuration

* Sign In - Login with given credentials
* Upload App - You can upload your .apk & .ipa files
  once upload is finish it gives an App ID

Ex:
```
bs://b6ef9e2367ebc67b20faa80518105065db4c2d6a
```


* Upload Images for Image Injection process

```
curl -u "BROWSERSTACK_USERNAME:BROWSERSTACK_ACCESSKEY" -X POST "https://api-cloud.browserstack.com/app-automate/upload-media" -F "LOCAL_LOCATION_OF_IMAGE" -F "custom_id=SampleMedia" -k
```
Once uploaded it will generate a url as below
```
"media://3a6832006db627c6ebba61b7637a0d42c44031c9","custom_id":"SampleMedia","shareable_id":"BROWSERSTACK_USERNAME/SampleMedia"
```
<!-- Environment Variables -->
### 3. Environment Variables

1. System requires below variables to be installed


* BROWSERSTACK_USERNAME
```
export BROWSERSTACK_USER="****"
```

* BROWSERSTACK_ACCESSKEY
```
export BROWSERSTACK_KEY="****"
```
* Correct Username to login
```
export APPUN1="bob@test.com"
```
* Correct Password to login
```
export APPPWD1="Pa\$\$w0rd"
```
* Incorrect Username
```
export INAPPUN1="wrongun@email.com"
```
* Incorrect Password
```
export INAPPPWD1="Wrongpw"
```
* Image Uploaded Image ID's
```
export MELANOMA="media://b846c16452ccb4744c13cdffca715875069d7695"
```
* Application Uploaded App IDs
```
export ANDROID_APP="bs://26f9e617382eb8ff42bc7a0dbdac255501efb781"
export IOS_APP="bs://b6ef9e2367ebc67b20faa80518105065db4c2d6a"
```


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Project Structure -->
## Project Structure

```
src
|-- test
    |-- java
        |-- AIM
            |-- Base
                |-- BasePage.java
                |-- BaseSteps.java
                |-- Basetest.java            
            |-- Features
                |-- AboutApp
                    |-- DermalyserAboutApp.feature
                |-- ContactUs
                    |-- DermalyserContactUs.feature
                |-- FAQ
                    |-- DermalyserFAQ.feature
                |-- Login
                    |-- HcpLogin.feature
                    |-- HcpForgotPassword.feature
                    |-- HcpLogout.feature
                |-- SkinTest	
                    |-- NegativePatientSkinTest.feature
                    |-- PatientSkinTest.feature
            |-- Pages 
                |-- PageAppDetails
                    |-- PageAppDetails.java
                |-- PageCamera
                    |-- PageCamera.java
                |-- PageLogin
                    |-- PageForgotPassword.java
                    |-- PageHcpLogin.java
                |-- PagePatientDetails
                    |-- PagePatientDetails.java
            |-- Steps
                |-- StepAppDetails
                    |-- StepAppDetails.java
                |-- StepLogin
                    |-- StepForgotPassword.java
                    |-- StepHcpLogin.java
                |-- StepSkinTest
                    |-- StepNegativeSkinTest.java
                    |-- StepPatientSkinTest.java
            |-- Tests
                |-- RunnerTest.java
        |-- Drivers
                |-- CommonDriver.java
                |-- DeviceAndroidDriver.java
                |-- DeviceiOSDriver.java            
|-- pom.xml
|-- android_test.xml
|-- ios_test.xml
|-- readme.md
```


#### Features
These files contains the acceptance criteria which are written in Gherkin Language and contains various scenarios.
The feature files are tagged with "@tagname" to group common feature files

#### Pages
PageObjects are used to store the Elements for a Page.

#### Steps
Every steps defined in Feature file needs to be implemented in Steps  Class.

#### Drivers
Device capabilities added here. considering the multiple devices (Android / iOS)
particular device capabilities added under drivers.

#### Tests - Runner Test
Test Suites are used to run a group of Tests which are tagged and represented in form of Feature files & Scenarios.
Adding tags to the "tags" filed will execute the scripts which is added.
```
@CucumberOptions(
    monochrome = true,
    plugin = {"json:target/cucumber.json"},
    tags = "@******",
    features = "src/test/java/AIM/Features",
    glue = "AIM.Steps",
    publish = true
)
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Run Tests -->
## Execute Tests
Test Suites are used to run a group of Tests which are tagged and represented in form of Feature files & Scenarios

Open the Terminal and execute this command

* Before run the tests, clean the project and removes all files generated by the previous build.
```
mvn clean
```

* To Run all test (iOS & Android) 
```
mvn test -DAPPPWD1="<password>" -DINAPPPWD1="<password>"
```
```
mvn clean install
```
* To Run all the tests and generate the Cucumber HTML Reports
```
mvn verify -DAPPPWD1="<password>" -DINAPPPWD1="<password>"
```
* To Run specific device (Ex: Android)
```
mvn verify -Dsurefire.suiteXmlFiles=android_test.xml -DAPPPWD1="<password>" -DINAPPPWD1="<password>"
```

* To Run specific Tag on both devices (Ex: @Login on Android & iOS)
```
mvn verify -Dcucumber.filter.tags="@PatientLogin" -DAPPPWD1="<password>" -DINAPPPWD1="<password>"
```

* To Run specific Tag on specific device (Ex: @Login on Android)
```
mvn verify -Dsurefire.suiteXmlFiles=android_test.xml -Dcucumber.filter.tags="@PatientLogin" -DAPPPWD1="Pa$$w0rd" -DINAPPPWD1="Pa$$w0rds"
```

* To Run if there are multiple tags on specific device (Ex: Under Login scenario there are specified tag called @CorrectCredentials)
```
mvn verify -Dsurefire.suiteXmlFiles=android_test.xml -Dcucumber.filter.tags="@PatientLogin and @CorrectCredentials" -DAPPPWD1="Pa$$w0rd" -DINAPPPWD1="Pa$$w0rds"
```

<!-- Pipeline configurations -->
## Pipeline Configurations

Azure devOps Release pipeline is configured to execute tests. Two pipelines have been created for Android and IOS tests.

#### Pipeline Tasks:

1. Download pipeline artifacts - To download the dropped artifacts from the dev build pipeline like .apk/.ipa files and test files needed for execution.
2. BrowserStack Config - To set up the connection between Azure and BrowserStack.
3. BrowserStack App Uploader - To upload the .apk/.ipa files to BrowserStack.
4. Java tool installer - To specify the Java version. Should user Java 11 to execute tests.
5. Commandline - Command to execute the tests. Refer **Run Tests** section for the commands.
6. Python script - To send an email with the attached test results file.

#### Pipeline Variable Groups:

1. BrowserStack connection variables
    1. BROWSERSTACK_ACCESS_KEY - To connect to BrowserStack servers from Azure.
    2. BROWSERSTACK_USERNAME - To connect to BrowserStack servers from Azure.
    3. BROWSERSTACK_APP_ID - To store the url returned after uploading the apk/ipa to browserStack.
2. Device settings
    1. IOS_DEVICE/ANDROID_DEVICE - This defines which device the tests should run on. The value of this will be used in appium capabilities.
    2. IOS_OS_VERSION/ANDROID_OS_VERSION - This defines which OS should use when executing the tests. The value of this will be used in appium capabilities.
3. Test data
    1. APPUN1 - Username used to log into the app.
    2. APPPWD1 - Password used to log into the app.
    3. INAPPUN1 - Incorrect username for negative scenarios.
    4. INAPPPWD1 - Incorrect password for negative scenarios.
    5. MELANOMA - The URL returned from BrowserStack after uploading the relevant image to BrowserStack.
    6. NOMELANOMA - The URL returned from BrowserStack after uploading the relevant image to BrowserStack.
    7. BLURRED - The URL returned from BrowserStack after uploading the relevant image to BrowserStack.
    8. DARK - The URL returned from BrowserStack after uploading the relevant image to BrowserStack.
4. Python script
    1. devopsalertmail - To specify the sender email account.
    2. devopsalertmailpassword - To specify the password of the sender email account.
    3. aimtestresultschannelmail - To specify the receiver email address.

#### Execution

Release pipeline will be executed :

1. Whenever after the dev build pipeline is executed.
2. On scheduled basis - Currently set to be executed at 10am(IST)
3. Manual trigger - Create and deploy manually


## Reporting Test Results

After the tests have been executed an XML report will be generated, and it will be sent to the specified recipient (recipient's email address needs to be set in the pipeline variables).
Two reports will be created for Android and IOS executions.


## Special Notes

If the analysis results do not match the expected results according to the images provided, the scripts will fail but in the test report the reason for the script failure will be mentioned.


Eg: If the image is melonama active and the expected result should be melonama detected, the test will fail with the following message in the test results file.
```
**[Error in the Results: Expected Result should be 'Evidence of Melanoma Detected', But the given result is wrong**
```


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Author -->
## Author

Thilan Weerasinghe - thilan@ascentic.se
<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- References -->
## References

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

* [Stack Overflow](https://stackoverflow.com/)
* [GitHub Pages](https://pages.github.com)
* [Automation Step By Step](https://www.youtube.com/c/AutomationStepByStep)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

