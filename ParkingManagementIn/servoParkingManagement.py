import pyodbc
import time
import pymsgbox

def servo():
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    cursor.execute("Update Parking_Barrier Set [State] = 1")
    cursor.commit()
    print("Barrier Open!")
    pymsgbox.alert('Parking Barrier Going Up!', 'Alert!',timeout=2000)
    time.sleep(9)
    print("Barrier Close!")
    pymsgbox.alert('Parking Barrier Going Down!', 'Alert!',timeout=2000)   
   