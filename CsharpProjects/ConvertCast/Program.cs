// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] values = { "12.3", "45", "ABC", "11", "DEF"};
string message = "";
decimal total = 0;

for(int i = 0; i < values.Length; i++) {
    
    if(decimal.TryParse(values[i], out decimal value)) {
        total += value;
    } else {
        message += values[i];
    }
}

Console.WriteLine("Message: " + message);
Console.WriteLine("Total: " + total);

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");