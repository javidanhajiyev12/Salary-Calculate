

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

## How
