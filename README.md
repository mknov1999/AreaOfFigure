
##**Задача 1** 
C# библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Дополнительно к задаче: 

- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

###**Решение:**

Откройте файл Geometry.sln

##**Задача 2**
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

###**Решение:**

1. Так как в бд уже существуют таблицы продуктов и категорий, теперь нам нужно создать таблицу посредник для установления связей между продуктами и категориями.
2. По задаче четкого наименования таблиц нету(как и параметров), поэтому пусть таблица продуктов в бд SQL будет - Product с параметрами: Id, Name, а таблица категорий будет иметь имя - Category с параметрами: Id, Name

Пример таблиц Product и Category:

``` sql
CREATE TABLE Product 
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(50)	
);

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	Name NVARCHAR(50)	
);
```
Далее в бд создадим некую таблицу ProductCategoryс параметрами: ProductId(id из Product), CategoryId(id из Category)

```sql
CREATE TABLE ProductCategory (
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
);
```
И собственно запрос будет выглядить следующим образом:

``` sql
SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory .ProductId
LEFT JOIN Category ON ProductCategory .CategoryId = Category.Id
```