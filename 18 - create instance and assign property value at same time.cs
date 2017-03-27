public class Question
{
    public string Text { get; set; }
}

// () is optional
Question q = new Question { Text = "Some question" };
// You can only use this for property that has set method. 

// use () in case you want to pass value to constructor
Question q = new Question() { Text = "Some question" };

