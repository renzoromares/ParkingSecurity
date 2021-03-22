import RPi.GPIO as GPIO
import time
import pyodbc

indicatorParkingSlot1 = 0
indicatorParkingSlot2 = 0
vipParkingSlotAvailable = 8;

GPIO.setmode(GPIO.BOARD)
GPIO.setup(18,GPIO.IN)  #parkingSlot1
GPIO.setup(16,GPIO.IN)  #parkingSlot2

print ("IR Sensor Ready")

def queryDatabase(count):   
    conn = pyodbc.connect('DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = conn.cursor()
    cursor.execute("UPDATE DB_A6D6D2_Try.dbo.Parking_Slot SET VIP=" + str(count))
    cursor.commit()
    cursor.close()
    
try: 
   while True:
      if GPIO.input(18) and indicatorParkingSlot1 == 0:
          print ("Parking Slot 1 Vehicle NOT detected!")
          indicatorParkingSlot1 = 1
          #vipParkingSlotAvailable +=1
          print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
          queryDatabase(vipParkingSlotAvailable)
          
          
      if not GPIO.input(18) and indicatorParkingSlot1 == 1:
          print ("Parking Slot 1 Vehicle detected!")
          indicatorParkingSlot1 = 0
          vipParkingSlotAvailable -=1
          print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
          queryDatabase(vipParkingSlotAvailable)
          
                      
      if GPIO.input(16) and indicatorParkingSlot2 == 0:
          print ("Parking Slot 2 Vehicle NOT detected!")
          indicatorParkingSlot2 = 1
          #vipParkingSlotAvailable +=1
          print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
          queryDatabase(vipParkingSlotAvailable)
          
      if not GPIO.input(16) and indicatorParkingSlot2 == 1:
          print ("Parking Slot 2 Vehicle detected!")
          indicatorParkingSlot2 = 0
          vipParkingSlotAvailable -=1
          print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
          queryDatabase(vipParkingSlotAvailable)
          

except KeyboardInterrupt:
    GPIO.cleanup()
