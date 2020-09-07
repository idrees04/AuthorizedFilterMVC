# AuthorizedFilterMVC
Authorization FILTERS IN ASP.NET MVC 5
1.	Authorization is the process of verifying whether an authenticated user has the privilege to access a requested resource.
2.	Authentication is the process of validating the identity of a user before granting access to a restricted resource in an application.
3.	When the application receives a request from users, it tries to authenticate the user.
4.	Typically, authentication allows identifying an individual based on the username and password provided by the user.
5.	Authorization filters execute before an action method is invoked to make security decisions on whether to allow the execution of the action method or not.
6.	In ASP.NET MVC Framework, the Authorize Attribute class of the System.Web.Mvc namespace is an example of authorization filters.
7.	This class extends the FilterAttribute class and implements the IAuthorizationFilter interface.
8.	The authorization filter allows you to implement standard authentication and authorization functionality in your application.
9.	You can use the web.config file to specify the page to be displayed for user authentication.
10.	The <forms> element specifies the login URL for the application.
11.	Whenever a user tries to access a restricted resource, the user is redirected to the login URL.
12.	The timeout attribute of the <forms> element specifies the amount of time in minutes, after which the authentication cookie expires. Its default value is 30 minutes.
