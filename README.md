
Inspired by this tweet https://twitter.com/jawndotnet/status/1057600156550549504

Requirements:

- [x] Run in .NET Framework (optionally .NET core)
- [x] Tests are parameterized.
- [x] Run tests in parallel.
- [x] Be able to run parameterized variations of the same test in parallel.
- [x] Can run a single test variation from the Visual Studio test runner
- [ ] Tests could be data driven.



Observations:
* NUnit 3: supported 🎉. Caveat: https://github.com/nunit/nunit/issues/2574
* MSTest V2: not supported yet, RFC 🗨️at https://github.com/Microsoft/testfx-docs/blob/master/RFCs/007-DataSource-Attribute-VS-ITestDataSource.md
* xunit :  🛑 not supported by design.  potentially supported by extensibility.
