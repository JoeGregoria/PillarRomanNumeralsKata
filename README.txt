This is Joe Gregoria's implementation of the Roman Numerals Kata
Submitted to Pillar Technology Group, per http://info.pillartechnology.com/kata/appdev

To build and run this project on Windows (Win10 tested), Linux (Mint 18 tested), or MacOS (not tested):

1) If you don't have a copy of the .NET Core SDK (that is, "dotnet --version" doesn't work), 
   download and install the .NET Core SDK framework from microsoft. 
   For a windows system, the link is https://www.microsoft.com/net/core, then select your OS
2) To build, go to the main directory, where the PillarRomanNumeralsKata.sln lives, and execute these two commands:
     dotnet restore
     dotnet build
3) To run the unit tests, from the same directory, cd to the subdirectory ".\test", and type:
     dotnet test 
4) To run a command-line version of the program, where you can enter either arabic numbers or roman numerals, go to the .\src direcotry, and type:
     dotnet run 123
   --or--
     dotnet run CXXIII
