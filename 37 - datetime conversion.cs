// The datetime value retrieved from sitecore is "20161114T000000Z"

string str = "20161114T000000Z";

// 1. convert to DateTime object
DateTime outputDateTime;
DateTime.TryParseExact(str, "yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.None, out outputDateTime);

// 2. convert DateTime object to string
string dayMonthYear = outputDateTime.ToString("dd/MM/yyyy");
