using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace RestSharpTraining
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrievePosts()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts", Method.GET);
            req.AddQueryParameter("id", "1");
            req.AddHeader("Accept", "application/json");
            IRestResponse rest = client.Execute(req);
            Assert.AreEqual(HttpStatusCode.OK, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<RetrievePostValidResponse[]>
                (response);

            Assert.AreEqual("json-server", responseinCorrectFormat[0].title);

        }

        [Test]
        public void UpdatePost()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts/3", Method.PUT);
            req.AddQueryParameter("id", "4");


            req.AddHeader("Accept", "application/json");

            string body = CreatePostRequestbody(3, "title03", "author03");
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
            RestRequest req = new RestRequest("posts/3", Method.DELETE);
            req.AddQueryParameter("id", "4");


            req.AddHeader("Accept", "application/json");

           IRestResponse rest = client.Execute(req);

            Assert.AreEqual(HttpStatusCode.OK, rest.StatusCode);
         
        }

        [Test]
        public void CreatePost()
        {
            RestClient client = new RestClient("http://localhost:3000");
            RestRequest req = new RestRequest("posts", Method.POST);
            req.AddQueryParameter("id", "4");


            req.AddHeader("Accept", "application/json");

            string body = CreatePostRequestbody(4, "harry potter and goblet", "Rowling");
            req.AddJsonBody(body);

            IRestResponse rest = client.Execute(req);

            Assert.AreEqual(HttpStatusCode.Created, rest.StatusCode);
            string response = rest.Content;

            var responseinCorrectFormat = JsonConvert.DeserializeObject<CreatePostValidResponse>
                (response);

            Assert.AreEqual("harry potter and goblet", responseinCorrectFormat.title);
            Assert.AreEqual("Rowling", responseinCorrectFormat.author);

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