import math
from typing import Tuple, Type


class DecimalCounter:
    try:
        value1: tuple[Type[int], str] = int, input("Please enter the first value:\n")
    except ValueError:
            print("This symbol is not integer type")
    try:
        value2: tuple[Type[int], str] = int, input("Please enter the second value:\n")
    except ValueError:
            print("This symbol is not integer type")
    try:
        diapazon: tuple[Type[int], str] = int, input("Please enter the value of range:\n")
    except ValueError:
            print("This symbol is not integer type")

    def __init__(self):
        self.val1 = None
        self.val2 = None
        self.summa = None
        self.minus = None
        self.range = None
    def sum(self,val1,diapazon):
        for range in diapazon:
            val1 += 1
            assert isinstance(val1, object)
            return val1
        print(sum)
    def min(self,val2, diapazon):
        for range in diapazon:
            val2 -=1
            assert isinstance(val2,object)
            return val2
        print(min)

    def sum1(self,val1,val2):
        self.val1 = self.value1
        self.val2 = self.value2
        self.summa = self.val1 + val2
        print(DecimalCounter.self.summa)
    def min(self,val1,val2):
        self.val1 = self.value1
        self.val2 = self.value2
        self.minus = self.val1 - self.val2




