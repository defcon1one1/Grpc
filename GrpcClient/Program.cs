using Grpc.Net.Client;
using GrpcService1;
using System.Xml.Linq;
using static GrpcService1.Greeter;

using (var channel = GrpcChannel.ForAddress("http://localhost:5118"))
{
    var client = new GreeterClient(channel);
    var request = new HelloRequest { Name = "Janek" };
    var response = await client.SayHelloAsync(request);
    Console.WriteLine(response.Message);
}