Console.Write("Enter gross salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Marital status (e: married, b: single, d: widowed): ");
char status = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

int children = 0;
if (status != 'B')
{
    Console.Write("Number of children: ");
    children = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Disabled? (e: yes, h: no): ");
char disabled = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

// Family allowance
double familyAllowance = 0;
if (status == 'E')
    familyAllowance = 50;

// Child allowance
double childAllowance = 0;
for (int i = 1; i <= children; i++)
{
    if (i == 1) 
        childAllowance += 30;
    else if (i == 2) 
        childAllowance += 25;
    else if (i == 3) 
        childAllowance += 20;
    else 
        childAllowance += 15;
}

double totalGross = salary + familyAllowance + childAllowance;

// Tax rate
double taxRate;
if (totalGross <= 1000)
{
    taxRate = 15;
}
else if (totalGross <= 2000)
{
    taxRate = 20;
    
}
else if (totalGross <= 3000)
{
    taxRate = 25;
}
else
{
    taxRate = 30;
}

if (disabled == 'E')
{
    taxRate = taxRate / 2;
}

double tax = totalGross * taxRate / 100;
double netSalary = totalGross - tax;

Console.WriteLine($"Family allowance: {familyAllowance:F2}");
Console.WriteLine($"Child allowance: {childAllowance:F2}");
Console.WriteLine($"Tax rate: {taxRate:F2} %");
Console.WriteLine($"Tax amount: {tax:F2}");
Console.WriteLine($"Total gross salary: {totalGross:F2}");
Console.WriteLine($"Net salary: {netSalary:F2}");

// Banknotes
int pay = (int)Math.Round(netSalary, MidpointRounding.AwayFromZero);
int[] notes = { 200, 100, 50, 20, 10, 5, 1 };

Console.WriteLine("Paid: " + pay);
foreach (int note in notes)
{
    Console.WriteLine(note + " AZN x " + pay / note);
    pay = pay % note;
}