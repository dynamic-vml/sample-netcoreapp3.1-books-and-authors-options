# Books and authors (simple)

This is a sample application for the [Dynamic View-Model Lists (DynamicVML)](https://dynamic-mvl.github.io/) Razor Components Library (RCL).

The Dynamic View Model Lists library is a templating engine to render dynamic item lists in ASP.NET. 
A dynamic list is a list inside an HTML form where the user can add new items to a list after the page
has been rendered. In ASP.NET, the default model binder makes certain assumptions to determine the name
of the fields in the form and how they should be posted back to the server. Using this library, those
assumptions are always fulfilled and your forms posted correctly.

This sample application demonstrates how to consume the DynamicVML RCL from a .NET Core App 3.1
application running ASP.NET MVC for presentation and Entity Framework Core for persistence. It
consists of a simple CRUD example where you can list, add, edit, and delete book authors and
include details about the books they have written. The books are added and removed from the
CRUD pages using DynamicVML.

This version of the sample application shows how to customize the layouts of the lists and how to 
create view models for display options associated with each item in a list, e.g., Bootstrap Card
titles and subtitles.


Project: https://github.com/dynamic-mvl/dvml

Website: https://dynamic-mvl.github.io/
