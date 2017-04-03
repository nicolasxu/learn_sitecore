// predicate: 
//   one or any number of statements linked by And or Or logic operator.
// e.g:
//  (2 > 3) or (1 != 0) or (false)

// http://www.albahari.com/nutshell/predicatebuilder.aspx


var predicate = PredicateBuilder.True<BaseSearchResultItem>();

                predicate = ids.Aggregate(predicate, 
                    (current, id) => current.Or(p => p.TemplateId == id));

query = (IQueryable<BaseSearchResultItem>)query.Where(predicate);

                