# Download the helper library from https://www.twilio.com/docs/python/install
import os
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
# and set the environment variables. See http://twil.io/secure
account_sid = 'AC06b4689718c5c22ab37d922a3709c66c'
auth_token = '1bdc108bb1d55b80d010328c0b9ec9f7'
client = Client(account_sid, auth_token)

message = client.messages \
    .create(
         body='Chupapi Munyanyo',
         from_='+14697784836',
         to='+639760076828'
     )

print(message.sid)
