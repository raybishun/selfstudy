# =============================================================================
# Collections: Nested Lists - Matrices and Cubes
# =============================================================================
"""
    Exampe of Matrices (seems to be a two-dimensional array)
    1   2   3
    4   5   6

    Exampe of Cubes (same number of rows as columns)
    1   2
    3   4

    1   2   3
    4   5   6
    7   8   9
"""
my_matrix = [[1, 2, 3],
            [4, 5, 6]]
print(my_matrix)

row_count = len(my_matrix)
print(row_count)

column_count = len(my_matrix[0])
print(column_count)

# r c 
print(my_matrix[0][0])
print(my_matrix[1][0])