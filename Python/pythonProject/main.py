import math
try:
    x = float(input("Please enter a number x:\n"))
except ValueError:
    print("That was no valid number, please try again...")
    quit()
expr1 = (2*((math.cos(x)*3)/(math.sin(x)*3)))-((math.log(math.cos(x)))/math.log(1+x**2))
print(expr1)
expr2 = (math.log(abs(math.cos(x))))/(math.log(1+x**2))
print(expr2)



