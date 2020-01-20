# =============================================================================
#
# =============================================================================
employee_number = " "
parts = ""

while employee_number != "":
    valid = False
    employee_number = input("Enter employee number (ddd-dd-dddd):")
    parts = employee_number.split('-')
    if len(parts) == 3:
        if len(parts[0]) == 3 and len(parts[1]) == 2 and len(parts[2]) == 4:
            if parts[0].isdigit() and parts[1].isdigit() and parts[2].isdigit():
                valid = True
    else:
        value = False
    print(valid)