class PowerSuply:
    firm = "Samsung"
    capcity = 3000

    def init(self, mark):
        self.mark = mark

p = PowerSuply("Z310Dual")
print("������� ��������� �������������� �������:", p.capcity)
print("�������� �����:", PowerSuply.firm)