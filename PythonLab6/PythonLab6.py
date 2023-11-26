<<<<<<< HEAD
=======
﻿import random
import time

class PowerSuply:
    def __init__(self):
        self.firm = ""
        self.mark = ""
        self.id = 0
        self.firmArr = ["CyberPower", "IPPON", "El-Power", "Philips", "Panasonic", "samsung",
                        "ЗИТ", "ИМПУЛЬС", "Парус электро", "РОТЕК", "ТК Профэнерджи", "Эл��ктромаш", "QTECH"]
        self.markArr = ["Резервный(Off-Line)", "Линейно-интерактивный(Line-Interactive)",
                        "с двойным преобразованием напряжения(On-Line)", "Cломанный"]
        self.firm = random.choice(self.firmArr)
        self.mark = random.choice(self.markArr)
        self.id = random.randint(0, 99)

class queues:
    def __init__(self, n=1):
        self.n = n
        self.Queues = [PowerSuply() for _ in range(n)]

    def __getitem__(self, pos):
        if pos >= 0 and pos < 30:
            return self.Queues[pos]
        else:
            raise IndexError("Вне диапазона")

    def __setitem__(self, pos, value):
        self.Queues[pos] = value

    def GetRes(self):
        for i in range(self.n):
            print(f"Фирма: {self.Queues[i].firm}; Марка: {self.Queues[i].mark}; Идентифиционный номер: {self.Queues[i].id}")
    
    def GetRes(self, str=""):
        for i in range(self.n):
            print(f"Фирма: {self.Queues[i].firm}; Марка: {self.Queues[i].mark}; Идентифиционный номер: {self.Queues[i].id}", end ="")
        print(str)
        
    def GetIds(self, str=""):
        for i in range(self.n):
            print(f"{self.Queues[i].id} ", end="")
        print(str)

    def GetFirm(self, str=""):
        for i in range(self.n):
            print(f"{self.Queues[i].firm} ", end="")
        print(str)

    def CopyTo(self, obj1):
        for i in range(self.n):
            obj1.Queues[i].id = self.Queues[i].id
            obj1.Queues[i].firm = self.Queues[i].firm
            obj1.Queues[i].mark = self.Queues[i].mark

