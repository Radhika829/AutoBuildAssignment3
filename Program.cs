// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AutoBulidAssignment3;
SortedList<int, Product> productList = new SortedList<int, Product>();
productList.Add(3, new Product { PId = 3, PName = "Chocs", PBrand = "DairyMilk", ManufacturingDate = DateTime.Now,
    ExpiryDate = DateTime.Now.AddMonths(6) });
productList.Add(1, new Product { PId = 1, PName = "Biscuits", PBrand = "ParleG", ManufacturingDate = DateTime.Now,
ExpiryDate = DateTime.Now.AddMonths(12) });
productList.Add(2, new Product { PId = 2, PName = "Shampoo", PBrand = "sunsilk", ManufacturingDate = DateTime.Now,
ExpiryDate = DateTime.Now.AddMonths(9) });
productList.Add(4, new Product { PId = 4, PName = "FaceCream", PBrand = "Garneir", ManufacturingDate = DateTime.Now,
ExpiryDate = DateTime.Now.AddMonths(5) });
productList.Add(5, new Product
{
    PId = 5,
    PName = "Sweets",
    PBrand = "Kanti",
    ManufacturingDate = DateTime.Now,
    ExpiryDate = DateTime.Now.AddMonths(10)
});
productList.Add(6, new Product
{
    PId = 6,
    PName = "Books",
    PBrand = "Friends",
    ManufacturingDate = DateTime.Now,
    ExpiryDate = DateTime.Now.AddMonths(12)
});



// Displaying the sorted list
foreach (var product in productList)
{
    Console.WriteLine($"Key: {product.Key}, Product Name: {product.Value.PName}, Brand: {product.Value.PBrand}");
}
    



