# BusReservations_IT
Bus reservations project developed in ASP.NET MVC5

To setup this project after its downloaded, you need to:

1. Then open Web.config and setup your Connection String like in the example shown below.
2. Build&Run the solution and go to /Home/Index route.
3. After the build database should be created.

Example:
```
<connectionStrings>
    <add name="BusReservations"
    providerName="System.Data.SqlClient"
    connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=BusReservations;Integrated Security=True;MultipleActiveResultSets=True"/>  
</connectionStrings>
```
**Data Source="" should be equal to your SQL Server name**
