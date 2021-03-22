# Download the helper library from https://www.twilio.com/docs/python/install
import pyodbc
from twilio.rest import Client

def takeVacant(type_user):
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    cursor.execute("SELECT "+type_user+" FROM Parking_Slot")
    count = cursor.fetchone()
    if type_user == "Employee_Car":
        vacant = 60 - count[0]
        vehicle = "Car"
    if type_user == "Student_Motor":
        vacant = 60 - count[0]
        vehicle = "Employee Motorcycle"
    if type_user == "Employee_MotoR":
        vacant = 24 - count[0]
        vehicle = "Student Motorcycle"
    return str(vacant),vehicle

def takeVehicleOwners(type_user):
    cnxn = pyodbc.connect(
        'DRIVER=FreeTDS;SERVER=RNR\SQLEXPRESS;PORT=1433;DATABASE=PARKING_MANAGEMENT;UID=sa;PWD=noname101;TDS_Version=8.0;')
    cursor = cnxn.cursor()
    data = cursor.execute("SELECT Contacts FROM VEHICLE_OWNER")
    for mob in data:
        sendSMS(str(mob[0]),type_user)

def sendSMS(contact_Number, type_user):
    print(contact_Number)
    vacant,vehicle = takeVacant(type_user)
    # Your Account Sid and Auth Token from twilio.com/console
    # and set the environment variables. See http://twil.io/secure
    account_sid = 'AC06b4689718c5c22ab37d922a3709c66c'
    auth_token = 'a376539cb7a53b4150e7a0fe8c24e8dd'
    client = Client(account_sid, auth_token)

    message = client.messages \
        .create(
             body='AVAILABLE '+vehicle+' PARKING SPACE: '+vacant,
             from_='+14697784836',
             to= contact_Number,
         )

    print(message.sid)


