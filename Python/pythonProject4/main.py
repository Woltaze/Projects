class Shetchik:
    def __init__(self):
        self.value = None
        self.summa = None
        self.minus = None
        self.range = None
    setattr(Shetchik, value, 10)
    setattr(Shetchik, range, 20)

    def decrement(self,val1,diapazon):
        for range in diapazon:
            val1 += 1
            assert isinstance(val1, object)
            return val1
        print(decrement)
    def increment(self,val2, diapazon):
        for range in diapazon:
            val2 -=1
            assert isinstance(val2,object)
            return val2
        print(increment)

    current =  __getattr__(self, decrement, increment)
    print(current)

