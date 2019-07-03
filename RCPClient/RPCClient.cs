using System;

namespace RPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpcClient = new RemoteProcedureCallClient();

            Console.WriteLine(" [x] Requesting fib(30)");
            var response = rpcClient.Call("30");

            Console.WriteLine($" [.] Got '{response}'");
            rpcClient.Close();
        }
    }
}