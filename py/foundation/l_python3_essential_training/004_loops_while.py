# =============================================================================
# Loop: While
# =============================================================================
password = 'P@ssw0rd'
guess = ''
is_authorized = False
attempts = 0
max_attempts = 5

while guess != password:
    attempts += 1
    if attempts == 3: 
        print('No 3 for you...')
        continue
    if attempts > max_attempts: 
        print('Intruder alert!')
        break
    guess = input(f"Attempt #: {attempts}. Password Please: ")
else:
    is_authorized = True
    print('Access granted...')