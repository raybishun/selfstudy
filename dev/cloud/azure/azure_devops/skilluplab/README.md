# RazorBooks App Notes

### Required NuGet Packges
1. Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (allows web pages to be refreshed)
2. Microsoft.EntityFrameworkCore
3. Microsoft.EntityFrameworkCore.SqlServer
4. Microsoft.EntityFrameworkCore.Tools (perform DB migration operations)

### Migrations (from the Package Manager Console)
```
Add-Migration CreateRazorBooksDB (creates RazorBooksDB, using name in constr, and the Book table)
Update-Database
```

### EF Tips
1. If/when you modify a model, you must add a migration
2. Then verify then change in your table
```
Add-Migration Added_ISBN_Prop_to_Book_Model
Update-Database
```

### VS Tips
1. Ctrl + KD to align code