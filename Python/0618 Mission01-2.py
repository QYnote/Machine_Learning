# KNN 알고리즘
from sklearn.neighbors import KNeighborsClassifier

# 사용
from sklearn.model_selection import train_test_split    # 데이터 분리용
from sklearn import metrics
import pandas as pd

# 데이터 가져오기
df = pd.read_df = pd.read_csv("balance-scale.data")    # balance.data 불러오기
data = df.iloc[:, 1:]   # 2번째 열부터 data 지정
label = df.iloc[:, [0]] # 1번째 열을 정답 지정

#훈련 : 테스트 = 3 : 7
train_data, test_data, train_label, test_label  = train_test_split(data,label, test_size=0.3, shuffle=True)

# 알고리즘 학습지 나열
clf = KNeighborsClassifier(n_neighbors=17)

# 학습
clf.fit(train_data,train_label)

# 정답률
results = clf.predict(test_data)    # 모의고사 답안 제출
score = metrics.accuracy_score(results, test_label)

print("정달률 : %5.2f %%" % (score*100))

# 정답률에 따른 save
import joblib
joblib.dump(clf, "ai_KNN_JB_data" + str(int(score*100)) + ".dmp")
