# BackupAzureTableStorageLocally

A simple console application written in DOTNET 6.0 to backup tables from within a single Azure storage account and store them locally.

This project uses [TheByteStuff's AzureTableUtilites Nuget Package](https://www.nuget.org/packages/TheByteStuff.AzureTableUtilities/)

## Usage

Run the BackupAzureTableStorageLocally utility using the example below.

```shell
cd source
dotnet build
dotnet run "{1}" "{2}" "{3}"

# WHERE PARAMETERS EQUAL
# 1: Azure Storage Connection String
# 2: Local Backup Directory
# 3: Table Names, Delimited by pipes ('|')
```
