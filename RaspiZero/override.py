import RPi.GPIO as GPIO
import time
import servoParkingManagement
GPIO.setmode(GPIO.BOARD)
GPIO.setup(22, GPIO.OUT)

def manualOverride():    
    if GPIO.input(22):
        print("Button Pressed!")
        servoParkingManagement.servoOpen()
        servoParkingManagement.servoClose()

