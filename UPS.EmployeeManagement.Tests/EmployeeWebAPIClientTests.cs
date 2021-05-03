using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using Serilog;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Providers;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Tests
{
    [TestClass]
    public class EmployeeWebApiClientTests
    {
        private readonly EmployeeWebAPIClient employeeWebAPIClient;
        private readonly Mock<ILogger> logger = new Mock<ILogger>();

        public EmployeeWebApiClientTests()
        {
            employeeWebAPIClient = new EmployeeWebAPIClient(logger.Object, "TESTTOKEN");
        }

        [TestInitialize]
        public void Initialise()
        {
        }

        [TestMethod]
        public async Task Should_create_employee_response_for_adding_new_employee()
        {
            var crudEmployeeResponse = new CRUDEmployeeResponse
            {
                code = 200
            };
            var stream = new MemoryStream();
            HttpResponseMessage httpResponseMessage;
            using (var streamWriter = new StreamWriter(stream: stream, encoding: Encoding.UTF8, bufferSize: 4096, leaveOpen: true)) // last parameter is important
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(jsonWriter, crudEmployeeResponse);
                streamWriter.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                var streamContent = new StreamContent(stream);
                httpResponseMessage = new HttpResponseMessage { Content = streamContent };
            }

            var response = await employeeWebAPIClient.CreateEmployeeResponse(httpResponseMessage);

            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public async Task Should_return_error_when_updating_an_employee_that_doesnt_exist()
        {
            var crudEmployeeResponse = new CRUDEmployeeResponse
            {
                code = 404,
                data = new ResponseData { message = "Resource not found" }
            };
            var stream = new MemoryStream();
            HttpResponseMessage httpResponseMessage;
            using (var streamWriter = new StreamWriter(stream: stream, encoding: Encoding.UTF8, bufferSize: 4096, leaveOpen: true)) // last parameter is important
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(jsonWriter, crudEmployeeResponse);
                streamWriter.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                var streamContent = new StreamContent(stream);
                httpResponseMessage = new HttpResponseMessage { Content = streamContent };
            }

            var response = await employeeWebAPIClient.CreateEmployeeResponse(httpResponseMessage);

            Assert.AreEqual(false, response.Success);
            Assert.AreEqual("Resource not found", response.ResponseMessage);
        }
    }
}
