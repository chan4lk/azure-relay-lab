// See https://aka.ms/new-console-template for more information
using Lab.Relay.Client;
using Microsoft.IdentityModel.Tokens;

Console.WriteLine("Hello, World!");

await new RelayClient().RunAsync();