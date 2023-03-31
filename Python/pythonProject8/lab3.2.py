class telephone():
    def __init__(self, name, telephone):
        self.name = name
        self.telephone = telephone
class friend(telephone):
    def __init__(self, name, telephone, databir, address):
        super().__init__(name, telephone)
        self.databir = databir
        self.address = address
    def display(self):
        print(f'Имя {self.name} Номер телефона {self.telephone} День рождения {self.databir} Адрес {self.address}')

    print("Павел Поляков", 89160759661, "15.12.2002", "город Кемерово")

class person(telephone):
    def __init__(self, name, address, telephone):
        super().__init__(name, telephone)
        self.address = address
    def display(self):
            print(f'Имя {self.name} Номер телефона {self.telephone}  Адрес {self.address}')
    print("Даня Лисин", 8805553535, "город Мухосранск")


class organization(telephone):
    def __init__(self, name, address, telephone, fax, contactface):
        super().__init__(name, telephone)
        self.address = address
        self.fax = fax
        self.contactface = contactface
    def display(self):
            print(f'Имя {self.name} Номер телефона {self.telephone}  Адрес {self.address} Факс {self.fax} Контактное лицо {self.contactface}')
    print("OAO AVEGAS", 79153716277, "город Москва", 79159999999, "Семён")
