import pyodbc
import servoParkingManagement
def parkingBarrier():
    conn = pyodbc.connect('DRIVER=FreeTDS;SERVER=RNR\SQLEXPESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    #conn = pyodbc.connect('DRIVER=FreeTDS;SERVER=sql5101.site4now.net;PORT=1433;DATABASE=DB_A6D6D2_Try;UID=DB_A6D6D2_Try_admin;PWD=palermo123;TDS_Version=8.0;')
    cursor = conn.cursor()
    cursor.execute("Select [State] From Parking_Barrier where [State]=1")
    State = cursor.fetchone()
    if State is not None:
        servoParkingManagement.servoOpen()
        servoParkingManagement.servoClose()
        cursor.execute("UPDATE Parking_Barrier SET State= 0")
        cursor.commit()
    else:
        pass
