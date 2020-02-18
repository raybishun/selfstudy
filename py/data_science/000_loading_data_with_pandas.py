# =============================================================================
# Loading data with Pandas
# =============================================================================
import pandas as pd
csv_path = 'sp500_1_year.csv'
df=pd.read_csv(csv_path)

# Get first 5 rows of the dataframe
print(df.head())

# Get specific column(s)
print(df[['Close','Volume']])

# Use the df.ix() to get specific r/c
# *** noticed .ix() is deprecated
# *** replaced by .loc() or .iloc()
print('----------')
my_data = df.iloc[[1,0]]
print(my_data)