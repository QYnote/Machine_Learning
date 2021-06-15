import  pandas as pd
import numpy as np

#알고리즘
from sklearn.neighbors import KNeighborsClassifier
from sklearn import  metrics, utils

# 데이터 가져오기
df = pd.read_csv('iris2.csv')
df = utils.shuffle(df)

dataLen = df.shape[0]
trainSize = int(dataLen * 0.7)
testSize = dataLen - trainSize

train_data = df.iloc[0:trainSize, 1:]
train_label = df.iloc[0:trainSize, 0]

test_data = df.iloc[0:testSize, 1:]
test_label = df.iloc[0:testSize, 0]


clf = KNeighborsClassifier(n_neighbors=5)

clf.fit(train_data, train_label)


results = clf.predict(test_data)
score = metrics.accuracy_score(results, test_label)
print("정답률 : %5.2f %%" % (score*100))

#테스트
myData = [4.1, 3.3, 1.4, 0.2]
result = clf.predict([myData])

print("이 꽃은 %5.2f %%의 확률로 %s 입니다." % (score*100, result))