// The datetime value retrieved from sitecore is "20161114T000000Z"

string str = "20161114T000000Z";

// 1. convert to DateTime object
DateTime outputDateTime;
DateTime.TryParseExact(str, "yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.None, out outputDateTime);

// 2. convert DateTime object to string
string dayMonthYear = outputDateTime.ToString("dd/MM/yyyy");


/* 
sitecore iso date:
https://sitecore.stackexchange.com/questions/4833/what-is-the-datetime-format-used-by-sitecores-date-datetime-field-types-and-h

*/

/*
Microsoft' latest guidance is to prefer the DateTimeOffset structure for unambiguously storing a point in time, 
so perhaps you should use this instead:
*/
var s = "20161114T000000Z";
var d = DateTimeOffset.ParseExact(s, "yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);