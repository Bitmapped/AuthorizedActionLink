# AuthorizedActionLink
ASP.NET MVC HtmlHelper extensions to generate links or text depending on if user is authorized to use an action.

## What's inside
This project a C# class that extends HtmlHelper to insert links or text based on if a user is authorized to use a specified action. The code is compatible with MVC areas.

## System requirements
1. NET Framework 4
2. ASP.NET MVC 4+

## NuGet availability
This project is available on [NuGet](https://www.nuget.org/packages/AuthorizedActionLink).

## Usage instructions
### Getting started
1. Add **AuthorizedActionLink.dll** as a reference in your project.
2. You must add the `AuthorizedActionLink` namespace in the **web.config** file in your **Views** folder(s) using the line
  ```<add namespace="AuthorizedActionLink" />```
  under the `<system.web.webPages.razor>/<pages>/<namespaces>` section.

### Using in views
The class has two methods which take the same parameters as `ActionLink(...)`:
- `AuthorizedActionLink(...)` (displays nothing if user is unauthorized)
- `AuthorizedActionLinkOrText(...)` (displays link text, not in a link, if user is unauthorized)
 
`ActionIsAccessibleToUser(...)` method returns true/false if user is authorized for specified controller action. This can be useful in determining if larger blocks of text should be displayed.
