# Azure Cosmos DB

### What Cosmos DB?
- A globally distributed, multi-model database server

### Features
1. Significantly more powerful and feature rich than Azure Storage Tables
2. Low latency
3. Highly available
4. Elastic scalability
5. Multi-modal
6. Provides single-digit-millisecond data access
7. Supports several API surfaces including: SQL, MongoDB, Cassandra, Table and Gremlin

### The CAP Theorem
1. Consistency - Each read operation returns the latest data (or an error)
2. Availability - Each request receives a valid response; however, may be actually contain the latest write
3. Partition Tolerance - The system continues to function even if packets are dropped or there is latency 
- Note however, you can only have 2 of the above 3
4. Cosmos DB can be configured using any 2 combination mentioned above

# References
1. Consistency levels in Azure Cosmos DB: https://docs.microsoft.com/en-us/azure/cosmos-db/consistency-levels
2. Getting Behind the 9-Ball: Cosmos DB Consistency Levels Explained: https://blog.jeremylikness.com/blog/2018-03-23_getting-behind-the-9ball-cosmosdb-consistency-levels/
3. CAP theorem: https://en.wikipedia.org/wiki/CAP_theorem
4. Getting started with SQL queries: https://docs.microsoft.com/en-us/azure/cosmos-db/sql-query-getting-started
5. Azure Cosmos DB.NET V3 SDK (Microsoft.Azure.Cosmos) examples for the SQL API: https://docs.microsoft.com/en-us/azure/cosmos-db/sql-api-dotnet-v3sdk-samples

# Appendix

### Create and run a new console app
- mkdir helloworld
- cd .\helloworld\
- dotnet new console
- dotnet build
- dotnet run