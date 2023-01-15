**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

["hello", "world", ":-)"] -> ["2", ":-)"] 

["1234", "1567", "-2", "computer science"] -> ["2"]

["Russia", "Denmark", "Kazan"] -> []

**Решение:**
1. Задаем массив строк любой длины с клавиатуры.
2. Далее используем функцию NewArray:
	- на вход принимаем заданный массив строк (string[] arr);
	- объявляем новый массив (string[] new_arr), который будет равен длине заданного;
	- заходим в цикл for, с помощью которого пройдем по всем элементам заданного массива, не вылетев за пределы его длины;
	- в цикле for:
		+ задаем новую переменню j = 0 (индекс первого элемента в новом массиве, с которого он начнет заполняться);
		+ заходим в условие if (проверяем условие задачи: длина строки должна быть <= 3);
		+ если условие выполняется, то элемент заносится в новый массив на текущую позицию, дальше происходит переход на следующую позицию (j++);
		+ если условие не выполняется, то проверяемый элемент никуда не заносится, а алгоритм возвращается к началу цикла for и переходит к проверке следующего элемента в заданном изначально массиве.
3. Когда все элементы заданного массива будут проверены, на выходе мы получим новый массив, который будет состоять из отобранных строк заданного изначально массива, длина которых <=3.
