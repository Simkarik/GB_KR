# Это контрольная работа для выбора специализации

## Условия:

1. Создать репозиторий на GitHub 

    *https://github.com/Simkarik/GB_KR*
2. Нарисовать блок-схему алгоритма, можно обойтись блок-схемой основной содержательной части, если вы
выделяете ее в отдельный метод

    *Файл в репозитории Block shema.png*
3. Снабдить репозиторий оформленным текстовым описанием решения 

    *Вы сейчас в нём, текст решения ниже*
4. Написать программу, решающую поставленную задачу
    
    *Program.csproj*
5. Использовать контроль версий в работе над этим небольшим проектом, не должно 
быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах

     *Вы сейчас в этом же репозитории*
## Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

## Решение:

Используем два цикла. 

В первом проходим по изначальному массиву и выщитываем сколько в нём строк длинной 3 или меньше. 

Создаём массив величиной, выясненной выше. 

Во втором цикле переносим элементы подходящие по условию в новый массив.
Выводим новый массив на экран.