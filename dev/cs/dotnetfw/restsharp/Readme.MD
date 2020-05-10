# Setup a simple REST API json-server

### Download and install Node.js
1. https://nodejs.org/
2. Accept the defaults during the installation

### Verify Node.js was installed successfullly
2. node --version
3. npm --version

### Use npm to install the REST API json-server
1. npm install -g json-server

### Setup REST API server prequisites
1. Create a working folder for the server, i.e. c:\json
2. Create a sample json file
3. Tip: Use something like: https://jsonlint.com/ to validate your json
3. Save the file as db.json

### Start the json-server
1. cd <path_where_db.json_exists>
2. json-server .\db.json

### Test the server
1. http://localhost:3000