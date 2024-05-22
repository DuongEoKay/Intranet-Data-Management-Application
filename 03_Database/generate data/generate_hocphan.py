from faker import Faker
import random

fake = Faker()

# Define the number of records to generate
num_records = 10

# Define a list of subjects in the field of information technology
subjects = ["Programming Fundamentals", "Data Structures", "Algorithms", "Database Systems", "Operating Systems", "Computer Networks", "Software Engineering", "Artificial Intelligence", "Machine Learning", "Web Development"]
donvi=['VPK', 'BMHTTT',
'BMCNPM',
'BMKHMT',
'BMCNTT',
'BMTGMT',
'BMMMTVVT']
for _ in range(num_records):
    MAHP = "HP"+str(fake.unique.random_number(digits=4))
    TENHP = random.choice(subjects)
    SOTC = random.randint(2, 4)
    STLT = random.randint(70, 90)
    STTH = random.randint(20, 40)
    SOSVTD = random.randint(50, 100)
    MADV = random.choice(donvi)

    print(f"INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('{MAHP}', '{TENHP}', {SOTC}, {STLT}, {STTH}, {SOSVTD}, '{MADV}');")