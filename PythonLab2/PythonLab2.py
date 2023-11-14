class PowerSupply:
    def __init__(self, firm="Undefined", mark="Undefined", capcity=0, cost=0):
        self.firm = firm
        self.mark = mark
        self.capcity = capcity
        self.cost = cost

if __name__ == "__main__":
    Ecovolt = PowerSupply("Ecovolt", "Termo312", 300, 13300)
    Myown = PowerSupply()

    print("Power supply source name from the store: ", Ecovolt.firm, Ecovolt.mark)
    print("Home power supply source name: ", Myown.firm, Myown.mark)