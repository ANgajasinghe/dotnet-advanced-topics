using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services
{
    // Greeter.GreeterBase -> This is a design and generated file, This will regenerate every time we build the project
    
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}