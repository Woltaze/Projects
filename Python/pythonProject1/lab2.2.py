import math
try:
    l = float(input("Please enter a number x:\n"))
except ValueError:
    print("That was no valid number, please try again...")
R = (l/2*3.14)
print(R)
S = (l*R/2)
print("Ответ:", S)

