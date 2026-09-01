TripletSum x = new();

// var ls = x.Sum([-4, -4, -2, 0, 0, 1, 2, 3]);
var lss = x.ThreeSum([-1,0,1,2,-1,-4]);

foreach(var ls in lss)
System.Console.WriteLine(string.Join(", ", ls));
