# =============================================================================
# String: Overview
# =============================================================================

print('Hello, World.'.swapcase())
print('Hello, World. {}'.format(3 * 5))
print(f'Hello, World. {3 * 5}')
print(  """
            Hello,
            World!
            
            {}
        """.format(3 * 5))

# -----------------------------------------------------------------------------
# 
# -----------------------------------------------------------------------------
class My_String(str):
    def __str__(self):
        return self[::-1]

s = My_String('Hello, World!')
print(s)