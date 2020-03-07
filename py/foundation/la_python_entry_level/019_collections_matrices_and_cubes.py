# =============================================================================
# Collections: Matrices & Cubes
# =============================================================================
"""
    Multidimensional Arrays

    Squares: 2 columns and 2 rows, i.e.:
        1 2
        3 4

    Cubes: Same number of columns as rows, i.e.:
        1 2 3
        4 5 6
        7 8 9
"""
my_matrix = [[1, 2, 3],
            [4, 5, 6]]
print(f'Rows: {len(my_matrix)}')    # returns --> 2
print(f'Cols: {len(my_matrix[0])}') # returns --> 3

# R & C
print(my_matrix[1][1]) # returns --> 5