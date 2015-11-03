# SelfHostedWebAPI
Demonstrates a self hosted WebAPI Controller inside a WIndows Console Application

#Notes 

      localhost:8085 is your specific deployment host and port number.

	  Choose another host in Program.cs if that is not available on your
	  machine.
	  
      I am using Fiddler for the composition of the HTTP Requests. 
      Go to View->Composer (F9)

#Help Links

	Microsoft ASP.NET Web API 2.2 Self Host 5.2.3
	https://www.nuget.org/packages/Microsoft.AspNet.WebApi.SelfHost/
	
	Self-Host ASP.NET Web API
	http://www.asp.net/web-api/overview/older-versions/self-host-a-web-api
	
	  
#Requests for Products (ProductController)

**Http GET request**

	GET http://localhost:8085/api/products HTTP/1.1
	User-Agent: Fiddler
	Host: localhost:8085

**Expected Response**

	HTTP/1.1 200 OK
	Content-Length: 39
	Content-Type: application/json; charset=utf-8

	[{"Id":1,"Name":"Movie","Price":10.99}]
