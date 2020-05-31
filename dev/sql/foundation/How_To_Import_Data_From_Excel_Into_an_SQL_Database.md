# How to Import Data from Excel into an SQL Database

### Tips
- Use the first row in the Excel spreadsheet as your hearder
- Multiple sheets in the same Excel file can be used to create corresponding tables in the database
- The SQL Server Import and Export Wizard doesn't appear to have an optoin to add a primay key, so I would recommended adding an ID column in Excel and populate with row numbers, then use the Table Designer in SSMS to make it an Identity field (column) and define a Primary Key (based on your table database design)

### Issues Encountered
1. The operation could not be completed: 'The Microsoft.ACE.OLEDB.16.0' provider is not registered on the local machine (System.Data)
2. The 'Chose a Destination' dialog box in the 'SQL Server Import and Export Wizard' did not show an option to use SQL Authentication

### Resolutions
1. Download and install the appropriate version of the Microsoft Access Database Engine 2016 Redistributable from: https://www.microsoft.com/en-us/download/details.aspx?id=54920 (that is, if you are using the 32-bit version of SSMS, you must install the 32-bit version of ACE
2. Simply select another 'Destination', then re-select SQL Server Native Client

### Using the SQL Server Import and Export Wizard
1. Launch Microsoft SQL Server Management Studio (SSMS)
2. Create a new database (or use an existing one)
4. Right-click the database and select Tasks\Import Data\Next
4. Data Source: Microsoft Excel
5. Browse\find and select your Excel file\Open
6. Excel version: Microsoft Excel 2016 (even though I'm running O365, I selected the 2016 option)
7. Leave 'First row has column names' if this applies to you\Next
8. Destination: SQL Server Native Client 11.0
9. Server name: your database sever should populate automatically
10. Select your authentication preference (Windows or SQL Server Authentication)
11. Enter credentials if necessary (see #2 issue/resolution above if you don't see this option)\Next
12. Copy data from one or more tables or views\Next
13. Ensure your table appears and is checked
It is a good idea to rename the destination, i.e. remove the trailing $
14. It is also strongly recommended that you select both the 'Edit Mappings' and Preview button to review the datatypes for each field
15. Run immediately\Next\Finish
16. Review the Report
17. Close
18. Return to SSMS and confirm that data was imported successfully