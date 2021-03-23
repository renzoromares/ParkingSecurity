import RPi.GPIO as GPIO
import time

def servoOpen():
    GPIO.setmode(GPIO.BOARD)          
    GPIO.setup(11, GPIO.OUT)     
    p = GPIO.PWM(11, 50)     
    p.start(0)      
    print("Barrier Open!")
    p.ChangeDutyCycle(7.5)  #to 90 degrees open
    time.sleep(0.8)
    p.stop()

    
def servoClose():
    time.sleep(9)
    GPIO.setmode(GPIO.BOARD)          
    GPIO.setup(11, GPIO.OUT)     
    p = GPIO.PWM(11, 50)     
    p.start(0)      
    print("Barrier Close!")
    p.ChangeDutyCycle(2.5)  #to 90 degrees open
    time.sleep(1)
    
    
  
