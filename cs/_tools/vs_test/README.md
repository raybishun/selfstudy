# Visual Studio 2019 Test Console

### Path
- C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform\

### File
- vstest.console.exe

### Help
- vstest.console.exe /?

### Example 1 (using .trx as output)
- "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform\vstest.console.exe" "C:\git\selfstudy\cs\dotnetfw\restsharp\WebServiceAutomation\MsTestProject\bin\Debug\MsTestProject.dll" /Logger:trx

### Results 1 (using .trx as output)
```
Microsoft (R) Test Execution Command Line Tool Version 16.4.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
  √ TestMethod1 [7ms]
  ! TestMethod2
Test run in progress.Results File: C:\Users\ray\TestResults\ray.bishun_X1CARBON_2020-04-25_21_23_38.trx

Test Run Successful.
Total tests: 2
     Passed: 1
    Skipped: 1
 Total time: 0.5333 Seconds
```
### Example 2 (using .html as output)
- "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform\vstest.console.exe" "C:\git\selfstudy\cs\dotnetfw\restsharp\WebServiceAutomation\MsTestProject\bin\Debug\MsTestProject.dll" /Logger:html

### Results 2 (using .html as output)
- https://github.com/raybishun/selfstudy/blob/master/cs/_tools/vs_test/TestResult_ray.bishun_X1CARBON_20200425_213348.html


### References
1. VSTest.Console.exe command-line options: https://docs.microsoft.com/en-us/visualstudio/test/vstest-console-options?view=vs-2019
2. More info on Console Logger: https://aka.ms/console-logger