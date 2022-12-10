using System;
using TheByteStuff.AzureTableUtilities;

namespace BackupAzureToLocal
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("AZURE TABLE BACKUPS");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            var argsProperlyFormatted = true;

            if (args.Length == 0
                || string.IsNullOrEmpty(args[0])
                || args[0].Trim() == "help"
                || args[0].Trim() == "-help"
                || args[0].Trim() == "--help"
                || args[0].Trim() == "h" 
                || args[0].Trim() == "-h" 
                || args[0].Trim() == "--h"
                || args[0].Trim() == "?"
                || args[0].Trim() == "-?"
                || args[0].Trim() == "--?"
                )
                    argsProperlyFormatted = false;

            if (argsProperlyFormatted && string.IsNullOrEmpty(args[1]))
                argsProperlyFormatted = false;

            if (argsProperlyFormatted && string.IsNullOrEmpty(args[2]))
                argsProperlyFormatted = false;

            if (argsProperlyFormatted && args[2].Split('|', StringSplitOptions.RemoveEmptyEntries).Length == 0)
                    argsProperlyFormatted = false;

            if (!argsProperlyFormatted)
            {
                Console.WriteLine("PROPER USAGE:");
                Console.WriteLine("BackupAzureToLocal.exe \"{A1}\" \"{A2}\" \"{A3}\"");
                Console.WriteLine("A1: Azure Storage Connection String");
                Console.WriteLine("A2: Local Backup Directory");
                Console.WriteLine("A3: Table Names, Delimited by pipes ('|')");
                Console.WriteLine();
                return;
            }

            string azureStorageConfigConnection = args[0];
            string backupDirectory = args[1];
            string[] tables = args[2].Split('|', StringSplitOptions.RemoveEmptyEntries);

            BackupAzureTables backup = new BackupAzureTables(azureStorageConfigConnection);
            foreach (var t in tables)
            {
                Console.WriteLine("BACKING UP AZURE TABLE: " + t);

                string resp = backup.BackupTableToFile(
                    t,
                    backupDirectory,
                    false, 
                    true,
                    600
                );

                Console.WriteLine("RESULT: " + resp);
                Console.WriteLine();
            }

            Console.WriteLine("FINISHED JOB");
        }

    }

}
