import pyodbc
from datetime import datetime

cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=sql5101.site4now.net;PORT=1433;DATABASE=DB_A6D6D2_Try;UID=DB_A6D6D2_Try_admin;PWD=palermo123;TDS_Version=8.0;')
cursor = cnxn.cursor()

# cursor.execute('INSERT INTO TEST (Id_Number,Img,PlateNumber) VALUES (?,?,?)',(6,m,None))
def activeStaff():
    cursor.execute('SELECT Staff_Id FROM Security_Staff WHERE Status = Active')
    staff = cursor.fetchone()
    return str(staff[0])

def setTime(time):
    timeSet = str(time.hour)+':'+str(time.minute)
    return timeSet

def setDate(date):
    dateSet = str(date.year)+'-'+str(date.month)+'-'+str(date.day)
    return dateSet

def timeIn(Log_Id,time):
    Time_in = setTime(time)
    cursor.execute('UPDATE LOG SET Time_in='+Time_in+'WHERE Log_Id='+Log_Id)
    cnxn.commit()

def timeOut(Log_Id,time):
    Time_out = setTime(time)
    cursor.execute('UPDATE LOG SET Time_out=' + Time_out+'WHERE Log_Id='+Log_Id)
    cnxn.commit()

def createLog(ID,date):
    cursor.execute('INSERT INTO LOG (Time_in,Time_out,Id_Number,Staff_Id,_Date) VALUES (?,?,?)',
                   (None, None, ID, activeStaff(), setDate(date)))
    cnxn.commit()

def timeLog(ID):
    dateTimeObj = datetime.now()
    try:
        cursor.execute('SELECT Log_Id FROM LOG WHERE Id_Number=' + ID + ' and Time_in is null and Time_out is null')
        logIn = cursor.fetchone()
        timeIn(str(logIn[0]),dateTimeObj)
    except TypeError:
        try:
            cursor.execute('SELECT Log_Id FROM LOG WHERE Id_Number=' + ID + ' and Time_in is not null and Time_out is null')
            logOut = cursor.fetchone()
            timeOut(str(logOut[0]),dateTimeObj)
        except TypeError:
            createLog(ID,dateTimeObj)
    finally:
        cnxn.close()


