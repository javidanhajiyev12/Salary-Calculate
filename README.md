# Payroll Assistant

A simple C# console program that calculates an employee's salary, allowances, income tax and net pay, and shows how many banknotes are needed to pay the salary.

## Features

- Reads gross salary, marital status, number of children and disability status
- Calculates family allowance and child allowance
- Calculates income tax rate and tax amount
- Prints total gross salary and net salary
- Rounds the net salary and counts the banknotes needed (200, 100, 50, 20, 10, 5, 1 AZN)

## Rules

**Family allowance**

| Status | Allowance |
|--------|-----------|
| Married (e/E) | 50 AZN |
| Single (b/B), Widowed (d/D) | 0 AZN |

**Child allowance** (not asked for single employees)

| Child | Allowance |
|-------|-----------|
| 1st | 30 AZN |
| 2nd | 25 AZN |
| 3rd | 20 AZN |
| 4th and more | 15 AZN each |

**Income tax** (based on total gross salary = salary + allowances)

| Total gross | Tax rate |
|-------------|----------|
| up to 1000 AZN | 15% |
| 1000 - 2000 AZN | 20% |
| 2000 - 3000 AZN | 25% |
| over 3000 AZN | 30% |

Disabled employees pay 50% less tax.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or newer

## How to Run

```bash
git clone <your-repository-url>
cd <repository-folder>
dotnet run
```

## Example

```
Enter gross salary: 1500
Marital status (e: married, b: single, d: widowed): e
Number of children: 2
Disabled? (e: yes, h: no): h
Family allowance: 50.00
Child allowance: 55.00
Tax rate: 20.00 %
Tax amount: 321.00
Total gross salary: 1605.00
Net salary: 1284.00
Paid: 1284
200 AZN x 6
100 AZN x 0
50 AZN x 1
20 AZN x 1
10 AZN x 1
5 AZN x 0
1 AZN x 4
```

## Notes

- Input is assumed to be valid (no error checking).
- Disability input: `e`/`E` means yes, anything else means no.
- Widowed employees receive child allowance but no family allowance.
