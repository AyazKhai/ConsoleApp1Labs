class PowerSupply:
    firm = "Samsung"
    mark = "Z310Dual"
    capcity = 3000

    def __init__(self):
        self.id = 0

if __name__ == "__main__":
    print("Ёмкость источника бесперибойного питания: ", PowerSupply.capcity)
    print("Название фирмы: ", PowerSupply.firm)