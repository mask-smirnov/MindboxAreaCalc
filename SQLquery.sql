-- � ���� ������ MS SQL Server ���� �������� � ���������. ������ �������� ����� ��������������� ����� ���������, 
-- � ����� ��������� ����� ���� ����� ���������. �������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� 
-- ���������. ���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.

-- ��������������� ����� ��������� ������:
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

-- ����� ������ ����� �����:
SELECT Product.Id, ProductCategory.CategoryId FROM Product
LEFT OUTER JOIN ProductCategory ON ProductCategory.ProductId = Product.Id
