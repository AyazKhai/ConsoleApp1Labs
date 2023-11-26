
import random  # Импортируем модуль random для генерации случайных элементов
import uuid  # Импортируем модуль uuid для генерации уникальных идентификаторов
import pickle  # Импортируем модуль pickle для сериализации и десериализации объектов

class PowerSuply:
    def __init__(self):  # Конструктор класса PowerSuply
        firmArr = ["CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung"]  # Массив фирм
        markArr = ["Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)", "с двойным преобразованием напряжения(On-Line)", "Cломанный"]  # Массив марок
        self.firm = random.choice(firmArr)  # Выбираем случайную фирму из firmArr
        self.mark = random.choice(markArr)  # Выбираем случайную марку из markArr
        self.id = str(uuid.uuid4().hex)  # Генерируем уникальный идентификатор

class queues:
    def __init__(self, n=1):  # Конструктор класса queues
        self.n = n  # Задаем количество элементов
        self.Queues = [PowerSuply() for _ in range(n)]  # Создаем список объектов PowerSuply в количестве n
    
    def __getitem__(self, pos):  # Метод для получения элемента по индексу
        if pos >= 0 and pos < 30:  # Проверяем, находится ли индекс в диапазоне
            return self.Queues[pos]  # Возвращаем объект из списка по указанному индексу
        else:
            raise IndexError("Вне диапазона")  # Генерируем исключение, если индекс находится вне диапазона
    
    def __setitem__(self, pos, value):  # Метод для установки элемента по индексу
        self.Queues[pos] = value  # Устанавливаем объект в список по указанному индексу
    
    def GetRes(self):
        for i in range(self.n):
            print(f"Источник автономного питания:\nФирма: {self.Queues[i].firm}\nМарка: {self.Queues[i].mark}\nИдентифиционный номер: {self.Queues[i].id}\n")

if __name__ == "__main__":
    print("Введите кол-во элементов")
    n = int(input())
    q2 = queues(n)  # Создаем объект queues с количеством элементов, введенных пользователем
    q2.GetRes()  # Выводим информацию о каждом объекте из Queues

    # Сериализация
    with open("File_queue.txt", "wb") as fs:
        pickle.dump(q2, fs)  # Сериализуем объект q2 и сохраняем его в файл
        print("Объект был сериализован\n")
    
    q1 = queues()  # Создаем новый объект queues для десериализации
    # Десериализация
    with open("File_queue.txt", "rb") as fs:
        q1 = pickle.load(fs)  # Десериализуем объект из файла и сохраняем его в q1
        print("Объект был десериализован\n")
    
    q1.GetRes()  # Выводим информацию о каждом объекте из q1

