/*

http://stackoverflow.com/questions/4262240/what-does-one-question-mark-following-a-variable-declaration-mean


This is a nullable type. Nullable types allow value 
types (e.g. ints and structures like DateTime) to contain null.

 */

public interface IValidFromTo
{
   DateTime? ValidFrom { get; }
   DateTime? ValidTo   { get; }
}