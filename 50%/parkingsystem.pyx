import pyodbc
import cv2
import face_recognition
import numpy as np
import os

Encodes = []
ID = []

def getImage():
    server = 'sql5101.site4now.net'
    database = 'DB_A6D6D2_Try'
    username = 'DB_A6D6D2_Try_admin'
    password = 'palermo123'
    cnxn = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';UID=' + username + ';PWD=' + password)
    cursor = cnxn.cursor()
    data = cursor.execute("SELECT Face_Image,PlateID FROM CREDENTIALS")
    path = 'VehicleOwners'
    for fp in data:
        with open(path + '/' + fp[1] +'.png', 'wb') as f:
            f.write(fp[0])
    print('Query Done')

def getImageEncode():
    path = 'VehicleOwners'
    dirs = os.listdir(path)
    for li in dirs:
        image = cv2.imread(path + '/' + li)
        image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
        encode = face_recognition.face_encodings(image)[0]
        Encodes.append(encode)
        plate = li.split('.')
        ID.append(plate[0])
    print('Encodes Done')

def faceRecognition(PlateID):
    indicator = False
    i = ID.index(PlateID)
    cap = cv2.VideoCapture(0)
    while True:
        success, img = cap.read()
        sImage = cv2.resize(img, (0, 0), None, 0.25, 0.25)
        sImage = cv2.cvtColor(sImage, cv2.COLOR_BGR2RGB)

        facesCurrent = face_recognition.face_locations(sImage)
        encodeCurrent = face_recognition.face_encodings(sImage, facesCurrent)

        for encodes, faces in zip(encodeCurrent, facesCurrent):
            matches = face_recognition.compare_faces([Encodes[i]], encodes, tolerance=0.5)  # set tolerance lower for more accurate face comparison
            faceDistance = face_recognition.face_distance([Encodes[i]], encodes)  # the lower the faceDistance the closer the match
            index = np.argmin(faceDistance)
            print(faceDistance)
            y1, x2, y2, x1 = faces
            y1, x2, y2, x1 = y1 * 4, x2 * 4, y2 * 4, x1 * 4
            if matches[index]:
                cv2.rectangle(img, (x1, y1), (x2, y2), (0, 255, 0), 1)
                cv2.rectangle(img, (x1 - 75, y2 + 35), (x2, y2), (0, 255, 0), cv2.FILLED)
                cv2.putText(img, 'Authorized', (x1 - 69, y2 + 29), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                cv2.rectangle(img, (x1, y2 + 70), (x2 + 15, y2 + 35), (0, 255, 0), cv2.FILLED)
                cv2.putText(img, 'Person', (x1 + 6, y2 + 64), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                cv2.imwrite('VehicleOwner/capture.png', img)
                indicator = True
                break
        if not indicator:
            cv2.rectangle(img, (x1, y1), (x2, y2), (0, 0, 255), 1)
            cv2.rectangle(img, (x1 - 95, y2 + 35), (x2, y2), (0, 0, 255), cv2.FILLED)
            cv2.putText(img, 'Unauthorized', (x1 - 89, y2 + 29), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
            cv2.rectangle(img, (x1, y2 + 70), (x2 + 15, y2 + 35), (0, 0, 255), cv2.FILLED)
            cv2.putText(img, 'Person', (x1 + 6, y2 + 64), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
            cv2.imwrite('VehicleOwner/capture.png', img)
            break
        if indicator:
            break
    cap.release()
    image = cv2.imread('VehicleOwner/capture.png')
    cv2.imshow('Result', image)
    cv2.waitKey(3000)
    faceRecognition('VFU993')
def main():
    getImage()
    getImageEncode()
    faceRecognition('TY1680')

main()