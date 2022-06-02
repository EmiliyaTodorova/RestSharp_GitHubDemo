
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("https://api.github.com");
client.Authenticator = new HttpBasicAuthenticator("emiliyatodorova", "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");
var request = new RestRequest("/repos/emiliyatodorova/postman/issues", Method.Post);
//string url = "/repos/emiliyatodorova/postman/issues";
//var Issues_request = new RestRequest(url);
//var Issues_response = await client.ExecuteAsync(Issues_request);
request.AddBody(new { title = "New Issue from RestSharp" });
//request.AddUrlSegment("user", "emiliyatodorova");
//request.AddUrlSegment("repos", "postman");
var response = await client.ExecuteAsync(request, Method.Post);
//var repos = JsonSerializer.Deserialize<List<Repo>>(response.Content);
//var issues = JsonSerializer.Deserialize<List<Issue>>(Issues_response.Content);

//foreach (var repo in repos)
//{
//    Console.WriteLine("REPO FULL NAME: " + repo.full_name);
//    Console.WriteLine("REPO ID: " + repo.id);
//    Console.WriteLine("REPO HTML_URL: " + repo.html_url);
//    Console.WriteLine("Issues_Count: " + issues.Count);
//foreach (var issue in issues)
//{
//    Console.WriteLine("Issues_Number: " + issue.number);
//    Console.WriteLine("Issues_iD: " + issue.id);
//}


