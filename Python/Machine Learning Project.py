#KNN 알고리즘
from sklearn.neighbors import KNeighborsClassifier
#SVM 알고리즘
from sklearn import svm
from sklearn.model_selection import train_test_split
#일반 유용
from sklearn import metrics, utils
import pandas as pd
#데이터 가져오기
df = pd.read_csv("winequality-white.csv")
data = df.iloc[:, 0:-1]
label = df.iloc[:, [-1]]
#훈련데이터, 테스트 데이터, 훈련 정답, 테스트 정답 분리(훈련:테스트 = 7:3)
train_data, test_data, train_label, test_label = train_test_split(data, label, test_size=0.3, shuffle=True)

# 알고리즘 학습지 나열
clf_SVM = svm.SVC(gamma='auto')
clf_KNN = KNeighborsClassifier(n_neighbors=5)

# 학습
clf_KNN.fit(train_data, train_label)
clf_SVM.fit(train_data, train_label)

#정답률
#KNN
results_KNN = clf_KNN.predict(test_data) #모의고사 답안제출
score_KNN = metrics.accuracy_score(results_KNN, test_label)
#SVM
results_SVM = clf_SVM.predict(test_data)
score_SVM = metrics.accuracy_score(results_SVM,test_label)

print("KNN 정답률 : %5.2f %%" % (score_KNN*100))
print("CVM 정답률 : %5.2f %%" % (score_SVM*100))


#정답률에 따라 save
import joblib
joblib.dump(clf_KNN, "ai_wineWhite_" + str(int(score_KNN*100)) + "_KNN.dmp")
joblib.dump(clf_SVM, "ai_wineWhite_" + str(int(score_SVM*100)) + "_SVM.dmp")