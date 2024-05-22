from faker import Faker
import random

fake = Faker()


num_records = 100


mahp=['HP1369',
'HP1923',
'HP5454',
'HP559',
'HP6966',
'HP3306',
'HP8083',
'HP2374',
'HP5236',
'HP3704']

hocky = ['1', '2','3']
nam = [ 2022, 2023,2024]
mact = ['CQ', 'CTTT', 'VP', 'CLC']

for _ in range(num_records):
    MAHP = random.choice(mahp)
    HK = random.choice(hocky)
    NAM = random.choice(nam)
    MACT = random.choice(mact)

    print(f"INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('{MAHP}', '{HK}', {NAM}, '{MACT}');")