# Controller based web API
A controller based web API program with ASP.NET Core from this [tutorial.](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio)

## To do list
First feature is a to do list that implements CRUD operations.

| API                        | Description	            | Request body | Response body        |
|----------------------------|-------------------------|--------------|----------------------|
| GET /api/todoitems	        | Get all to-do items	    | None	        | Array of to-do items |
| GET /api/todoitems/{id}    | Get an item by ID	      | None	        | To-do item           |
| POST /api/todoitems	       | Add a new item	         | To-do item	  | To-do item           |
| PUT /api/todoitems/{id}    | Update an existing item | To-do item	  | None                 |
| DELETE /api/todoitems/{id} | Delete an item    	     | None	        | None                 |

