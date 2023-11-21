
class PowerSuply:
    def __init__(self, firm="Undefind", mark="Undefind", capacity=0, cost=0):
        self.firm = firm
        self.mark = mark
        self.capacity = capacity
        self.cost = cost

    def GetReport(self):
        return f"Источник бесперебойного питания:(Родитель)\nФирма: {self.firm}\nМарка: {self.mark}\nЁмкость: {self.capacity} мАч\nЦена: {self.cost} руб.\n"


class RezervSuply(PowerSuply):
    def __init__(self, firm="Undefind", mark="Undefind", capacity=0, cost=0, worktime=0):
        super().__init__(firm, mark, capacity, cost)
        self.worktime = worktime

    def GetReport(self):
        return f"Источник автономного питания:(Наследник)\nФирма: {self.firm}\nМарка: {self.mark}\nЁмкость: {self.capacity} мАч \nЦена: {self.cost} руб.\nВремя автономной работы: {self.worktime} часов\n"


Ecovolt = PowerSuply("Ecovolt", "Termo312", 300, 13300)
Luduvi = RezervSuply("Luduvi", "90000", 90000, 11820, 48)
print(Ecovolt.GetReport())
print(Luduvi.GetReport())


