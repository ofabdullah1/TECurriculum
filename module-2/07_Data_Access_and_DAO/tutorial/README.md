# DAO pattern tutorial

In this tutorial, you'll practice connecting to a database and retrieving data from it in C#. By the end of this tutorial, you'll have written code that:

- Connects to a Microsoft SQL Server database
- Sends SQL queries to the database
- Creates C# objects that correspond to data returned by queries
- Encapsulates the database interactions using the DAO pattern

To get started, open the `DaoTutorial.sln` solution file in Visual Studio.

Expand the `Tutorial` project to see the files included with the starter code. This project also uses the `PizzaShop` database.

## Step One: Configure the database connection

Before the program can connect to the database, you'll need to provide information about the connection called a **connection string**.

Find the first comment in `Program.cs`. The `connectionString` variable is set to an empty string:

```csharp
// Step One: Configure the database connection
string connectionString = "";
```

Replace the empty string with the following string. This contains the database server, database name, and the `Trusted_Connection=True` portion instructs C# to use your Windows credentials to log in to the database:

```csharp
string connectionString = @"Server=.\SQLEXPRESS;Database=PizzaShop;Trusted_Connection=True;";
```

**Note:** Connection strings aren't typically written directly in source code because they usually contain sensitive information like usernames and passwords. Microsoft recommends using `Trusted_Connection=True` but that isn't always an option, especially if you're not using Windows and SQL Server. Even with `Trusted_Connection`, it's best to not store a connection string directly in your code. In the future, you'll learn how to avoid doing this by using environment variables or configuration files.

After adding those lines, run the `Tutorial` project. You'll see one line of output:

```
Total Sales: $0
```

## Step Two: Add SQL for retrieving total sales

Data about the pizza shop's sales is stored in the `sale` table of the database. In the DAO pattern, there are three C# files associated with a database table. For the `sale` table, those three files are:

- `Sale.cs`: a class used for objects that each correspond to a row of the `sale` table
- `ISaleDao.cs`: an interface that specifies the available methods for getting information from the `sale` table
- `SaleSqlDao.cs`: a class that implements the methods specified by the `ISaleDao` interface

All the SQL used to retrieve data from the `sale` table is encapsulated in methods of the `SaleSqlDao` class. Open that class and look at the `GetTotalSales()` method:

```csharp
public decimal GetTotalSales()
{
    decimal totalSales = 0;

    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        // Step Two: Add SQL for retrieving total sales
        SqlCommand cmd = new SqlCommand("SELECT 0;", conn);

        totalSales = Convert.ToDecimal(cmd.ExecuteScalar());
    }

    return totalSales;
}
```

This method follows the typical pattern for retrieving data from a SQL database in C#. The code sets up a connection with a `using` statement, opens that connection, creates a SQL statement in a `SqlCommand` object, and runs it with the `ExecuteScalar()` method. The return value from the `ExecuteScalar()` method contains the data from the first column of the first row of the result set; if the SQL statement returns anything else, it's ignored.

However, this code isn't querying anything in the database because the query is `SELECT 0;` which means the total returned is always zero.

Replace that query with `SELECT SUM(total) FROM sale;`

Run the `Tutorial` project again, and you'll see that the output has changed to this:

```
Total Sales: $1248.80
```

## Step Three: Copy returned values into an object

The `GetTotalSales()` method retrieved a single value from the database, but the query sent to the database in the `GetSale()` method returns an entire row of data. The `CreateSaleFromReader()` method handles creating a `Sale` object from that row of data. But right now, it's returning an empty object.

To set the properties of the object with the values from the row of data, add this code following the "Step Three" comment in `SaleSqlDao.cs`:

```csharp
sale.SaleId = Convert.ToInt32(reader["sale_id"]);
sale.Total = Convert.ToDecimal(reader["total"]);
sale.IsDelivery = Convert.ToBoolean(reader["is_delivery"]);
if (reader["customer_id"] is DBNull)
{
    sale.CustomerId = null;
}
else
{
    sale.CustomerId = Convert.ToInt32(reader["customer_id"]);
}
```

Each line retrieves a value from the `SqlDataReader`, passes it to a conversion method, and sets the return value to the corresponding `Sale` property. Notice that there are different methods to use for each data type: `ToInt32()` for `int` values, `ToBoolean()` for `bool` values, and so on. 

Also notice that the handling of the `CustomerId` property is a little different. Null values in the database get returned as `DBNull`, which isn't the same thing as a C# `null`. Because this value can be null in the database, you need to first check if the value is type `DBNull`. This check is necessary because if you pass `DBNull` to any of the conversion methods, it'll throw an error.

After adding those lines, return to the `Program` class. Following the "Step Three" comment, add this code to the `Run()` method to get a `Sale` object representing the sale with an id of 50, and print it out:

```csharp
Sale sale50 = saleDao.GetSale(50);
Console.WriteLine(sale50);
```

Run the `Tutorial` project again, and you'll see that the output has changed to this:

