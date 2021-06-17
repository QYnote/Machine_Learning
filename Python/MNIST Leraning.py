## MNIST 머신러닝 프로젝트 1 ##  --> 0~9까지 손글씨를 학습시켜서, 손글씨 구분하는 인공지능
from sklearn.neighbors import KNeighborsClassifier
from sklearn import metrics, utils
import pandas as pd
from sklearn.model_selection import train_test_split
# 0. 데이터 준비
df = pd.read_csv("train_1k.csv")  # 28x28 크기의 RAW 이미지 1000건.
# print(df.shape)
# 학습용 80%, 테스트용 20% 분리
data = df.iloc[: , 1:] # 데이터(문제) 전체
label = df.iloc[:, [0]] # 레이블(답) 전체
train_data, test_data, train_label, test_label \
    = train_test_split(data, label, test_size=0.2, shuffle=True)
# 1. 머신러닝 알고리즘 선택 (변경 후, 테스트...)
clf = KNeighborsClassifier(n_neighbors=3)
# 2. 학습시키기 ---> 오래 걸림
clf.fit(train_data, train_label)  # clf가 '모델', '인공지능'
# 3. 정답률 구하기 --> 몇점까리 모델이니?
results = clf.predict(test_data)
score = metrics.accuracy_score(results, test_label) # 채점하기
print("정답률 : %5.2f %%" % (score*100))
# 4. 결과 모델을 저장하기
import joblib
joblib.dump(clf, "ai_mnist_1k_knn_" + str(int(score*100)) + ".dmp")