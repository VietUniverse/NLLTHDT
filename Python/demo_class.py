class Employee:
    # hàm khởi tạo
    def __init__(self, name, department, salary):
        self.name = name
        self.department = department
        self.salary = salary
    

    # khai báo phương thức của đối tượng
    def get_info(self):
        print(F"{self.name} - {self.department} - {self.salary}")



# Tạo thực thể cho đối tượng
alice = Employee("Alice", "HR", 700)
bob = Employee("Bob", "IT", 1200)


