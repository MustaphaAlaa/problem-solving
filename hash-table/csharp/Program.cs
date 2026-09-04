// HashSet<string> set = new();

// for (var i = 0; i < 20_001_000; i++)
// {
//     var str = Guid.NewGuid().ToString();

//     set.Add(str);
// }

// System.Console.WriteLine(set.Count);
// System.Console.WriteLine($"Wasted Guid that share the begging are {20_001_000 - set.Count}");

var str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);

str = Guid.NewGuid().ToString();
System.Console.WriteLine(str);
