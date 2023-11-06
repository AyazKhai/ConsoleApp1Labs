class PowerSuply:
    firm = "Samsung"
    capcity = 3000

    def init(self, mark):
        self.mark = mark

p = PowerSuply("Z310Dual")
print("Ёмкость источника бесперибойного питания:", p.capcity)
print("Название фирмы:", PowerSuply.firm)