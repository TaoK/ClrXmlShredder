### Overview

This project serves a couple disparate purposes:

* Provide an illustration of how one might test (and use) the ClrXmlShredder class (CLR proc) from gist https://gist.github.com/1034768
* Provide an illustration of how "User Instances" of SQL Server might be used in test projects to increase packageability and reduce dependencies

The project is just in "first checkin" state, far from useful.

### Requirements

To run this code you will need two main things:

1. Visual C# Developer Express 2008 or later (or Visual Studio Professional 2008 or later)
2. An instance of SQL Server 2005 (express or full) or later installed locally as instance name "SQLEXPRESS"; if there is a 
local instance with another name, this could also be used by modifying the "tests" project's App.Config file.

### Next steps

* Add "SetUp" and "TearDown" code to NUnit tests to publish and remove the CLR proc.
* Add actual tests to the test class(es)
* Provide a variety of test scenarios (data files?)
