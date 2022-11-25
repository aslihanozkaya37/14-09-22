// See https://aka.ms/new-console-template for more information

using EDbFirst.DAL;
using (var _context=new AppDbContext())
{
    var products = _context.Products.ToList();
    products.ForEach(p =>
    {
        Console.WriteLine($"ÜRÜN ID:{p.id}/Ürün Fiyatı:{p.Price} TL");
    });

}
