/* Есть таблицы: 
Products (
  product_id int,
  product_name text
);

Categories (
  category_id int,
  category_name text
);

Products_Categories( 
  id int,
  category_id -> Categories,
  product_id -> Products,
);

*/

SELECT product_name, category_name FROM Products_Categories
RIGHT JOIN Products ON Products.product_id = Products_Categories.product_id 
LEFT Join Categories ON Categories.category_id = Products_Categories.category_id
