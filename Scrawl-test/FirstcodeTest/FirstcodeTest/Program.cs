// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Hello, World!");

public class DbContext1: DbContext
{
    DbSet<Product> Products;
    DbSet<Customer> Customers;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-DSIGTHM\SQLEXPRESS;database=myDb;trusted_connection=true;");
    }
}
public class Product
{
    public int id;
    public string name;
    public float price;
    public string description;
    public DateTime dateimport;
}
public class Customer
{
    public int id;
    public string name;
    public string surname;
   
}