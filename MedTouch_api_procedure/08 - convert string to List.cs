string contentIds = "abc!def!wsx!yyy";
List<string> taxonomies;

if (contentIds.IsNotNullOrEmpty())
{
    taxonomies = contentIds.Split('!').ToList();
}