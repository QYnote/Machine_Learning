import  pandas as pd
import numpy as np

#알고리즘
from sklearn.neighbors import KNeighborsClassifier
from sklearn import  metrics, utils
from sklearn import svm # SVM 알고리즘
from sklearn.model_selection import train_test_split

# 데이터 가져오기
df = pd.read_csv('iris2.csv')  # 알아서 제목 빼줌
data = df.iloc[: , 1:]
label = df.iloc[:, [0]]
# 한번에 훈련데이터, 테스트 데이터, 훈련 정답, 테스트 정답 분리해줌
train_data, test_data, train_label, test_label = train_test_split(data, label, test_size=0.2, shuffle=True)

clf = svm.SVC(gamma='auto') # 서포트 벡터 머신(SVC) 알고리즘 사용
clf.fit(train_data, train_label)    # 훈련

results = clf.predict(test_data)
score = metrics.accuracy_score(results, test_label)
print("정답률 : %5.2f %%" % (score*100))


# 3-1. 모델(인공지능) 저장 시켜놓기 --> 테스트마다 검색X 하기 위함
# ai_iris_95.dmp --> 95% iris 인공지능
import joblib
joblib.dump(clf, "ai_iris_" + str(int(score*100)) + ".dmp")


#테스트
##myData = [4.1, 3.3, 1.4, 0.2]
##result = clf.predict([myData])

##print("이 꽃은 %5.2f %%의 확률로 %s 입니다." % (score*100, result))