using Azure.Storage.Blobs;

/*
  
    create a blob container named fileblob and upload some files from a directory    

 */


string conn = "UseDevelopmentStorage=true";
string container = "fileblob";
string folder = @"c:\blob\";

var files = Directory.GetFiles(folder);

BlobContainerClient client = new BlobContainerClient(conn, container);

client.CreateIfNotExists();

foreach (var file in files)
{
    var filePathOverCloud = file.Replace(folder, string.Empty);
    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(file)))
    {
        client.UploadBlob(filePathOverCloud, ms);
        Console.WriteLine($"{filePathOverCloud} uploaded");
    }
}