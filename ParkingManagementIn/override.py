import RPi.GPIO as GPIO
import time
import servoParkingManagement
GPIO.setmode(GPIO.BCM)
GPIO.setup(18, GPIO.OUT)

def manualOverride():
    
    if GPIO.input(18):
        print("Button Pressed!")
        servoParkingManagement.servo()
                
                      

            
        
