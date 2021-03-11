# BackupAzureTableStorageLocally

A simple console application written in .NET 5.0 to backup tables from within a single Azure storage account and store them locally.

This project uses [TheByteStuff's AzureTableUtilites Nuget Package](https://www.nuget.org/packages/TheByteStuff.AzureTableUtilities/)

## Usage

Run the BackupAzureTableStorageLocally executable using the example below.

```shell
BackupAzureTableStorageLocally.exe "{A1}" "{A2}" "{A3}"

# WHERE PARAMETERS EQUAL
# A1: Azure Storage Connection String
# A2: Local Backup Directory
# A3: Table Names, Delimited by pipes ('|')
```
