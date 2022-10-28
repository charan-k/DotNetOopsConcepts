using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System.Net;

namespace RestSharpTraining
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       
        [TestCase("nl", "3825", HttpStatusCode.OK, TestName = "Check status code for NL zip code 7411")]
        [TestCase("lv", "1050", HttpStatusCode.NotFound, TestName = "Check status code for LV zip code 1050")]
        public void StatusCodeTest(string countryCode, string zipCode, HttpStatusCode expectedHttpStatusCode)
        {
            // arrange
            RestClient client = new RestClient("http://api.zippopotam.us");
            RestRequest request = new RestRequest($"{countryCode}/{zipCode}", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));
        }

        [TestCase("posts", "2", HttpStatusCode.OK, TestName = "Check Post status code for 4")]
        [TestCase("posts", "7", HttpStatusCode.NotFound, TestName = "Check Post with not found status code")]
        public void RetrievePosts(string posts,string id,HttpStatusCode httpStatusCode)
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest($"{posts}/{id}", Method.GET);

        //    req.AddQueryParameter("id", "2");
        //    req.AddHeader("Accept", "application/json");

            IRestResponse rest = client.Execute(req);
            Assert.AreEqual(httpStatusCode, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<RetrievePostValidResponse>
                (response);

            RetrievePostValidResponse locationResponse =
        new JsonDeserializer().Deserialize<RetrievePostValidResponse>(rest);

            Assert.AreEqual("origin of species", responseinCorrectFormat.title);
            Assert.AreEqual("application/json; charset=utf-8", rest.ContentType);

        }

        [Test]
        public void RetrievePosts()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts/2", Method.GET);

            //    req.AddQueryParameter("id", "2");
            //    req.AddHeader("Accept", "application/json");

            IRestResponse rest = client.Execute(req);
            Assert.AreEqual(HttpStatusCode.OK, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<RetrievePostValidResponse>
                (response);

            RetrievePostValidResponse locationResponse =
        new JsonDeserializer().Deserialize<RetrievePostValidResponse>(rest);

            Assert.AreEqual("origin of species", responseinCorrectFormat.title);
            Assert.AreEqual("application/json; charset=utf-8", rest.ContentType);

        }

        [Test]
        public void UpdatePost()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts/4", Method.PUT);
         //   req.AddQueryParameter("id", "4");


            req.AddHeader("Accept", "application/json");

            string body = CreatePostRequestbody(4, "title03", "author03");
            req.AddJsonBody(body);

            IRestResponse rest = client.Execute(req);

            Assert.AreEqual(HttpStatusCode.OK, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<UpdatePostValidResponse>
                (response);

            Assert.AreEqual("title03", responseinCorrectFormat.title);
            Assert.AreEqual("author03", responseinCorrectFormat.author);

        }

        [Test]
        public void DeletePost()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts/4", Method.DELETE);
         //   req.AddQueryParameter("id", "4");

        
            req.AddHeader("Accept", "application/json");

           IRestResponse rest = client.Execute(req);

            Assert.AreEqual(HttpStatusCode.OK, rest.StatusCode);
         
        }

        [Test]
        public void CreatePost()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts", Method.POST);


            req.AddHeader("Accept", "application/json");

            string body = CreatePostRequestbody(4, "autobiography", "nirad chowdary");
            req.AddJsonBody(body);

            IRestResponse rest = client.Execute(req);

            Assert.AreEqual(HttpStatusCode.Created, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<CreatePostValidResponse>
                (response);

            Assert.AreEqual("autobiography", responseinCorrectFormat.title);
            Assert.AreEqual("nirad chowdary", responseinCorrectFormat.author);
        }

        private string CreatePostRequestbody(int id,string title,string author)
        {
            CreatePostValidRequest body = new CreatePostValidRequest
            {
                id = id,
                title = title,
                author = author
            };
            return JsonConvert.SerializeObject(body);
        }


    }
}