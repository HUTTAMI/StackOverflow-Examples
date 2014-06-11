[How to use data templates in ASP.NET razor syntax](http://stackoverflow.com/questions/19220684/how-to-use-data-templates-in-asp-net-razor-syntax)
===============================================

### Summary

Shows how to use DisplayTemplates coupled with the PagedList & PagedList.Mvc libraries.

### Walk-through

1. Load project
2. Enjoy

For simplicity's sake The controllers and views are distilled down to just the necessary components. There is a (pseudo-)service that retrieves the data which is displayed.

### Places to look

* `~/Models/Shared/ProjectVM.cs`  
This is the view model we're working with.
* `~/Views/Shared/Displaytemplates/ProjectVM.cshtml`  
This is the display template for the ProjectVM view model.
* `~/Views/Home/Index.cshtml`  
This is the view for the home page which adds the paged list and displays the template via the `@Html.DisplayFor(x => x.Projects)` helper 

### Credits

Huge thanks to [Troy Goode](http://github.com/TroyGoode) for his work on the [PagedList](https://www.nuget.org/packages/PagedList/) and [PagedList.Mvc](https://www.nuget.org/packages/PagedList.Mvc/) libraries.

### Show your appreciation

Have I helped you? Feel free to flattr me. ;-)

[![Flattr this git repo](http://api.flattr.com/button/flattr-badge-large.png)](https://flattr.com/submit/auto?user_id=bradchristie&url=https://github.com/bchristie/StackOverflow-Examples&title=StackOverflow Examples&language=&tags=github&category=software) 
