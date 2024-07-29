
using Azure.Data.Tables;
using Azure.Data.Tables.Models;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using workshop.models;

/*

 Simple code to create an Azure table and insert some data

 */



//create a TableClient instance passing in connection string and tablename
TableClient client = new TableClient("UseDevelopmentStorage=true", "cars");
TableItem table = client.CreateIfNotExists();

Console.WriteLine($"The table's name is {table.Name}.");

//create an Car instance which we will transfer to the table
Car mini = new Car() { Make = "Mini", Model = "Clubman" };

//create a TableEntity passing in the PartitionKey and RowIndex
string rowKey = Guid.NewGuid().ToString("N"); //generating a new guid each time prevents a duplicate key when re running this code
string partitionKey = "General";

var carEntity = new TableEntity(partitionKey, rowKey)
{
    { "Make", mini.Make },
    { "Model", mini.Model }
  
};


Console.WriteLine($"{carEntity.RowKey}: {carEntity["Make"]} {carEntity["Model"]}");

//add to our Azure table so now we have four columns in our table, the PartitionKey, RowIndex, Make, Model
client.AddEntity(carEntity);

