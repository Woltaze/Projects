class transport():
    def __init__(self, mark, number):
        self.mark = mark
        self.number = number

class car(transport):
    def __init__(self, mark, number, speed, loadcapacity):
        super().__init__(mark, number)
        self.speed = speed
        self.loadcapacity = loadcapacity
        def display(self):
            print(f'Марка {self.mark} Номер {self.number} Скорость {self.speed} Грузоподъемность {self.loadcapacity}')
            print("Suzuki", "A100AA", "256км/ч", "450кг")

class motorcycle(transport):
    def __init__(self, mark, speed, number, loadcapacity, wheelchair):
        super().__init__(mark, number)
        self.speed = speed
        self.loadcapacity = loadcapacity
        self.wheelchair = wheelchair
    def display(self):
        print(f'Марка {self.mark} Номер {self.number} Скорость {self.speed} Коляска {self.wheelchair} Грузоподъемность {self.loadcapacity}')
        print("Kawasaki", "5034BB77", "165км/ч","Есть","200кг")
        print("Yamaha", "2859AC58", "178км/ч","Нет","0кг")

class truck(transport):
    def __init__(self, mark, number, speed, loadcapacity, trailer):
        super().__init__(mark, number)
        self.speed = speed
        self.loadcapacity = loadcapacity
        self.trailer = trailer
        def display(self):
            print(f'Марка {self.mark} Номер {self.number} Скорость {self.speed} trailer {self.trailer} loadcapacity {self.loadcapacity}')
            print("Suzuki", "2859AC58", "210км/ч", "Есть" , "1000*2")