import math
try:
    x,y = map(int, input("Задайте координату значениями x и y:\n").split())
except ValueError:
    print("Некорректный ввод данных...")
if((y>=2 and y<=6 and x>=-5 and x<=5)or(y>=0 and y<=2 and x>=-5 and x<=-2)or(y>=0 and y<=2 and x>=2 and x<=5)):
    print("True")
else:
    print("False")