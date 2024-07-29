using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

/*
 Azure Queue Examnple

 
 */

//connect to local Azurite Docker container
string conn = "UseDevelopmentStorage=true";//Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING")"";

//instance queue client
QueueClient queue = new QueueClient(conn, "messagequeue");

//create queue
queue.CreateIfNotExists();

bool running = true;

while(running)
{
    Console.WriteLine("Enter your messages.. q to quit!");
    string input = Console.ReadLine();
   
    if (!string.IsNullOrEmpty(input))
    {
        if(input!="q")
        { 
            //add message to queue
            await queue.SendMessageAsync(input);
        
        }
        else
        {
            running = false;
        }
    }
    else
    {
        running = false;
    }
    Console.Clear();
}