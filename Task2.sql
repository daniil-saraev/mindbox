SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductsCategories ON (Products.Id = ProductsCategories.ProductId)
LEFT JOIN Category ON (ProductsCategories.CategoryId = Categories.Id)