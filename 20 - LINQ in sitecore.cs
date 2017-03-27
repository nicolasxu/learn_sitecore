string source = "https://doc.sitecore.net/sitecore_experience_platform/developing/developing_with_sitecore/search_and_item_buckets/linq_to_sitecore";


"Sitecore supports two search providers: Lucene and Solr. 
The LINQ layer is an abstract layer that converts common 
queries to something that these search providers understand."


using (var context = ContentSearchManager.GetIndex(item).CreateSearchContext()) {
    
    IQueryable<SearchResultItem> searchQuery = context.GetQueryable<SearchResultItem>().Where(item => item.Name == “Sitecore”)

}

// Supported IQueryable methods

/* 

The LINQ layer does not implement all IQueryable methods. The following methods have been implemented:

Sort by standard string, integer, float, or any type that implements IComparable
All
Any
Between (with an extra overload for including or excluding the start and end ranges)
Boost (makes this part of the query more important than the other parts)
Cast (you can use this instead of Select)
Contains
Count
ElementAt
EndsWith
Equal
Facets (an extension that fetches the facets of predicates)
First
FirstOrDefault
Join
Last
LastOrDefault
Min
Max
Match (an extension for running regular expression queries)
OrderBy
OrderByDescending
Select
Single
SingleOrDefault
Skip
Take
ToList()
ToLookUp()
ToDictionary()
Page (an extension that does Skip and Take automatically for you)
StartsWith



*/