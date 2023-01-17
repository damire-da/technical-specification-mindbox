SELECT NameProduct, NameCategory 
FROM Product AS P
LEFT JOIN ProductCategory AS PC ON P.IdProduct=PC.ProductId
LEFT JOIN Category AS C ON PC.CategoryId=C.IdCategory