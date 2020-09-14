# Repository Pattern Implementation

### Steps
1. Create an Interface and add CRUD methods
2. Add a Repository class and implement the above mentioned Interface
3. All DbContext dependent code is added to only the Repository class
4. In the Controller, call the CRUD methods using the Interface
5. Resister the Interface and Repository in Startup.cs