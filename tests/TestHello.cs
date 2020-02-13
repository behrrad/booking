using System;
using Xunit;
using RA;
namespace tests
{
    public class TestHello
    {
        [Fact]
        public void TestHelloEndpoint()
        {
            new RestAssured()
            .Given()
             .Name("Test Hello")
             .Header("Content-Type", "application.json")
             .Header("Accept Encoding", "utf-8")
            .When()
             .Get("https://localhost:5000/hello")
             .Then()
             .TestStatus("test hello", r => r == 200)
             .TestBody("test body", b => b.response == "Hello World")
             .Assert("Test body")
             .Assert("test hello");
        }
    }
}
