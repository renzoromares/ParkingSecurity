import cv2
import numpy as np
import face_recognition
import time
import requests
import pyodbc
import re

Encodes = []
ID = []

def takePicturePlateNumber():
    cap = cv2.VideoCapture(0)
    ret, frame = cap.read()
    (grabbed, frame) = cap.read()
    showimg = frame
    cv2.waitKey(1)
    image = "LicPlateImages/capture.png"
    cv2.imwrite(image, frame)
    cap.release()


def plateNumberRecognition():
    with open('LicPlateImages/capture.png', 'rb') as fp:
        response = requests.post(
            'https://api.platerecognizer.com/v1/plate-reader/',  # Request to API Plate Number
            data=dict(regions='ph'),  # Optional
            files=dict(upload=fp),
            headers={'Authorization': 'Token 2511c6f5b2f3b49a69ec305121be8dd4b023cf75'})  # Set token given by the API
    plateNumber = response.json()  # return JSON
    try:
        plateNumberVal = plateNumber['results'][0]['plate']  # Get Plate Number Value
        print("Plate Number: " + str(plateNumberVal).upper())
        checkPlateNumber(plateNumberVal)  # Send the Plate Number Value to check if the plate number is registered
    except:
        main()  # Return to main if no plate number detected or captured


def checkPlateNumber(val):
    server = 'sql5101.site4now.net'
    database = 'DB_A6D6D2_Try'
    username = 'DB_A6D6D2_Try_admin'
    password = 'palermo123'
    cnxn = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';UID=' + username + ';PWD=' + password)
    cursor = cnxn.cursor()
    img = cv2.imread('LicPlateImages/capture.png')
    try:
        cursor.execute("SELECT PlateID FROM DB_A6D6D2_Try.dbo.VEHICLE_OWNER WHERE PlateID='" + val + "'")
        data = cursor.fetchone()
        print(data[0])
        cv2.rectangle(img, (50, 50), (img.shape[1] - 120, img.shape[2] + 15), (0, 225, 0), cv2.FILLED)
        cv2.putText(img, 'PLATE NUMBER RECOGNIZED', (50, 50), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        cv2.rectangle(img, (50, 100), (img.shape[1] - 400, img.shape[2] + 65), (0, 0, 0), cv2.FILLED)
        cv2.putText(img, val.upper(), (50, 100), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        cv2.imshow('Result',  img)
        cv2.waitKey(0)
        cv2.destroyWindow('Result')
        faceRecognition(data[0])
    except TypeError:
        cv2.rectangle(img, (50, 50), (img.shape[1] - 50, img.shape[2] + 15), (0, 0, 255), cv2.FILLED)
        cv2.putText(img, 'PLATE NUMBER NOT RECOGNIZED', (50, 50), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 225),2,cv2.LINE_AA)
        cv2.rectangle(img, (50, 100), (img.shape[1] - 400, img.shape[2] + 65), (0, 0, 0), cv2.FILLED)
        cv2.putText(img, val.upper(), (50, 100), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        cv2.namedWindow('Result')
        cv2.moveWindow('Result', 40,30)
        cv2.imshow('Result', img)
        cv2.waitKey(0)
        cv2.destroyWindow('Result')

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