##[붓꽃 구별하기] 머신러닝 프로젝트##
from sklearn.neighbors import KNeighborsClassifier  ##KNN 알고리즘
from sklearn import metrics, utils      ##편리한 함수
import pandas as pd
import numpy as np

##0. 데이터 준비(*.csv)
## 1. 머신러닝 알고리즘 선택(KNN, SVM, DeppLearnin 알고리즘 포함)
## 2. 학습(훈련) --> 결과 : 모델(=알파고)        -- 오래걸림(CPU, GPU가 고성능이 필요함)
## 3. 모델의 정답률 구하기(몇점짜리 모델?)
## (4. 정답을 모르는 데이터로 예측 해보기) ==> 실용


##0. 데이터 준비(*.csv)
df = pd.read_csv('iris.csv')
df = utils.shuffle(df)  # 데이터 섞기(*필수*) : 랜덤하게 문제내기 위함
#학습용 80%, 테스트용 20% 분리
dataLen = df.shape[0]   # 행 개수(ex. 1000건)
trainSize = int(dataLen * 0.8)  # 학습용 = 1000 * 0.8건
testSize = dataLen - trainSize  # 테스트용 = 1000 - (1000 * 0.8) 건

train_data = df.iloc[0:trainSize, 0:-1]     # 데이터 뽑아내기      # '-1' : 맨 뒤에서 -1 까지
train_label = df.iloc[0:trainSize, [-1]]    # 정답 뽑아내기       # 정답이 맨뒤에 있는지 앞에있는지는 알아야함

test_data = df.iloc[0:testSize, 0:-1]
test_label = df.iloc[0:testSize, [-1]]


## 1. 머신러닝 알고리즘 선택(KNN, SVM, DeppLearnin 알고리즘 포함)
clf = KNeighborsClassifier(n_neighbors=3)   # 반드시 홀수, 모델 = 알파고


## 2. 학습(훈련) --> 결과 : 모델(=알파고)        -- 오래걸림(CPU, GPU가 고성능이 필요함)
clf.fit(train_data, train_label)


## 3. 모델의 정답률 구하기(몇점짜리 모델?)
results = clf.predict(test_data) # 모의고사 답안제출
score = metrics.accuracy_score(results, test_label)  # 체점

print("정답률 : %5.2f %%" % (score*100))

## (4. 정답을 모르는 데이터로 예측 해보기) ==> 실용
myData = [4.1, 3.3, 1.5, 0.2]
result = clf.predict([myData])

print("이 꽃은 %5.2f %%의 확률로 %s 입니다." % (score*100, result))