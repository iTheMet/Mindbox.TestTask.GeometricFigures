# Mindbox - Тестовое задание
## Задание 1 - Геометрические фигуры


Описание задания:

>Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
>Дополнительно к работоспособности оценим:
>
>- Юнит-тесты
>
>- Легкость добавления других фигур
>
>- Вычисление площади фигуры без знания типа фигуры в compile-time
>
>- Проверку на то, является ли треугольник прямоугольным
<br>

Разработанный проект делится на 3 части:
* Библиотека фигур
* xUnit тесты этой библиотеки
* Консольное приложение для выполнения доп. задач


### Библиотека
В ходе выполнения задания были созданы 3 интерфейса:
- [IFigure](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFigures/FigureInterfaces/IFigure.cs) - От которого наследуются все прочие интерфейсы фигур<br> *(благодаря чему реализуется второе доп. задание)*
- [ITriangle](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFigures/FigureInterfaces/ITriangle.cs) - Интерфейс для всех треугольников, наследующий IFigure
- [ICircle](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFigures/FigureInterfaces/ICircle.cs) - Интерфейс для всех кругов, также наследующий IFigure </br>*(В отличии от интерфейса треугольников, внутри этого интерфейса не было добавлено ничего нового, однако этот интерфейс нужен для возможной последующей модификации)*

А также 2 класса фигур:
- [Triangle](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFigures/Figures/Triangle.cs) - Класс треугольника
- [Circle](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFigures/Figures/Circle.cs) - Класс круга

### Тесты
Были созданы 2 класса тестов:
- [TriangleTest](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFiguresUnitTests/TriangleTest.cs) - Тесты для класса треугольника
- [CircleTest](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/GeometricFiguresUnitTests/CircleTest.cs) - Тесты для класса круга


### Консольное приложение
Нужно для выполнения доп. задания №3. 


Приложение делится на 2 класса:
- [Program](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/ConsoleApp/Program.cs) - Точка входа в приложение
- [AreaCalculator](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/blob/main/ConsoleApp/AreaCalculator.cs) - Имеет 1 метод, возвращающий площадь не предопределённой фигуры, принимающий интерфейс IFigure как параметр.

После запуска консольное приложение ожидает от пользователя выбора фигуры, площадь которой нужно вернуть. Что бы выбрать фигуру нужно ввести в консоль номер это фигуры.
</br></br>

## Задание 2 - SQL
</br>

Описание задания:
>В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

[Готовый SQL файл](https://github.com/iTheMet/Mindbox.TestTask.GeometricFigures/commit/5c210941a70bc841d6fee837ce54fe1c37ed147b) лежит в корне проекта.

Исходя из задания предполагается, что существует 3 таблицы:
- **products** с колонками ***product_id*** и ***product_name***, которая содержит информацию о продуктах
- **categories** с колонками ***category_id*** и ***category_name***, которая содержит информацию о категориях
- **products_and_categories** с колонками ***product_id*** и ***category_id***, в которой обе предыдущие колонки объединены связью многие со многими


Для решения задания требуется соединить третью таблицу с двумя предыдущими через **LEFT JOIN** что бы вместо **id** отображались имена. Благодаря тому, что выбран именно **LEFT JOIN**, выполняется условие из последнего абзаца задания, так как даже если у продукта нет ни одной категории, он всё равно будет выведен.

