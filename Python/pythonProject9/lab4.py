class Organization():
    shablon = ["Индекс", "Город", "Улица", "Здание", ]

    def __init__(self, adr):
        self.adr = adr

    def new_adress(self, key, value):
        self.adr[key] = value


adr1 = {"Индекс": "404040", "Город": "Иваново", "Улица": "Центральная", "Здание": "25"}
org1 = Organization(adr1)

print(org1.adr)
org1.new_adress("Город", "Самара")
print(org1.adr)