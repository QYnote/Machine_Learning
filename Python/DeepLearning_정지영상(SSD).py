import cv2
import numpy as np
from tkinter import *
from tkinter.filedialog import  * # 파일 대화상자
from tkinter.simpledialog import *

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

def check() :
    global  CONF_VALUE

    value = askinteger("최소 정확도(%)", "값 입력", minvalue=0, maxvalue=100)
    CONF_VALUE = value  # 사물을 찾은 후 확률 --> 50%넘기는 것만 찾아라

    # 메인코드
    filename = 'C:/img/images(DL)/example_05.jpg'
    cvImage = cv2.imread(filename)

    # 딥러닝 기반 사물인식(MobileNetSSD)
    retImage = ssdNet(cvImage)

    cv2.imshow("DeepLearning", retImage)
    cv2.waitKey(0)
    cv2.destroyWindow()

window = Tk()
window.title("영상처리(Python) (Beta 1)")
window.geometry('700x600')
window.resizable(width=False, height=False)

button = Button(window, text= "사물 검출", command=check)


window.mainloop()

