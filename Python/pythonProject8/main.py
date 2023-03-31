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
print("Suzuki", "a100aa", "256", "450")

class motorcycle(transport):
    def __init__(self, mark, speed, number, loadcapacity, wheelchair):
        super().__init__(mark, number)
        self.speed = speed
        self.loadcapacity = loadcapacity
        self.wheelchair = wheelchair
           # if(wheelchair != 1)
             #   print(loadcapacity = 0)
    def display(self):
        print(f'Имя {self.name} Номер телефона {self.telephone} Адрес {self.address}')
print("Даня Лисин", 8805553535, "город Мухосранск")


class organization(transport):
def __init__(self, name, address, telephone, fax, contactface):
super().__init__(name, telephone)
self.address = address
self.fax = fax
self.contactface = contactface
def display(self):
print(f'Имя {self.name} Номер телефона {self.telephone} Адрес {self.address} Факс {self.fax} Контактное лицо {self.contactface}')
print("OAO AVEGAS", 79153716277, "город Москва", 79159999999, "Семён")