import RPi.GPIO as GPIO
import time
import pyodbc
import override
import ParkingBarrierState

indicatorParkingSlot1 = 0
indicatorParkingSlot2 = 0
vipParkingSlotAvailable = 0
GPIO.setmode(GPIO.BOARD)
GPIO.setup(18,GPIO.IN)  #parkingSlot1
GPIO.setup(16,GPIO.IN)  #parkingSlot2
def queryDatabase(count):   
    conn = pyodbc.connect('DRIVER=FreeTDS;SERVER=RNR\SQLEXPESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    #conn = pyodbc.connect('DRIVER=FreeTDS;SERVER=sql5101.site4now.net;PORT=1433;DATABASE=DB_A6D6D2_Try;UID=DB_A6D6D2_Try_admin;PWD=palermo123;TDS_Version=8.0;')
    cursor = conn.cursor()
    cursor.execute("UPDATE Parking_Slot SET VIP=" + str(count))
    cursor.commit()
    cursor.close()
def ParkingSpaceVIP():
    global indicatorParkingSlot1 
    global indicatorParkingSlot2 
    global vipParkingSlotAvailable 
    if GPIO.input(18) and indicatorParkingSlot1 == 0:
        print ("Parking Slot 1 Vehicle NOT detected!")
        indicatorParkingSlot1 = 1
        vipParkingSlotAvailable +=1
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
        vipParkingSlotAvailable +=1
        print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
        queryDatabase(vipParkingSlotAvailable)         
    if not GPIO.input(16) and indicatorParkingSlot2 == 1:
        print ("Parking Slot 2 Vehicle detected!")
        indicatorParkingSlot2 = 0
        vipParkingSlotAvailable -=1
        print("VIP Parking Slot available: " + str(vipParkingSlotAvailable))
        queryDatabase(vipParkingSlotAvailable)
    
def main():
    while True:
        ParkingSpaceVIP()
        override.manualOverride()
        ParkingBarrierState.parkingBarrier()
main()