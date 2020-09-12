using Grpc.Net.Client;
using gRPCServer;
using System;
using System.Threading.Tasks;

namespace gRPCConsoleClient
{
class Program
{
    static async Task Main(string[] args)
    {
        var data = new HelloRequest { Name = "Mukesh" };
        var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Greeter.GreeterClient(grpcChannel);
        var response = await client.SayHelloAsync(data);
        Console.WriteLine(response.Message);
        Console.ReadLine();
    }
}
}
