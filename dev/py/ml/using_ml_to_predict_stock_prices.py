# =============================================================================
# Dependencies
# =============================================================================
# python -m pip install --upgrade pip
# pip install quandl
# pip install numpy
# pip install sklearn

# =============================================================================
# Using ML to predict stock prices
# =============================================================================
import quandl
import numpy as np
from sklearn.linear_model import LinearRegression
from sklearn.svm import SVR
from sklearn.model_selection import train_test_split

# Get stock data ****** df = dataframe
df = quandl.get("WIKI/FB")
# Print sample
print(df.head())

# Get Adj. Close Price (note the space after Adj. )
df = df[['Adj. Close']]
# Print sample
print(df.head())

# Get Adj. Close Price (note the space after Adj. )
df = df[['Adj. Close']]
# Print sample
print(df.head())

# Predict n days out into the future
forecast_out = 30
# Create column (the target or dependent variable) shifted n units up
df['Prediction'] = df[['Adj. Close']].shift(-forecast_out)
# Print the new dataset
# print(df.head())
print(df.tail())

### Create the independent dataset x ###
# Convert the dataframe to a numpy array
X = np.array(df.drop(['Prediction'],1))
# Remove the last n rows
X = X[:-forecast_out]
print(X)

### Create the dependent dataset y ###


# =============================================================================
# References
# =============================================================================
"""
    1. https://colab.research.google.com/
    2. Build A Stock Prediction Program: https://www.youtube.com/watch?v=EYnC4ACIt2g
"""
