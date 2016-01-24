# Types Extensions

A collection of extension methods to a number of types to reduce the amount of code written and to make intention clearer. This library is loosely insipred by [Active Support](https://github.com/rails/rails/tree/master/activesupport) and other fluent-style utility classes around.

## Install

Best way to install is via [Nuget](https://nuget.org):

```
PM> Install-Package RedWillow.TypesExtension
```

## Usage

There are currently utility extensions for date and time calculations and for string operations. Following are some examples for usage:

### Date and Time Calculations

```C#
using RedWillow.TypesExtensions;

/**
 * Get expiry date. If it falls on the weekend make it
 * the following Monday.
 **/
public DateTime GetExpiryDate(int expireInDays)
{
    var expiryDate = expireInDays.Days().FromNow();

    while (expiryDate.IsSaturday() || expiryDate.IsSunday())
        expiryDate = expiryDate + 1.Days();

    return expiryDate;
}

public bool HasExpired(DateTime expiryDate)
{
    return expiryDate.IsBeforeNow();
}
```

### Strings

```C#
var str = "$39.95 per week";

// Regular expression matching
var isPrice = str.IsMatch("^\\$?[0-9]+\\.[0-9]{2}");

// Make it free! (But note the usual price)
var freePrice = str.ReReplace("([0-9]+\\.[0-9]{2})", "0.00 (usually $1)");

var fruit = new List<string>(
    new string[] { "apple", "pear", "bananna", "blackberry" });

var csvFruit = fruit.Join(",");
```

## License

Types Extensions is released under a [MIT license](http://opensource.org/licenses/MIT)