class Sorts:
    @staticmethod
    def DirectChooseId(arr):
        start_time = time.time()
        ghost = PowerSuply()
        for i in range(len(arr.Queues) - 1):
            minIndex = i
            for j in range(i, len(arr.Queues)):
                if arr[j].id < arr[minIndex].id:
                    minIndex = j
            if minIndex != i:
                ghost = arr[minIndex]
                arr[minIndex] = arr[i]
                arr[i] = ghost
        elapsed_time = time.time() - start_time
        print(f" Метод DirectChoose {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def DirectChooseFirm(arr):
        start_time = time.time()
        ghost = PowerSuply()
        for i in range(len(arr.Queues) - 1):
            minIndex = i
            for j in range(i + 1, len(arr.Queues)):
                if arr[j].firm < arr[minIndex].firm:
                    minIndex = j
            if minIndex != i:
                ghost = arr[minIndex]
                arr[minIndex] = arr[i]
                arr[i] = ghost
        elapsed_time = time.time() - start_time
        print(f" Метод DirectChoose {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def BubblyId(arr):
        start_time = time.time()
        ghost = PowerSuply()
        swapped = True
        for j in range(len(arr.Queues) - 1):
            swapped = False
            for i in range(len(arr.Queues) - 1):
                if arr[i + 1].id < arr[i].id:
                    ghost = arr[i + 1]
                    arr[i + 1] = arr[i]
                    arr[i] = ghost
                    swapped = True
            if not swapped:
                break
        elapsed_time = time.time() - start_time
        print(f" Метод Bubbly {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def BubblyFirm(arr):
        start_time = time.time()
        ghost = PowerSuply()
        swapped = True
        for j in range(len(arr.Queues) - 1):
            swapped = False
            for i in range(len(arr.Queues) - 1):
                if arr[i + 1].firm < arr[i].firm:
                    ghost = arr[i + 1]
                    arr[i + 1] = arr[i]
                    arr[i] = ghost
                    swapped = True
            if not swapped:
                break
        elapsed_time = time.time() - start_time
        print(f" Метод Bubbly {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def DirectConnectionId(arr):
        start_time = time.time()
        ghost = PowerSuply()
        for i in range(len(arr.Queues)):
            value = arr[i].id
            index = i
            while index > 0 and arr[index - 1].id > value:
                ghost = arr[index]
                arr[index] = arr[index - 1]
                arr[index - 1] = ghost
                index -= 1
        elapsed_time = time.time() - start_time
        print(f" Метод DirectConnection {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def DirectConnectionFirm(arr):
        start_time = time.time()
        ghost = PowerSuply()
        for i in range(len(arr.Queues)):
            value = arr[i].firm
            index = i
            while index > 0 and arr[index - 1].firm > value:
                ghost = arr[index]
                arr[index] = arr[index - 1]
                arr[index - 1] = ghost
                index -= 1
        elapsed_time = time.time() - start_time
        print(f" Метод DirectConnection {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def ShakerSortId(arr):
        start_time = time.time()
        swapped = True
        start = 0
        end = len(arr.Queues) - 1
        ghost = PowerSuply()
        while swapped:
            swapped = False
            for i in range(start, end):
                if arr[i].id > arr[i + 1].id:
                    ghost = arr[i]
                    arr[i] = arr[i + 1]
                    arr[i + 1] = ghost
                    swapped = True
            if not swapped:
                break
            swapped = False
            end -= 1
            for i in range(end - 1, start - 1, -1):
                if arr[i].id > arr[i + 1].id:
                    ghost = arr[i]
                    arr[i] = arr[i + 1]
                    arr[i + 1] = ghost
                    swapped = True
            start += 1
        elapsed_time = time.time() - start_time
        print(f" Метод ShakerSort {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def ShakerSortFirm(arr):
        start_time = time.time()
        swapped = True
        start = 0
        end = len(arr.Queues) - 1
        ghost = PowerSuply()
        while swapped:
            swapped = False
            for i in range(start, end):
                if arr[i].firm > arr[i + 1].firm:
                    ghost = arr[i]
                    arr[i] = arr[i + 1]
                    arr[i + 1] = ghost
                    swapped = True
            if not swapped:
                break
            swapped = False
            end -= 1
            for i in range(end - 1, start - 1, -1):
                if arr[i].firm > arr[i + 1].firm:
                    ghost = arr[i]
                    arr[i] = arr[i + 1]
                    arr[i + 1] = ghost
                    swapped = True
            start += 1
        elapsed_time = time.time() - start_time
        print(f" Метод ShakerSort {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def ShallSortId(arr):
        start_time = time.time()
        n = len(arr.Queues)
        ghost = PowerSuply()
        gap = n // 2
        while gap > 0:
            for i in range(gap, n):
                ghost = arr[i]
                j = i
                while j >= gap and arr[j - gap].id > ghost.id:
                    arr[j] = arr[j - gap]
                    j -= gap
                arr[j] = ghost
            gap //= 2
        elapsed_time = time.time() - start_time
        print(f" Метод ShallSort {elapsed_time * 1000} миллисекунд ")

    @staticmethod
    def ShallSortFirm(arr):
        start_time = time.time()
        n = len(arr.Queues)
        ghost = PowerSuply()
        gap = n // 2
        while gap > 0:
            for i in range(gap, n):
                ghost = arr[i]
                j = i
                while j >= gap and arr[j - gap].firm > ghost.firm:
                    arr[j] = arr[j - gap]
                    j -= gap
                arr[j] = ghost
            gap //= 2
        elapsed_time = time.time() - start_time
        print(f" Метод ShallSort {elapsed_time * 1000} миллисекунд ")

n = int(input("Введите кол-во элементов: "))

test0 = queues(n)
test1 = queues(n)
test0.CopyTo(test1)
test2 = queues(n)
test0.CopyTo(test2)
test3 = queues(n)
test0.CopyTo(test3)
test4 = queues(n)
test0.CopyTo(test4)
test5 = queues(n)




test0.CopyTo(test5)
test1.GetRes()
Sorts.DirectChooseId(test1)
test1.GetRes("\n")
test2.GetRes()
Sorts.BubblyId(test2)
test2.GetRes("\n")
test3.GetRes()
Sorts.DirectConnectionId(test3)
test3.GetRes("\n")
test4.GetRes()
Sorts.ShakerSortId(test4)
test4.GetRes("\n")
test5.GetRes()
Sorts.ShallSortId(test5)
test5.GetRes("\n")
print()
test1.GetRes()
Sorts.DirectChooseFirm(test1)
test1.GetRes("\n")
test2.GetRes()
Sorts.BubblyFirm(test2)
test2.GetRes("\n")
test3.GetRes()
Sorts.DirectConnectionFirm(test3)
test3.GetRes("\n")
test4.GetRes()
Sorts.ShakerSortFirm(test4)
test4.GetRes("\n")
test5.GetRes()
Sorts.ShallSortFirm(test5)
test5.GetRes("\n")


>>>>>>> be530b0 (Commit 26.11)

