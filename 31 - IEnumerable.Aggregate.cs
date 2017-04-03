/* what is Aggregate? 
   https://msdn.microsoft.com/en-us/library/bb548651(v=vs.110).aspx

   This method works by calling func one time 
   for each element in source except the first one.

*/



var predicate = PredicateBuilder.True<BaseSearchResultItem>();

predicate = ids.Aggregate(predicate, (current, id) => current.Or(p => p.TemplateId == id));

query = (IQueryable<BaseSearchResultItem>)query.Where(predicate);


