# =============================================================================
# String: Split and Join
# =============================================================================
s = 'Python for Finance, 2nd Edition'
print(s)
print(s.split())
print(s.split(','))
print()

parts = s.split(',')
print(parts[0])
print(parts[1])
print()

title = '--'.join(parts)
print(title)