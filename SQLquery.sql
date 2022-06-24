-- В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
-- в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя 
-- категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

-- Подразумевается такая структура таблиц:
CREATE TABLE Product (
    Id INT NOT NULL 
);

CREATE TABLE Category (
    Id INT NOT NULL 
);

CREATE TABLE ProductCategory (
    ProductId INT NOT NULL,
    CategoryId INT NOT NULL
);

-- Тогда запрос нужен такой:
SELECT Product.Id, ProductCategory.CategoryId FROM Product
LEFT OUTER JOIN ProductCategory ON ProductCategory.ProductId = Product.Id
