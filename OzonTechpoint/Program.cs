/*
 * Вы участвуете в разработке подсистемы проверки поля для игры <<Морской бой>>.
 * Вам требуется написать проверку корректности количества кораблей на поле,
 * учитывая их размеры. Напомним, что на поле должны быть:
 *     четыре однопалубных корабля,
 *     три двухпалубных корабля,
 *     два трёхпалубных корабля,
 *     один четырёхпалубный корабль.
 */

// var idealDepot = new Dictionary<int, int> // size:count
// {
//     {4, 1}, {3, 2}, {2, 3}, {1, 4} // вывод - сумма key + value всегда обязана быть равна 5
// };

// Вам заданы 10 целых чисел от 1 до 4. Проверьте, что заданные размеры соответствуют требованиям выше.
var nums = new[] { 1, 2, 3, 4, 3, 2, 1, 2, 2, 1 };

var currentDepot = new Dictionary<int, int> // size:count
{
    {4, 0}, {3, 0}, {2, 0}, {1, 0}
};

foreach (var num in nums)
{
    currentDepot[num]++;
}

var positiveCase = true;
foreach (var (size, count) in currentDepot)
{
    if (size + count != 5)
        positiveCase = false;
}

Console.WriteLine(positiveCase ? "yes" : "no");