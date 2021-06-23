import cv2
import numpy as np

## 중요 함수 : 이미지에서 사물을 찾아서, 사물의 영역 표시 및 확률 ##
def ssdNet(image) :
    CONF_VALUE = 0.5 # 사물을 찾은 후 정확도 --> 50%는 넘는 것만 찾아라. (조절 가능)
    CLASSES = ["background", "aeroplane", "bicycle", "bird", "boat",
               "bottle", "bus", "car", "cat", "chair", "cow", "diningtable",
               "dog", "horse", "motorbike", "person", "pottedplant", "sheep",
               "sofa", "train", "tvmonitor"]
    COLORS = np.random.uniform(0, 255, size = (len(CLASSES),3)) # 각 R,G,B 칼라 추출
    # Pre-Train Data 로딩 --> 인공지능
    aiModel = cv2.dnn.readNetFromCaffe("MobileNetSSD_deploy.prototxt.txt", "MobileNetSSD_deploy.caffemodel")
    (h, w) = image.shape[:2] # 이미지 폭, 높이
    # 입력 이미지를 MobileNetSSD가 판단할 수 있는 형태로 변경
    blob = cv2.dnn.blobFromImage(cv2.resize(image,(300,300)), 0.007843, (300,300), 127.5)
    aiModel.setInput(blob) # AI에게 변형된 이미지를 입력
    detections = aiModel.forward() # AI야. 너가 찾을 수 있는 거 다 찾아봐.
    ## 찾은 사물을 모두 이미지에 표시하기.
    for i in np.arange(0, detections.shape[2]) :  # 찾은 사물 개수만큼 반복
        confidence = detections[0,0, i, 2] # 찾은 사물의 정확도
        if confidence > CONF_VALUE : # 정확도가 지정한 것보다 큰것만 처리
            idx = int(detections[0,0,i,1]) # CLASSES중 어떤 사물인지 위치
            box = detections[0,0,i,3:7] * np.array(([w,h,w,h])) # 이미지에 표시할 사각형 추출
            (startX, startY, endX, endY) = box.astype("int")  # 사각형의 실제 왼쪽위, 오른쪽 아래 좌표
            label = "{}: {:.2f}%".format(CLASSES[idx], confidence*100)
            cv2.rectangle(image, (startX, startY), (endX, endY), COLORS[idx], 2)
            y = startY - 15 if startY - 15 > 15 else startY + 15
            cv2.putText(image, label, (startX, y),
                        cv2.FONT_HERSHEY_SIMPLEX, 0.5, COLORS[idx], 2)

    return image


### 메인 코드 ###
filename = 'C:/img/images(DL)/example_05.jpg'
cvImage = cv2.imread(filename)

## 딥러닝 기반의 사물 인식 (MobileNetSSD) ###
retImage = ssdNet(cvImage)

cv2.imshow('DeepLearning', retImage)
cv2.waitKey(0)
cv2.destroyWindow()