import cv2
import numpy as np
import face_recognition
import time
import requests
import pyodbc
import os
import pickle
import timelogOut
import parkingslotLeave
import servoParkingManagement
import pymsgbox

def enableSystem():
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    try:
        cursor.execute("SELECT Status FROM Security_Staff WHERE Status = 1")
        enable = cursor.fetchone()
        print(enable[0])
        return True
    except TypeError:
        return False
    

def takePicturePlateNumber():
    try:
        cap = cv2.VideoCapture("/dev/v4l/by-path/platform-3f980000.usb-usb-0:1.3:1.0-video-index0")
        ret, frame = cap.read()
        cv2.waitKey(1)
        image = "LicPlateImages/capture.jpg"
        cv2.imwrite(image, frame)
        cap.release()
    except:
        pymsgbox.alert('Camera for Plate Number not found!', 'Alert!',timeout=5000)
        main()
        


def plateNumberRecognition():
    takePicturePlateNumber()
    with open('LicPlateImages/capture.jpg', 'rb') as fp:
        response = requests.post(
            'https://api.platerecognizer.com/v1/plate-reader/',  # Request to API Plate Number
            data=dict(regions='ph'),  # Optional
            files=dict(upload=fp),
            headers={'Authorization': 'Token 284c7114ef59c8f6a7e2ad9cf4c51fb5319a49c0'})  # Set token given by the API
    plateNumber = response.json()  # return JSON
    try:
        plateNumberVal = plateNumber['results'][0]['plate']  # Get Plate Number Value
        print("Plate Number: " + str(plateNumberVal).upper())
        checkPlateNumber(plateNumberVal)  # Send the Plate Number Value to check if the plate number is registered
    except:
        plateNumberRecognition()  # Return to main if no plate number detected or captured


