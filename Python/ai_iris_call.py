import joblib
clf = joblib.load("ai_iris_96.dmp")
import pandas as pd

import  random

df = pd.read_csv('iris2.csv')
v1 = df.iloc[:, [1]]
v2 = df.iloc[:, [2]]
v3 = df.iloc[:, [3]]
v4 = df.iloc[:, [4]]

a = 0
while a < 20 :
    #v1 = float(input("꽃잎 길이 -->"))
    #v2 = float(input("꽃잎 폭 -->"))
    #v3 = float(input("꽃대 길이 -->"))
    #v4 = float(input("꽃잎 폭 -->"))

    myData = [random.choice(v1), random.choice(v2), random.choice(v3),random.choice(v4)]
    result = clf.predict([myData])
    print("이 꽃은 %s 입니다." % result)
    a += 1
    print("%d회 진행중" % a)
print("종료")

