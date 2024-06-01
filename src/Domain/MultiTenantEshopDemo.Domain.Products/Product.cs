using System;
namespace MultiTenantEshopDemo.Domain.Products;

public class Product
{
    public Guid Id { get; protected set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Image { get; set; }
}