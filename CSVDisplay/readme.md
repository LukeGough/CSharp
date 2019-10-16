### Task
JMC receives output from many different programs in CSV format you must write a program to display this data.

You need to create a program that uses an external 3rd party library to read and write data to a CSV, as an [example](https://www.codeproject.com/Articles/9258/A-Fast-CSV-Reader) this data must be displayed in a GUI a table.

#### CsvHelper - Third party library
I chose to use the .NET library [CsvHelper](https://joshclose.github.io/CsvHelper/).

#### How I installed the CsvHelper
Following the [Getting Started](https://joshclose.github.io/CsvHelper/getting-started/) page I installed the CsvHelper library via the Package Manager Console using command “Install-Package CsvHelper”.
To bring up the Package Manager Console in Visual Studios
* Menu Tools > NuGet Package Manager > Package Manager Console

#### How I used CsvHelper
I used the CsvHelper in my ReadRecords(), AddRecord() and DisplayRecords() methods.
