# =============================================================================
# Panda: DataFrame - Unique
# =============================================================================
import pandas as pd
df=pd.DataFrame({'a':[11,21,31,11,21,31],'b':[21,22,23,21,22,23]})

# print(df.head())

# return true in column if >= 21
df1 = df['a'] >= 21
print(df1)

# save dataframe to a csv file
df1.to_csv('000_panda_dataframe_output.csv')

# find unique
df2 = df['a'].unique()
print(df2)