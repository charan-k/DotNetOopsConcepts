using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace APIAutomationUsingHttpClient
{
    public class Tests
    {
        private string geturl = "http://localhost:3000/posts/";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllPosts()
        {
            HttpClient httpClient = new HttpClient();

            //Create Request and execute it

            Task<HttpResponseMessage> httpResponseMessage = httpClient.GetAsync(geturl);
            HttpResponseMessage httpResponse = httpResponseMessage.Result;

            Console.WriteLine(httpResponse.ToString());

            //Status code
            HttpStatusCode statusCode=httpResponse.StatusCode;

            Console.WriteLine("Status Code=>"+statusCode);
            httpClient.Dispose();

            //Response data

            HttpContent httpContent = httpResponse.Content;
            Task<string> responsedata = httpContent.ReadAsStringAsync();
            string data = responsedata.Result;
            Console.WriteLine(data);

        }

        [Test]
        public void GetAllPostsInJsonFormat()
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            requestHeaders.Add("Accept", "application/json");

            //Create Request and execute it

            Task<HttpResponseMessage> httpResponseMessage = httpClient.GetAsync(geturl);
            HttpResponseMessage httpResponse = httpResponseMessage.Result;

            Console.WriteLine(httpResponse.ToString());

            //Status code
            HttpStatusCode statusCode = httpResponse.StatusCode;

            Console.WriteLine("Status Code=>" + statusCode);
            httpClient.Dispose();

            //Response data

            HttpContent httpContent = httpResponse.Content;
            Task<string> responsedata = httpContent.ReadAsStringAsync();
            string data = responsedata.Result;
            Console.WriteLine(data);

        }
        [Test]
        public void CreatePosts()
        {
            var endpoint = new Uri(geturl);
            var post = new CreatePostValidRequest
            {
                id = 7,
                title = "origin of species",
                author = "charles dickens"
            };

            var postjson = JsonConvert.SerializeObject(post);
            var payload = new StringContent(postjson, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();


            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync(endpoint, payload);
         
            HttpResponseMessage httpResponse = httpResponseMessage.Result;

            Console.WriteLine(httpResponse.ToString());


            //Status code
            HttpStatusCode statusCode = httpResponse.StatusCode;

            Console.WriteLine("Status Code=>" + statusCode);

            Assert.AreEqual(HttpStatusCode.Created, statusCode);



            //Response data

            HttpContent httpContent = httpResponse.Content;
            Task<string> responsedata = httpContent.ReadAsStringAsync();
            string data = responsedata.Result;
            Console.WriteLine(data);

            var responseinCorrectFormat = JsonConvert.DeserializeObject<CreatePostValidResponse>
              (data);

            Assert.AreEqual("origin of species", responseinCorrectFormat.title);
            httpClient.Dispose();

        }

        [Test]
        public void DeletePosts()
        {
            var endpoint = new Uri(geturl);

            HttpClient httpClient = new HttpClient();

            Task<HttpResponseMessage> httpResponseMessage = httpClient.DeleteAsync(endpoint + "/7");

            HttpResponseMessage httpResponse = httpResponseMessage.Result;

            Console.WriteLine(httpResponse.ToString());


            //Status code
            HttpStatusCode statusCode = httpResponse.StatusCode;

            Console.WriteLine("Status Code=>" + statusCode);

            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            httpClient.Dispose();
        }

        [Test]
        public void UpdatePosts()
        {
            var endpoint = new Uri(geturl);
            var put = new CreatePostValidRequest
            {
                id = 7,
                title = "origin of species",
                author = "charles darwin"
            };

            var putjson = JsonConvert.SerializeObject(put);
            var payload = new StringContent(putjson, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();


            Task<HttpResponseMessage> httpResponseMessage = httpClient.PutAsync(endpoint+"/7", payload);

            HttpResponseMessage httpResponse = httpResponseMessage.Result;

            Console.WriteLine(httpResponse.ToString());

            //Status code
            HttpStatusCode statusCode = httpResponse.StatusCode;

            Console.WriteLine("Status Code=>" + statusCode);

            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            //Response data

            HttpContent httpContent = httpResponse.Content;
            Task<string> responsedata = httpContent.ReadAsStringAsync();
            string data = responsedata.Result;
            Console.WriteLine(data);

            var responseinCorrectFormat = JsonConvert.DeserializeObject<CreatePostValidResponse>
              (data);

            Assert.AreEqual("charles darwin", responseinCorrectFormat.author);
            httpClient.Dispose();

        }
    }
}