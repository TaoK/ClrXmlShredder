
This project serves a couple disparate purposes:

* Provide an illustration of how one might test (and use) the ClrXmlShredder class (CLR proc) from gist https://gist.github.com/1034768
* Provide an illustration of how "User Instances" of SQL Server might be used in test projects to increase packageability and reduce dependencies

The project is just in "first checkin" state, far from useful.

Next steps include:

* Add "SetUp" and "TearDown" code to NUnit tests to publish and remove the CLR proc.
* Add actual tests to the test class(es)
* Provide a variety of test scenarios (data files?)

