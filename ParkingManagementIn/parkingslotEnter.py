import pyodbc
import messaging

cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
cursor = cnxn.cursor()

def availSpace(type_user, count):
    cursor.execute("UPDATE Parking_Slot SET "+type_user+"="+str(count))
    cursor.commit()
    messaging.takeVehicleOwners(type_user)

def enterPremise(position, Vehicle_Type):
    #print("Slut")
    if position == "Faculty" and Vehicle_Type == "Motorcycle":
        cursor.execute("SELECT Employee_MotoR FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Employee_MotoR", count[0])
    elif position == "Faculty" and Vehicle_Type == "Car":
        cursor.execute("SELECT Employee_Car FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Employee_Car", count[0])
    elif position == "Student" and Vehicle_Type == "Motorcycle":
        cursor.execute("SELECT Student_Motor FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Student_Motor", count[0])
    elif position == "Student" and Vehicle_Type == "Car":
        cursor.execute("SELECT Employee_Car FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Employee_Car", count[0])
    elif position == "Staff" and Vehicle_Type == "Car":
        cursor.execute("SELECT Employee_Car FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Employee_Car", count[0])
    elif position == "Staff" and Vehicle_Type == "Motorcycle":
        cursor.execute("SELECT Employee_MotoR FROM Parking_Slot")
        count = cursor.fetchone()
        print(count[0])
        count[0] += 1
        availSpace("Employee_MotoR", count[0])