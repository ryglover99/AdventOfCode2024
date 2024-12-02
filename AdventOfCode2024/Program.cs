
using AdventOfCode2024.Day_1;

var day1 = new Day1();

var (list1,list2) = day1.ParseInputFileIntoTwoLists("C:\\Users\\ryang\\Desktop\\Github Projects\\AdventOfCode2024\\AdventOfCode2024\\Day 1\\input.txt");


List<int> differenceBetweenLowest = new List<int>();
List<int> similarScore = new List<int>();

foreach (var num in list1)
{
    var all = list2.FindAll(x => x == num);

    var simScore = num * all.Count();
    similarScore.Add(simScore);
}

foreach (var num in list1.ToList())
{

    var lowest1 = day1.FindLowestNumberInList(list1);


    foreach (var num2 in list2.ToList())
    {

        var lowest2 = day1.FindLowestNumberInList(list2);

        if (lowest1 > lowest2)
        {
            differenceBetweenLowest.Add(lowest1 - lowest2);

        } else if (lowest2 > lowest1)
        {
            differenceBetweenLowest.Add(lowest2 - lowest1);

        } else if (lowest1 == lowest2)
        {
            differenceBetweenLowest.Add(0);
        }

        list1.Remove(lowest1);
        list2.Remove(lowest2);
        break;

    }
}

var finalAnswer = differenceBetweenLowest.Sum();
var simScoreSum = similarScore.Sum();

Console.WriteLine($"THE FINAL ANSWER IS: {finalAnswer}");




