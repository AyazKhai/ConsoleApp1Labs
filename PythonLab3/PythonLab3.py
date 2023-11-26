
class PowerSuply:
    # Определяем конструктор класса PowerSuply с параметрами firm, mark, capacity и cost
    def __init__(self, firm="Undefind", mark="Undefind", capacity=0, cost=0): 
        # Присваиваем значения переданным параметрам объекта PowerSuply
        self.firm = firm
        self.mark = mark
        self.capacity = capacity
        self.cost = cost

    def GetReport(self): # Определяем метод GetReport для класса PowerSuply, возвращающий отчет
         # Возвращаем отчет о источнике бесперебойного питания
        return f"Источник бесперебойного питания:(Родитель)\nФирма: {self.firm}\nМарка: {self.mark}\nЁмкость: {self.capacity} мАч\nЦена: {self.cost} руб.\n"


class RezervSuply(PowerSuply):
     # Определяем конструктор класса RezervSuply с параметрами firm, mark, capacity, cost и worktime
    def __init__(self, firm="Undefind", mark="Undefind", capacity=0, cost=0, worktime=0):
         # Вызываем конструктор родительского класса и передаем ему параметры firm, mark, capacity и cost
        super().__init__(firm, mark, capacity, cost)
         # Присваиваем значение параметру worktime объекта RezervSuply
        self.worktime = worktime

    def GetReport(self): # Определяем метод GetReport для класса RezervSuply, возвращающий отчет
         # Возвращаем отчет об источнике автономного питания
        return f"Источник автономного питания:(Наследник)\nФирма: {self.firm}\nМарка: {self.mark}\nЁмкость: {self.capacity} мАч \nЦена: {self.cost} руб.\nВремя автономной работы: {self.worktime} часов\n"

# Создаем объекты Ecovolt и Luduvi классов PowerSuply и RezervSuply соответственно
Ecovolt = PowerSuply("Ecovolt", "Termo312", 300, 13300)
Luduvi = RezervSuply("Luduvi", "90000", 90000, 11820, 48)
# Выводим отчеты о созданных объектах
print(Ecovolt.GetReport())
print(Luduvi.GetReport())


