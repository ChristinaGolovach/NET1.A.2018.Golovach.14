# NET1.A.2018.Golovach.14

# Задание

1. [Решение](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.14/blob/master/FibonacciLogic/FibonacciNumbers.cs) (deadline - 09.11.2018, 24.00) Реализовать метод-генератор последовательности чисел Фибоначчи. Разработать unit-тесты.
2. (deadline - 10.11.2018, 24.00) Реализовать обобщенный алгоритм бинарного поиска (добавить в проект с методами сортировки). Методы сортировки преобразовать в обобщенные. Разработать unit-тесты.
* [Решение - Сортировки](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.01/blob/master/Logic/Sorting.cs) - [Тесты](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.01/blob/master/Logic.NUnitTests/SortingTests.cs)
* [Решение - Бинарный поиск](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.01/blob/master/Logic/Search.cs) - [Тесты](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.01/blob/master/Logic.NUnitTests/SearchTests.cs)
3. (deadline - 11.11.2018, 24.00) Добавить в статический класс с обобщенными методами-трансформерами обобщенные методы-фильтры (реализовать как методы расширения) получения из набора данных типа TSource набора данных типа TSource, логику попадания в результирующий набор инкупсулировать в функции-предикате (рассмотреть два подхода - объектно-ориентированый и функциональный). В качестве тест-кейсов для метода-фильтра можно использовать, напимер,
    * для строк - соответствие определенном шаблону, соответствие определенной длине и т.д.
    * для целых чисел - наличие определенной цифры в числе, простота, четность и т.д.
* [Решение - Фильтр](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.04/blob/master/TransformLogic/Transform.cs) - [Тесты](https://github.com/ChristinaGolovach/NET1.A.2018.Golovach.04/blob/master/TransformLogic.Tests/TransformTests.cs)
4. (deadline - ) Добавить в класс-сервис для управления банковским счетом возможность логирования информации об исключениях, возникающих при выполнении основых операций с банковским счетом. Продумать возможность (при необходимости) замены одного фреймворка для логирования на другой, а также нсмрользования кастомных классов исключений.
