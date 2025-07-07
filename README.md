# 🛠️ C# Bug Fix Collection

This repository contains a collection of C# code snippets that had bugs, which I have fixed and documented.  
Each example includes a description of the original issue, what was changed, and the final corrected code.

---

## 📂 List of Bug Fixes

### ✅ Bug #1: Broken Calculator Input & Operation Logic
- **Filename:** `bug1_fixed.cs`
- **Issues Identified:**
  - Tried to assign `Console.ReadLine()` (returns string) directly to an `int`, which causes a compilation error.
  - Used `Console.Read()` to read the operation, which only reads a single character and leaves the newline in the buffer.
  - No input validation was present, so the program could crash on invalid input.
  - Parentheses were missing in arithmetic output formatting.

- **Fixes Implemented:**
  - Wrapped all user input in `while` loops to ensure correct input type.
  - Used `Convert.ToInt32(Console.ReadLine())` for integers and `Convert.ToChar(Console.Read())` for the operator.
  - Added `try-catch` blocks to catch and handle invalid input.
  - Ensured arithmetic results were wrapped in parentheses to fix formatting (e.g., `a + b` in `Console.WriteLine`).

- **Status:** ✅ Fixed and tested

---

## 🧪 How to Run

Each file is a standalone `Main()` method and can be compiled and executed individually.  
You can use any C# environment like Visual Studio, VS Code with the C# extension, or [dotnetfiddle.net](https://dotnetfiddle.net/).

---

## 📌 Notes

- All bugs are either logical, syntax-related, or input-handling problems.
- This repository is updated regularly as I solve more real-world C# issues.


## Developer Name: Fatima Hasan
