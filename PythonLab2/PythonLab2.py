class PowerSuply:
    def __init__(self, firm="Undefind", mark="Undefind", capacity=0, cost=0):
        self.firm = firm
        self.mark = mark
        self.capacity = capacity
        self.cost = cost
Myown = PowerSuply()
print("Введите название вашего источника бесперибойного питания")
Myown.firm = input()
print("Введите марку вашего источника бесперибойного питания")
Myown.mark = input()
print("введите ёмкость вашего источника бесперибойного питания")
Myown.capacity = int(input())

Ecovolt = PowerSuply("Ecovolt", "Termo312", 300, 13300)

print("Название источника бесперебойного питания из магазина", Ecovolt.firm, Ecovolt.mark)
print("Название домашнего источника бесперебойного питания",Myown.firm, Myown.mark, Myown.capacity)

