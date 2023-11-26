import random  # Импортируем модуль random

class PowerSuply:
    def __init__(self):  # Конструктор класса PowerSuply
        self.firmArr = ["CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung"]  # Массив фирм
        self.markArr = ["Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)", "с двойным преобразованием напряжения(On-Line)", "Cломанный"]  # Массив марок
        self.firm = random.choice(self.firmArr)  # Выбираем случайную фирму из firmArr
        self.mark = random.choice(self.markArr)  # Выбираем случайную марку из markArr
        self.id = random.randint(0, 29)  # Генерируем случайный идентификационный номер

class queues:
    def __init__(self, n):  # Конструктор класса queues
        self.Queues = [PowerSuply() for _ in range(n)]  # Создаем список объектов PowerSuply в количестве n
    
    def __getitem__(self, pos):  # Метод для получения элемента по индексу
        if pos >= 0 and pos < 30:  # Проверяем, находится ли индекс в диапазоне
            return self.Queues[pos]  # Возвращаем объект из списка по указанному индексу
        else:
            raise IndexError("Вне диапазона")  # Генерируем исключение, если индекс находится вне диапазона
    
    def __setitem__(self, pos, value):  # Метод для установки элемента по индексу
        self.Queues[pos] = value  # Устанавливаем объект в список по указанному индексу

n = int(input("Введите кол-во элементов: "))  # Вводим количество элементов
a = queues(n)  # Создаем объект очереди с количеством элементов, введенных пользователем
for i in range(n):  # Перебираем каждый объект
    print(f"Источник автономного питания:\nФирма: {a[i].firm}\nМарка: {a[i].mark}\nИдентификационный номер: {a[i].id}\n")
