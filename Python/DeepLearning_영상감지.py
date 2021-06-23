import cv2
import numpy as np
import random, string

CONF_VALUE = 0

# 중요함수 : 이미지에서 사물을 찾아서 사물의 영역 표시 및 확률
def ssdNet(image):
    global CONF_VALUE

    CLASSES = ["background", "aeroplane", "bicycle", "bird", "boat",
               "bottle", "bus", "car", "cat", "chair", "cow", "diningtable",
               "dog", "horse", "motorbike", "person", "pottedplant", "sheep",
               "sofa", "train", "tvmonitor"]  # 고정된 내용
    COLORS = np.random.uniform(0, 255, size=(len(CLASSES), 3))  # 각 RPG 칼라 추출

    # Pre-Train Data 로딩
    aiModel = cv2.dnn.readNetFromCaffe("MobileNetSSD_deploy.prototxt.txt", "MobileNetSSD_deploy.caffemodel")
    (h, w) = image.shape[:2]  # 이미지 효과 넣기

    # 입력 이미지를 MibleNetSSD가 판단할 수 있는 형태로 변경
    blob = cv2.dnn.blobFromImage(cv2.resize(image, (300, 300)), 0.007843, (300, 300), 127.5)
    aiModel.setInput(blob)  # AI에게 변형된 이미지 입력
    detections = aiModel.forward()  # AI에게 찾을수 있는 것 다 찾기 명령

    # 찾은 사물을 모두 이미지에 표시하기.
    for i in np.arange(0, detections.shape[2]):  # 찾은 사물 개수만큼 반복
        confidence = detections[0, 0, i, 2]  # 찾은 사물의 정확도
        if confidence > CONF_VALUE:  # 정확도가 지정한 것 보다 큰 것만 처리
            idx = int(detections[0, 0, i, 1])  # CLASSES 중 어떤서물인지 위치
            box = detections[0, 0, i, 3:7] * np.array([w, h, w, h])  # 이미지에 표시할 사각형 추출
            (startX, startY, endX, endY) = box.astype("int")  # 사각형의 실제 왼쪽위, 오른쪽 아래 좌표
            label = "{}: {:.2f}%".format(CLASSES[idx], confidence * 100)

            cv2.rectangle(image, (startX, startY), (endX, endY), COLORS[idx], 2)
            y = startY - 15 if startY - 15 > 15 else startY + 15
            cv2.putText(image, label, (startX, y),
                        cv2.FONT_HERSHEY_SIMPLEX, 0.5, COLORS[idx], 2)
    return image

string_pool = string.ascii_letters  #대소문자 알파벳
i_fn = 0
def snapshot(f) :
    global i_fn
    sFn = 'C:/img/video/capture/' + random.choice(string_pool) + random.choice(string_pool) + str(i_fn) + '.png'
    cv2.imwrite(sFn, f)  # 경로에 face.png 로 저장해라
    i_fn += 1

#메인코드
fileName = 'C:/img/video/traffic.mp4'
capture = cv2.VideoCapture(fileName)
s_factor = 0.3 # 화면 비율 조절(변경 가능)
frameCount = 0

while True:
    ret, frame = capture.read()

    if not ret :
        break

    frameCount += 1
    if frameCount % 5 == 0 : # 건너뛰는 프레임 수 8
        frame = cv2.resize(frame, None, fx=s_factor, fy=s_factor, interpolation=cv2.INTER_AREA)

        #정지영상 딥러닝(1장짜리)
        retImage = ssdNet(frame)
        cv2.imshow('Video', retImage)   #프로그램 실행

        if key == ord('C') or key == ord('c'):
            snapshot(frame)

    key = cv2.waitKey(1)
    if key == 27 : #ESC
        break


capture.release()


