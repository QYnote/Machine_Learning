import joblib
clf = joblib.load("ai_wineWhite_57_SVM.dmp")

myData = [7,0.27,0.36,20.7,0.045,45,170,1.001,3,0.45,8.8]
result = clf.predict([myData])
print("이 Wine등급은 %s 입니다." % result)
print("종료")