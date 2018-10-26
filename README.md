# nunit.runner [![Build Status](https://travis-ci.com/qakit/nunit.runner.svg?branch=master)](https://travis-ci.com/qakit/nunit.runner)
dotnet tool for running nunit test based on NUnitlite framework (https://github.com/nunit/nunit/tree/master/src/NUnitFramework/nunitlite) as a replace for dotnet test cmd which is slow and can't produce on-the-fly output for tests (especially in teamcity)

## installation and usage

install using dotnet tool from nuget (https://www.nuget.org/packages/nunit.runner/)
```console
dotnet tool install -g nunit.runner
```

run your tests using nunit.runner
```console
nunit.runner testassembly.dll
```

also you can filter/run tests from specific category/method. or show output for teamcity 
```console
nunit.runner testassembly.dll --teamcity --where cat=Smoke
```
for test selection language see https://github.com/nunit/docs/wiki/Test-Selection-Language

