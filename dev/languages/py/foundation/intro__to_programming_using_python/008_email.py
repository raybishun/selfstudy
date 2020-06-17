import sys
import smtplib

# Message
msg = """From: From Peter Parker <tony.stark@marvel.com>
To: Bruce Wayne <bruce.wayne@dc.com>
Subject: SMTP Test Email

This is a test...ArithmeticError
"""
try:
    # Send Mail
    server = smtplib.SMTP('smtp.gmail.com',587)
    server.connect('smtp.gmail.com',587)
    server.ehlo()
    server.starttls()
    server.login("userName", "password")
    server.sendmail("tony.stark@marvel.com", "bruce.wayne@dc.com", msg)
    server.quit()
except:
    print(sys.exc_info()[0])