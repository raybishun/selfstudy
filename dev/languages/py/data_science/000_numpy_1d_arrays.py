# =============================================================================
# numpy: 1d arrays
# =============================================================================
import numpy as np
# elements must be of same datatype

a=np.array(['a', 'b', 'c'])

print(a)
print(type(a))
print(type(a[-1]))
print(a.dtype)
print(a.size)  # size of array
print(a.ndim) # number of dimensions
print(a.shape) # size of array in each dimension