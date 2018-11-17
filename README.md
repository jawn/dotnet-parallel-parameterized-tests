
Inspired by this tweet https://twitter.com/jawndotnet/status/1057600156550549504

Requirements:

- [x] Run in .NET Framework (optionally .NET core)
- [x] Tests are parameterized.
- [x] Run tests in parallel in the ReSharper Test runner.
- [ ] Run tests in parallel in the Visual Studio Test runner. **Bug** https://github.com/nunit/nunit3-vs-adapter/issues/563
- [ ] Tests could be data driven.
- [ ] Be able to run parameterized variations of the same test in parallel.


Observations:
* NUnit 3: supported 🎉
* MSTest V2: not supported yet, RFC 🗨️at https://github.com/Microsoft/testfx-docs/blob/master/RFCs/007-DataSource-Attribute-VS-ITestDataSource.md
* xunit :  🛑 not supported by design.  potentially supported by extensibility.
