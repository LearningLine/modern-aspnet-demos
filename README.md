# modern-aspnet-demos
Modern ASP.Net Demos
Welcome to DevelopMentor's  demos repository for our Modern ASP..NET Training Course.

If you are in this course right now, start by selecting your course's branch and then just click 'Download ZIP' or clone this repo to your system. On the other hand, if you took my course awhile ago and want access to the demos, your course has probably been moved to another branch. Use the branches dropdown to find it just contact me (email address is listed in my github profile).

If you are not in one of our courses, enjoy the samples and please consider DevelopMentor for your ASP.Net Training!

Cheers, @DevelopMentor_ - https://www.develop.com/

Modern ASP.NET is an examination of Microsoft’s latest web development framework. This course focuses on Microsoft’s “One ASP.NET” strategy for a unified framework for architecting web applications. You will learn about MVC for building HTML based applications, OWIN and Katana for providing a common HTTP hosting infrastructure, ASP.NET Identity for securing user identities, Web API for building modern web services and SignalR for providing real-time push notifications to client applications. Come and explore Microsoft’s compelling server-side stack for developing modern web applications and services.

Course highlights

You'll get answers to these questions:

What is MVC and how to properly utilize the MVC pattern?
What are controllers and actions, how do they get invoked and how do they accept input?
How do I write views using Razor to render HTML dynamically?
How can I build validation into my application?
How can I use jQuery and Ajax with MVC and Web API?
How can I secure my web applications?
How does SignalR provide real-time push notifications to the browser?
Come and learn to build great web applications using ASP.NET!

Course outline and topics

Day 1


MVC Introduction
This module provides an introduction to the ASP.NET MVC framework. We will provide an overview of the MVC architecture including how a controller processes requests, communicates with the model layer and chooses a view to generate a response. Part of this overview will include looking at URL routing, model binding and the Razor view engine.

MVC Actions 
Controllers and actions are the centerpiece of an MVC application. In this module we will examine the look at how requests utilize attribute routing to map onto action methods. We will also explore the various action results which are used to generate a response.

MVC Views 
In this module we will examine Razor which is the view engine used in MVC. It is designed to provide a streamlined syntax for creating dynamic views. This module covers the Razor syntax and its support for reusable templates with partial views and layout templates. We will conclude with Html helpers, which are APIs to encapsulate rendering common markup such an input fields, hyperlinks, forms and URLs.

Day 2


MVC Model Binding
Model binding is an important part of the MVC framework to ease input processing for controllers. We will see how data is mapped from the request to parameters of action methods and how complex objects can also be model bound.


MVC Validation
In this module we examine how MVC provides a complete framework for validation. We’ll see how it uses validation helpers, ModelState, data annotations and the IValidatableObject interface to provide server-side validation. Then we will illustrating how MVC’s validation framework can also be used to perform client-side validation.


OWIN and Katana
OWIN is a fairly new specification for modelling a HTTP server API for hosting web applications. The intent is to decouple the host from the application with the goal of providing a simpler programming model with potentially better performance than traditional web servers. While OWIN is a specification, Katana is Microsoft’s implementation of an OWIN host. In this session we will discuss OWIN, Katana and how to write applications and middleware that take advantage of this new and exciting hosting environment.

Day 3


MVC Security
Security is crucial for online applications. This session on security discusses the basics of web security and then the internals of authentication in Microsoft’s OWIN framework called Katana. We will see how the new cookie authentication middleware manages user authentication and supports rich identity information using claims. We will then examine how external authentication is implemented for social media logins such as Google and Facebook. We conclude with MVC’s authorization support using authorization filters.


ASP.NET Identity
Identity management is the unglamorous (yet extremely important) task of managing account information for users (including passwords). Identity management in ASP.NET has had an interesting and somewhat tumultuous history, but in this session we will focus on Microsoft’s newest framework called ASP.NET Identity. We will discuss the important characteristics of proper identity management and then we’ll survey the pros and cons of ASP.NET Identity. We will see how ASP.NET Identity provides support for password management, claims-based identity, external login providers, custom validation as well as customized storage.

jQuery
jQuery is a popular open source JavaScript library used to enhance AJAX style web pages and improve developer productivity. jQuery was chosen by Microsoft as the library for MVC’s client-side capabilities. In this module we will introduce the query and document manipulation capabilities of jQuery.

Day 4


