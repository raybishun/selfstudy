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

### Resources
1. sweetalert2: A BEAUTIFUL, RESPONSIVE, CUSTOMIZABLE, ACCESSIBLE (WAI-ARIA) REPLACEMENT FOR JAVASCRIPT'S POPUP BOXES with ZERO DEPENDENCIES - https://sweetalert2.github.io/
2. Toasters: Notifications - https://codeseven.github.io/toastr/demo.html
3. DataTables: Plug-in for the jQuery JavaScript library - https://datatables.net/

### Beautify the UI
- Add the below to the '_Layout.cshtml' page

#### CSS
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css" />

#### JavaScript
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
