/* what is Aggregate? 
   https://msdn.microsoft.com/en-us/library/bb548651(v=vs.110).aspx

   This method works by calling func one time 
   for each element in source except the first one.

*/

// aggregate example

string sentence = "the quick brown fox jumps over the lazy dog";

// Split the string into individual words.
string[] words = sentence.Split(' ');

// Prepend each word to the beginning of the 
// new sentence to reverse the word order.
string reversed = words.Aggregate((workingSentence, next) =>
                                      next + " " + workingSentence);

Console.WriteLine(reversed);

// This code produces the following output:
//
// dog lazy the over jumps fox brown quick the 




// another aggregate example
var predicate = PredicateBuilder.True<BaseSearchResultItem>();

predicate = ids.Aggregate(predicate /* initial value */, (current, id) => current.Or(p => p.TemplateId == id));

// (current, id) => current.Or(p => p.TemplateId == id)

query = (IQueryable<BaseSearchResultItem>)query.Where(predicate);


