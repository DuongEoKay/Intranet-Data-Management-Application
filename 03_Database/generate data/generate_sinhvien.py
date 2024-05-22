import random
from faker import Faker
from faker.providers import date_time, person

fake = Faker()
fake.add_provider(date_time)
fake.add_provider(person)

# Hàm tạo dữ liệu giả mạo cho SINHVIEN
def generate_mock_data(num_rows):
    mock_data = []
    genders = ['Nam', 'Nữ']
    nganh =['BMCNTT', 'BMCNPM', 'BMHTTT', 'BMTGMT','BMKHMT', 'BMMMTVVT' ]
    ctrinh = ['CQ', 'CTTT', 'VP', 'CLC']
    for _ in range(num_rows):
        masv = "SV"+str(fake.unique.random_number(digits=4))
        hoten = fake.name()
        phai = random.choice(genders)
        ngsinh = fake.date_of_birth(minimum_age=18, maximum_age=30)
        ngsinh_str = ngsinh.strftime('%m-%d-%Y')  # Convert date to string in 'mm-dd-yyyy' format
        dchi = fake.address()
        dt = '037'+str(fake.unique.random_number(digits=7))
        mact = random.choice(ctrinh)
        manganh = random.choice(nganh)
        sotctl = random.randint(0, 100)
        dtbtl = round(random.uniform(0, 10), 2)
        mock_data.append((masv, hoten, phai, ngsinh_str, dchi, dt, mact, manganh, sotctl, dtbtl))
    return mock_data

# Số lượng dòng dữ liệu giả mạo
num_rows = 4000

# Tạo dữ liệu giả mạo cho SINHVIEN
mock_data = generate_mock_data(num_rows)

# In ra một số dòng dữ liệu giả mạo
with open('output.txt', 'w', encoding='utf-8') as f:
    for data in mock_data:
        f.write("INSERT INTO ADM.SINHVIEN(MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL,DTBTL) VALUES\n")
        f.write(str(data)+";\n")