def checkPlateNumber(val):
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    img = cv2.imread('LicPlateImages/capture.jpg')
    try:
        cursor.execute("SELECT VEHICLE_OWNER.Id_Number, CREDENTIALS.PlateID, VEHICLE_OWNER.Position, CREDENTIALS.Vehicle_Type FROM VEHICLE_OWNER JOIN CREDENTIALS ON CREDENTIALS.Id_Number = VEHICLE_OWNER.Id_Number WHERE CREDENTIALS.PlateID = '" + val + "'")
        data = cursor.fetchone()
        print(data[1])
        cv2.rectangle(img, (50, 50), (img.shape[1] - 120, img.shape[2] + 15), (0, 225, 0), cv2.FILLED)
        cv2.putText(img, 'PLATE NUMBER RECOGNIZED', (50, 50), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        cv2.rectangle(img, (50, 100), (img.shape[1] - 400, img.shape[2] + 65), (0, 0, 0), cv2.FILLED)
        cv2.putText(img, val.upper(), (50, 100), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        img = cv2.copyMakeBorder(img, 30, 30, 30, 30, cv2.BORDER_CONSTANT, value=[2, 48, 15])
        cv2.namedWindow('Plate Recognition')
        cv2.moveWindow('Plate Recognition', 450, 150)
        cv2.imshow('Plate Recognition', img)
        cv2.waitKey(3500)
        cv2.destroyWindow('Plate Recognition')
        faceRecognition(data[0], data[1], data[2], data[3])
    except TypeError:
        cv2.rectangle(img, (50, 50), (img.shape[1] - 50, img.shape[2] + 15), (0, 0, 255), cv2.FILLED)
        cv2.putText(img, 'PLATE NUMBER NOT RECOGNIZED', (50, 50), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 225),2,cv2.LINE_AA)
        cv2.rectangle(img, (50, 100), (img.shape[1] - 400, img.shape[2] + 65), (0, 0, 0), cv2.FILLED)
        cv2.putText(img, val.upper(), (50, 100), cv2.FONT_HERSHEY_DUPLEX, 1, (255, 255, 255),2,cv2.LINE_AA)
        img = cv2.copyMakeBorder(img, 30, 30, 30, 30, cv2.BORDER_CONSTANT, value=[2, 48, 15])
        cv2.namedWindow('Plate Recognition')
        cv2.moveWindow('Plate Recognition', 450, 150)
        cv2.imshow('Plate Recognition', img)
        cv2.waitKey(3500)
        cv2.destroyWindow('Plate Recognition')
        plateNumberRecognition()

def getImageEncode(ID):
    Encode = []
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    cursor.execute("SELECT Encode FROM Face_Encodings WHERE Id_Number='"+ID+"'")
    rows = cursor.fetchall()

    for each in rows:
        for face_stored_pickled_data in each:
            face_data = pickle.loads(face_stored_pickled_data)
        Encode.append(face_data)
    return Encode

def faceRecognition(ID, PlateID, position, Vehicle_Type):
    try:
        cap = cv2.VideoCapture("/dev/v4l/by-path/platform-3f980000.usb-usb-0:1.1.2:1.0-video-index0")
    
        while True:
            success, img = cap.read()
            sImage = cv2.resize(img, (0, 0), None, 0.5, 0.5)
            sImage = cv2.cvtColor(sImage, cv2.COLOR_BGR2RGB)

            facesCurrent = face_recognition.face_locations(sImage)
            encodeCurrent = face_recognition.face_encodings(sImage, facesCurrent)

            for encodes, faces in zip(encodeCurrent, facesCurrent):
                matches = face_recognition.compare_faces(getImageEncode(ID), encodes, tolerance=0.55)  # set tolerance lower for more accurate face comparison
                faceDistance = face_recognition.face_distance(getImageEncode(ID), encodes)  # 1the lower the faceDistance the closer the match
                index = np.argmin(faceDistance)
                print(faceDistance)
                cv2.imwrite('VehicleOwner/capture.jpg', img)
                y1, x2, y2, x1 = faces
                y1, x2, y2, x1 = y1 * 2, x2 * 2, y2 * 2, x1 * 2
                if matches[index]:
                    cap.release()
                    image = cv2.imread('VehicleOwner/capture.jpg')
                    cv2.rectangle(image, (x1, y1), (x2, y2), (0, 255, 0), 1)
                    cv2.rectangle(image, (x1 - 75, y2 + 35), (x2, y2), (0, 255, 0), cv2.FILLED)
                    cv2.putText(image, 'Authorized', (x1 - 69, y2 + 29), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                    cv2.rectangle(image, (x1, y2 + 70), (x2 + 15, y2 + 35), (0, 255, 0), cv2.FILLED)
                    cv2.putText(image, 'Person', (x1 + 6, y2 + 64), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                    image = cv2.copyMakeBorder(image, 30, 30, 30, 30, cv2.BORDER_CONSTANT, value=[2, 48, 15])
                    cv2.namedWindow('Face Recognition')
                    cv2.moveWindow('Face Recognition', 450, 150)
                    cv2.imshow('Face Recognition', image)
                    cv2.waitKey(10000)
                    cv2.destroyWindow('Face Recognition')
                    servoParkingManagement.servo()
                    timelogOut.createLog(PlateID)
                    parkingslotLeave.leavePremise(position, Vehicle_Type)
                    main()
                elif not matches[index]:
                    cap.release()
                    image = cv2.imread('VehicleOwner/capture.jpg')
                    cv2.rectangle(image, (x1, y1), (x2, y2), (0, 0, 255), 1)
                    cv2.rectangle(image, (x1 - 95, y2 + 35), (x2, y2), (0, 0, 255), cv2.FILLED)
                    cv2.putText(image, 'Unauthorized', (x1 - 89, y2 + 29), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                    cv2.rectangle(image, (x1, y2 + 70), (x2 + 15, y2 + 35), (0, 0, 255), cv2.FILLED)
                    cv2.putText(image, 'Person', (x1 + 6, y2 + 64), cv2.FONT_HERSHEY_COMPLEX, 1, (225, 255, 255))
                    image = cv2.copyMakeBorder(image, 30, 30, 30, 30, cv2.BORDER_CONSTANT, value=[2, 48, 15])
                    cv2.namedWindow('Face Recognition')
                    cv2.moveWindow('Face Recognition', 450, 150)
                    cv2.imshow('Face Recognition', image)
                    cv2.waitKey(10000)
                    cv2.destroyWindow('Face Recognition')
                    main()
    except:
        pymsgbox.alert('Camera for Face not found!', 'Alert!',timeout=5000)
        faceRecognition(ID, PlateID, position, Vehicle_Type)

def main():
    enable = enableSystem()
    if enable:
        plateNumberRecognition()
    else:
        pymsgbox.alert('No Guard On Duty!', 'Alert!',timeout=5000)
        main()
    
main()