```
Total Sales: $1248.80
Sale 50: $12.99 (carryout)
```

## Step Four: Add a new DAO method

In addition to the DAO for the `sale` table, this project also contains a DAO for the `customer` table. It also consists of three files: `Customer.cs`, `ICustomerDao.cs`, and `CustomerSqlDao.cs`. You were able to retrieve a `Sale` object based on its id in the `sale` table using the `GetSale()` method of the `ISaleDao` interface, but there's currently no way to retrieve a `Customer` object based on its id in the `customer` table.

To add that capability, begin by updating the `ICustomerDao` interface with a new method declaration following the "Step Four" comment:

```csharp
Customer GetCustomer(int customerId);
```

Remember that interfaces don't normally contain implementations of methods. Interfaces are like contracts, specifying what methods the implementing class—`CustomerSqlDao` in this case—must have. The interface is an important part of the DAO pattern because it helps make code loosely coupled, which facilitates testing and reuse.

Now that you've added the declaration of `GetCustomer()` to the `ICustomerDao` interface, implement the method in the `CustomerSqlDao` class following the "Step Four" comment:

```csharp
public Customer GetCustomer(int customerId)
{
    Customer customer = null;

    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT customer_id, first_name, last_name, street_address, city, " +
                                        "phone_number, email_address, email_offers " +
                                        "FROM customer " +
                                        "WHERE customer_id = @customer_id;", conn);
        cmd.Parameters.AddWithValue("@customer_id", customerId);

        SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            customer = CreateCustomerFromReader(reader);
        }
    }

    return customer;
}
```

Notice that the `WHERE` clause in the SQL query is `customer_id = @customer_id;`. That `@customer_id` is a placeholder for a **parameter**, or a value that's specified when the query is sent to the database. You can see on the next line where `Parameters.AddWithValue()` is passed `"@customer_id"` and `customerId`. This declares `@customer_id` as a parameter for this query and sets its value to the `customerId` that was passed into the `GetCustomer()` method.

Now that the `ICustomerDao` interface offers a `GetCustomer()` method, return to the `Program` class. Add these lines to the `Run()` method to display information about the customer associated with the sale you retrieved data about earlier:

```csharp
Customer customerForSale50 = customerDao.GetCustomer(sale50.CustomerId.Value);
Console.WriteLine($"Customer for that sale was {customerForSale50}");
```

Run the `Tutorial` project again, and you'll see that the output looks like this:

```
Total Sales: $1248.80
Sale 50: $12.99 (carryout)
Customer for that sale was Elenore Mamwell
```

## Step Five: Call a DAO method that returns a `List`

In addition to returning values or single objects, DAO methods frequently return `List`s of objects. You can find an example of this in the `ICustomerDao`, where a `FindCustomersByName()` method is declared. As the comments state, this method returns an `IList` of `Customer` objects for customers whose first name or last name contains the specified search string.

Switch to the `CustomerSqlDao` and look at how that method is implemented. It's similar to the method you added in the previous step, with a few important differences to notice:

- The SQL query has two parameters—`@first_name` and `@last_name`. The values for these parameters are set in the following `AddWithValue()` calls. In this case, the same value is used for both parameters, but that may not always be the case.
- The SQL query uses a `LIKE` for searching, and the `%` symbols are added to the parameter value rather than included in the SQL.
- Since multiple rows of results are expected, a `while` loop is used to iterate through those rows and create a `Customer` object for each.

After reviewing that method, return to the `Program` class and add these lines to the `Run()` method to search for all customers with "Ma" in their first or last name:

```csharp
IList<Customer> matchingCustomers = customerDao.FindCustomersByName("Ma");
Console.WriteLine("All customers with \"Ma\" in their first or last name:");
foreach (Customer customer in matchingCustomers)
{
    Console.WriteLine(customer);
}
```

Run the `Tutorial` project again, and you'll see that the output is now this:

```
Total Sales: $1248.80
Sale 50: $12.99 (carryout)
Customer for that sale was Elenore Mamwell
All customers with "Ma" in their first or last name:
Deanne Mallon
Madge Lampaert
Elenore Mamwell
Brade Glamart
Margaret Peepall
Raquel Marcome
Germana Fenna
```

## Next steps

Now that you've been introduced to the DAO pattern and how it's used to retrieve information from the database, there are many possibilities for further experimentation.

For example, you could add additional methods to the `ISaleDao` or `ICustomerDao` interfaces, like a method for retrieving all the sales associated with a particular customer or a method for retrieving all the customers who want to receive email offers.

You could also add a new DAO for one of the other tables in the `PizzaShop` database. If you chose the `pizza` table, you'd create a `Pizza` class, a `IPizzaDao` interface, and a `PizzaSqlDao` class.

Finally, DAOs aren't limited to retrieving data. You could add methods to these DAOs that send `INSERT`, `UPDATE`, and `DELETE` SQL commands to the database, to enable creating, updating, and removing records.
