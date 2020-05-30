# How to Import Data from Excel into an SQL Database

### Tips
- Ensure your Excel Spreadsheet uses the first row as a header
- Multiple sheets in the same file will create corresponding  tables

### Issues Encountered
1. The operation could not be completed: 'The Microsoft.ACE.OLEDB.16.0' provider is not registered on the local machine (System.Data)

2. Select a different provider, then re-select SQL Server Native Client


### Resolution
2. Download and install the Microsoft Access Database Engine 2016 Redistributable from: https://www.microsoft.com/en-us/download/details.aspx?id=54920

### Option 1 of 2
1. Launch Microsoft SQL Server Management Studio (SSMS)
2. Create a database
4. Select the database\Tasks\Import Data\Next
4. Data Source: Microsoft Excel
5. Browse\find and select your Excel file\Open
6. Excel version: Microsoft Excel 2016 (in my case)
7. Leave 'First row has column names' if this applies to you\Next
8. Destination: SQL Server Native Client 11.0
9. Server name: your database sever should populate automatically
10. Select your authentication preference
11. Select the destination database
12. Copy data from one or more tables or views
13. Ensure your table appears and is selected
14. It is strongly recommended that you select both the 'Edit Mappings' and Preview button to review the datatypes for each field
15. Run immediately\Next\Finish
16. Review the Report
17. Close
18. Return to SSMS and confirm that data was imported successfully