import math
try:
    x,y = map(int, input("Введите координаты Короля от 1 до 8:\n").split())
except ValueError:
    print("Некорректный ввод данных...")
try:
    x1,y1 = map(int, input("Введите координаты клетки хода").split())
except ValueError:
    print("Некорректный ввод данных...")
if ((x == x1)and(y == y1)):
    print("False")
