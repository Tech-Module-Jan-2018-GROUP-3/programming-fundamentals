# Exercises: C# Intro and Basic Syntax
Problems for exercises and homework for the
[“Programming
Fundamentals Extended” course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

### Problem 1.              
Debit Card Number

Write a program, which receives **4****integers** on the
console and **prints them** in **4-digit debit card format**. See the
examples below for the appropriate formatting.

#### Examples

 

| Input | Output              | Input | Output              | Input | Output              |
|-------|---------------------|-------|---------------------|-------|---------------------|
| 12    | 0012 0433 0001 5331 | 9182  | 9182 4221 0012 0003 | 812   | 0812 0321 0123 0022 |
| 433   |                     | 4221  |                     | 321   |                     |
| 1     |                     | 12    |                     | 123   |                     |
| 5331  |                     | 3     |                     | 22    |                     |


Problem 2.	Rectangle Area
Write a program, which calculates a rectangle’s area, based on its width and height. The width and height come as floating point numbers on the console, formatted to the 2nd character after the decimal point.

#### Examples
| Input | Output | | Input | Output | | Input   | Output |
|-------|--------|-|-------|--------|-|---------|--------|
| 2     | 14.00  | |7  	   | 56.00  | | 12.33   | 61.65  |
| 7     |        | |8  	   |        | | 5       |        |


### Problem 3.
Miles to Kilometers

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2nd decimal place**.

Note: **1 mile == 1.60934 kilometers**

#### Examples
| Input | Output | | Input | Output | | Input   | Output |
|-------|--------|-|-------|--------|-|---------|--------|
| 60    | 96.56  | |1  	   | 1.61   | | 52.1113 | 83.86  |

### Problem 5.
*Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name, current health, maximum health, current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

#### Examples
| Input | Output                              | Input  | Output                           |
|-------|-------------------------------------|--------|----------------------------------|
| Mayro | Name: Mayro                         | Bauser | Name: Bauser                     |
| 5     | Health: \|\|\|\|\|\|\.\.\.\.\.\|    | 10     | Health: \|\|\|\|\|\|\|\|\|\|\|\| |
| 10    | Energy: \|\|\|\|\|\|\|\|\|\|\.\|    | 10     | Energy: \|\|\|\|\|\|\|\|\|\|\|\| |
| 9     |                                     | 10     |                                  |
| 10    |                                     | 10     |                                  |

| Input | Output                                               | Input | Output                           |
|-------|------------------------------------------------------|-------|----------------------------------|
| Loogi | Name: Loogi                                          | Toad  | Name: Toad                       |
| 8     | Health: \|\|\|\|\|\|\|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\| | 0     | Health: \|\.\.\.\.\.\|           |
| 20    | Energy: \|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\|             | 5     | Energy: \|\.\.\.\.\.\.\.\.\.\.\| |
| 2     |                                                      | 0     |                                  |
| 14    |                                                      | 10    |                                  |

#### Hints
* You can print a character **multiple** times, using **new string(character, count)**.