# =============================================================================
# numpy: 2d arrays
# =============================================================================
import numpy as np
# elements must be of same datatype

a=np.array([[11, 12, 13], 
            [21, 22, 23], 
            [31, 32, 33]])

print(a)
print(a.dtype)
print(a.size) # size of array
print(a.ndim) # number of dimensions
print(a.shape) # size of array in each dimension