import pyodbc
from datetime import datetime

cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
cursor = cnxn.cursor()

def activeStaff():
    cursor.execute('SELECT Staff_Id FROM Security_Staff WHERE Status = 1')
    staff = cursor.fetchone()
    return str(staff[0])

def setTime(time):
    timeSet = str(time.hour)+':'+str(time.minute)
    return timeSet

def setDate(date):
    dateSet = str(date.year)+'-'+str(date.month)+'-'+str(date.day)
    return dateSet

def createLog(PlateID):
    dateTimeObj = datetime.now()
    cursor.execute("UPDATE LOG SET Time_out = '"+setTime(dateTimeObj)+"' WHERE PlateID = '"+PlateID+"' and Time_out is null")
    cursor.commit()

