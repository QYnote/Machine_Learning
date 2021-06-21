import cv2 # OpenCV
import os   # 폴더 생성용
import random, string   # 파일 명
import datetime    #타이머용

string_pool = string.ascii_letters  #대소문자 알파벳
i_fn = 0
def snapshot(f) :
    global  i_fn
    sFn = 'C:/img/video/capture/' + random.choice(string_pool) + random.choice(string_pool) + str(i_fn) +'.png'
    cv2.imwrite(sFn, f)  # 경로에 face.png 로 저장해라
    i_fn += 1


#capture = cv2.VideoCapture(0)   #카메라
capture = cv2.VideoCapture('C:/img/video/faces.mp4')    #파일 열기 개념


start = datetime.datetime.now()
while True:
    ret, frame = capture.read() #ret : 제대로 읽히는 것 확인, frame : 프레임

    if not ret : #읽기 실패
        break

    cv2.imshow('Video', frame)  #화면에 출력

    key = cv2.waitKey(20)   # 20ms 만큼 멈춤 --> 조절 필요
    
    #부가기능
    if key == 27 : #ESC 키 = 27
        break
    if key == ord('C') or key ==ord('c') :  #c 키를 누르면 캡쳐
        if os.path.isdir('C:/img/video/capture') == False :
            os.mkdir('C:/img/video/capture')
        snapshot(frame)
    end = datetime.datetime.now()
    if((end-start).seconds >= 5) :  #5초 간격 캡쳐하기
        snapshot(frame)
        start = datetime.datetime.now()

capture.release()
cv2.destroyWindow('Video')
