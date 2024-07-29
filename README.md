# C# Cloud Azure Blob, Table, Queue Sample Code

## Learning Objectives

- Understand how to create an Azurite container in Docker to simulate Azure features
- Understand code to interact with Azure Tables, Queues, Blobs

## Instructions

1. Fork this repository
2. Clone your fork to your machine
3. Pull an Azurite image: `docker pull mcr.microsoft.com/azure-storage/azurite`
4. Execute: `docker run -p 10000:10000 -p 10001:10001 -p 10002:10002 mcr.microsoft.com/azure-storage/azurite`
5. Install the [Microsoft Azure Storage Explorer](https://azure.microsoft.com/en-us/products/storage/storage-explorer/)
3. Now connect to the container using [Microsoft Azure Storage Explorer]()

## Exercise

- Examine each project in this solution, investigate the code and understand how it interacts with the Azurite container
- Use the Microsoft Azure Storage Explorer to interact with the Azurite container

## Notes
- Further information about the [Microsoft Azurite Storage Emulator](https://learn.microsoft.com/en-us/azure/storage/common/storage-use-azurite?tabs=visual-studio%2Cblob-storage)
- Lots of Azure code can be found on the official repository [Azure SDK for .Net](https://github.com/Azure/azure-sdk-for-net)
- A queue can be 500 TB in size and process 2000 items per second
