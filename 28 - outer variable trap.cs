// http://stackoverflow.com/questions/3416758/outer-variable-trap

/* 
The "Outer Variable Trap" occurs when a developer expects the 
value of a variable to be captured by a lambda expression or anonymous delegate,
but instead the final value is captured when lambda executes. 
Very like Javascript


*/
var actions = new List<Action>();
for (var i = 0; i < 10; i++)
{
    actions.Add(() => Console.Write("{0} ", i));
}
foreach (var action in actions)
{
    action();
}

// Expected output #1:
// 0 1 2 3 4 5 6 7 8 9


// Actual output #2:
// 10 10 10 10 10 10 10 10 10 10


// Fix:

var actions = new List<Action>();
for (var i = 0; i < 10; i++)
{
    var j = i; // fix is here
    actions.Add(() => Console.Write("{0} ", j));
}
foreach (var action in actions)
{
    action();
}

// Output:
// 0 1 2 3 4 5 6 7 8 9
