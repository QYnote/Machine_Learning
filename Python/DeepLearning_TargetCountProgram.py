from tkinter.filedialog import  * # 파일 대화상자, GUI
import cv2
import numpy as np

def snapshot(f) :   # 캡쳐된 파일 저장
    cv2.imwrite('C:/img/video/capture' + '/maxPerson.png', f )
    
def fileSelect() :  # 검색할 영상 선택
    global fileName

    fileName = askopenfilename(parent=window,
                               filetypes=(('Video File', '*.mp4;*.avi; *.mov; *.wmv'), ('All File', '*.*')))
    label_status.config(text="'시작' 버튼을 눌러주세요")

def videoStart() :
    global highCount
    capture = cv2.VideoCapture(fileName)
    frameCount = 0
    maxCount = 0
    s_factor = 0.5  # 화면 비율 조절(변경 가능) - 지금 GUI에서는 안하는게 좋음
    # 변경 가능한 변수
    CONF_VALUE = 0.5  # 사물을 찾은 후 정확도 --> 50%는 넘는 것만 찾아라. (조절 가능)

    while True:
        ret, frame = capture.read()
        if not ret:
            break
        frameCount += 1

        if frameCount % 5 == 0:  # 건너뛰는 프레임(조절 가능)
            frame = cv2.resize(frame, None, fx=s_factor, fy=s_factor, interpolation=cv2.INTER_AREA)
            image = frame

            # AI 사용 준비물
            target = "person"  # 사람에 대한 추출
            args = {'image': frame, 'prototxt': "MobileNetSSD_deploy.prototxt.txt",
                    'model': "MobileNetSSD_deploy.caffemodel", 'confidence': CONF_VALUE}
            CLASSES = ["background", "aeroplane", "bicycle", "bird", "boat",
                       "bottle", "bus", "car", "cat", "chair", "cow", "diningtable",
                       "dog", "horse", "motorbike", "person", "pottedplant", "sheep",
                       "sofa", "train", "tvmonitor"]
            COLORS = np.random.uniform(0, 255, size=(len(CLASSES), 3))  # 각 R,G,B 칼라 추출

            # Pre-Train Data 로딩 --> 인공지능
            aiModel = cv2.dnn.readNetFromCaffe(args["prototxt"], args["model"])
            (h, w) = image.shape[:2]  # 이미지 폭, 높이

            # 입력 이미지를 MobileNetSSD가 판단할 수 있는 형태로 변경
            blob = cv2.dnn.blobFromImage(cv2.resize(image, (300, 300)), 0.007843, (300, 300), 127.5)
            aiModel.setInput(blob)  # AI에게 변형된 이미지를 입력
            detections = aiModel.forward()  # AI야. 너가 찾을 수 있는 거 다 찾아봐.

            count = 0
            ## 찾은 사물을 모두 이미지에 표시하기.
            for i in np.arange(0, detections.shape[2]):  # 찾은 사물 개수만큼 반복
                confidence = detections[0, 0, i, 2]  # 찾은 사물의 정확도
                if confidence > args['confidence']:  # 정확도가 지정한 것보다 큰것만 처리
                    idx = int(detections[0, 0, i, 1])  # CLASSES중 어떤 사물인지 위치
                    box = detections[0, 0, i, 3:7] * np.array(([w, h, w, h]))  # 이미지에 표시할 사각형 추출
                    (startX, startY, endX, endY) = box.astype("int")  # 사각형의 실제 왼쪽위, 오른쪽 아래 좌표
                    if CLASSES[idx] == target.strip():
                        count += 1

                    # 화면에 표시
                    label = "{}: {:.2f}%".format(CLASSES[idx], confidence * 100)
                    cv2.rectangle(image, (startX, startY), (endX, endY), COLORS[idx], 2)
                    y = startY - 15 if startY - 15 > 15 else startY + 15
                    cv2.putText(image, label, (startX, y),
                                cv2.FONT_HERSHEY_SIMPLEX, 0.5, COLORS[idx], 2)
            frame = image
            cv2.imshow('Video', frame)
            # 센 갯수가 최대라면 화면을 캡처
            if count > maxCount:
                maxCount = count
                snapshot(image)
                # 시작버튼 하단에 카운트가 가장 높은 장면 출력
                highCount = PhotoImage(file="C:/img/video/capture/maxPerson.png")
                labelPhoto_highCount.config(image=highCount)

            # ESC 입력시 중단
            c = cv2.waitKey(1)
            if c == 27:
                break

    cv2.destroyWindow('Video')
    label_status.config(text="완료되었습니다.")

# window
window = Tk()
window.title("TargetCount Program")   # 제목
window.geometry('700x600')
window.resizable(width=False, height=False)

# 버튼할당
BTN_fileSelect = Button(window, text="영상 선택", command=fileSelect)
BTN_start = Button(window, text="시작", command=videoStart)

BTN_fileSelect.pack()
BTN_start.pack()

# 검색할 사물 선택
listbox = Listbox(window, selectmode='extended', height=0)
listbox.insert(0, "person")
#["background", "aeroplane", "bicycle", "bird", "boat",
# "bottle", "bus", "car", "cat", "chair", "cow", "diningtable",
# "dog", "horse", "motorbike", "person", "pottedplant", "sheep",
# "sofa", "train", "tvmonitor"]

# 상태 Label
label_status = Label(window, text = "파일을 선택해 주세요.")
labelPhoto_highCount = Label(window)
label_status.pack()
labelPhoto_highCount.pack()

window.mainloop()