Ajax
Ajax is a style of writing browser-based application to leverage JavaScript and XmlHttpRequest callbacks to the server. This lecture covers MVC’s basic support for Ajax as well as using jQuery to develop more sophisticated Ajax applications.



Web API

This module provides an introduction to Web API which is the new framework for building HTTP-based RESTful services. We will cover the motivation for HTTP oriented services as an alternative to SOAP-based services. We’ll examine the major tenets including the importance of URIs, HTTP methods and status codes, content negotiation and hypermedia. We’ll conclude with the new client-side programming model for HTTP services with the HttpClient API.

Web API Security

Web API is the framework for building HTTP-based services and these services will need to be secured. This session introduces how security (confidentiality, integrity and authentication) is typically performed for HTTP-based services. We’ll also look at the modern approaches to authentication and authorization using OAuth and how to implement these approaches in your Web API application using Microsoft’s Katana authentication middleware. Once authentication has been established we'll then turn to authorization and how you can control access to the resources your Web API is exposing.

Day 5


Knockout

Knockout is Microsoft’s unofficial client-side JavaScript framework for building client-side applications. Its main feature is its two-way data binding support. This allows developers to be more productive when building rich browser-based applications.

SignalR

SignalR is a framework that makes developing real-time web functionality easy. SignalR allows bi-directional communication between server and client. Servers can now push content to connected clients instantly as it becomes available. In this module we will see how to build hubs to model communication endpoints and how those can communicate to all connected clients. We’ll also look at some of the other features of SignalR including connection management, grouping connections, and authorization.

Appendices


Appendix: Asynchronous Controllers

Scalability is an ever important deign goal. MVC assists the developer designing for throughput in an application with asynchronous controllers.


Appendix: Custom Model Binding

Model binding can be customized. This allows for developers to customize what data will be used for model binding and control how the format of that data is converted to an object model.

Appendix: Custom Validation Providers

The validation framework of MVC can be customized. The source of metadata used for validation can be customized as well as the client-side JavaScript that is rendered to perform validation.

Appendix: Dependency Injection

In this module we discuss designing for testability by decoupling layers of your application using dependency injection. We will use Microsoft's Inversion of control container (called Unity) to manage and create dependent objects in our application. We'll also look at MVC3's native support for dependency injection and how to utilize it.

Appendix: Organizing Code

This module examines areas which is a feature in MVC to organize and segregate the development of discrete features of an application. This is ideal for different groups working on different features on a single web application. We also look into customizing the built-in view engines from MVC so that we can organize our code and files within our projects.

Appendix: Extending jQuery

jQuery is designed for extensibility. In this module we will see how a custom plug-in can be developed for jQuery.


Appendix: IIS 7

In order to understand MVC it's important to understand the web server in which you will be hosting your application. This module covers the architecture of Internet Information Server 7 (IIS 7) which is Microsoft's latest version of its web server product.


Appendix: URL Routing

URL Routing allows application developers fine grained control over URLs and how they are processed by application code. In this lecture we will discuss defining routes and route handlers at the IIS level and examine how requests are dispatched.

Appendix: Localization

Localization is the process of translating an application for different languages and cultures. In this lecture, we will discuss how to use the localization features of the .NET framework to localize our MVC applications.

Appendix: Mocking & Testing MVC

Unit testing is one of the main motivators for MVC. This module discusses strategies for unit testing your code. We will see using a mocking framework to implement fakes for testing as well as developing helper libraries for common tasks while unit testing.


Appendix: Template Helpers

Template helpers are a feature that provides an abstraction layer for rendering data. It allows rendering based upon data type or other metadata. We'll see how to control this rendering and how to customize it.


Appendix: Unit Testing with Visual Studio

Unit testing is one of the main motivators for MVC. In this module we will see the basics of writing unit tests using Microsoft's unit testing framework.


Appendix: Unity

In this module we'll use Microsoft's Inversion of control container (called Unity) to manage and create dependent objects in our application (via dependency injection).

Appendix: WebForms View Engine

MVC allows for componentization and reuse of rendering logic with partial views and master pages. Both of these features leverage features from traditional ASP.NET WebForms (user controls and master pages), but the context is entirely different. We'll see how they are properly utilized in MVC.

Appendix: Windows Identity Foundation

Microsoft has released a new framework called WIF (Windows Identity Foundation) for identity management. It supports an enhanced authorization model that uses claims and the ability to federate authentication for single sign on scenarios.
