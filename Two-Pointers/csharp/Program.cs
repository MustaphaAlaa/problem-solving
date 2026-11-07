LC_MoveZeroes lc = new();

var arr = lc.MoveZeroes2([0, 1, 13, 0, 2, 0, 20]);
System.Console.WriteLine(string.Join(", ", arr));

arr = lc.MoveZeroes([0, 1, 0, 0, 21, 0, 20]);
System.Console.WriteLine(string.Join(", ", arr));

arr = lc.MoveZeroes([0, 11, 13, 0, 2, 0, 210]);
System.Console.WriteLine(string.Join(", ", arr));

arr = lc.MoveZeroes2([0, 1998, 1123, 0, 1122, 0, 1120]);
System.Console.WriteLine(string.Join(", ", arr));
