# Introduction 
This project is an N-Tiered architected application with the design implementation to support a replaceable front end. Utilizing libraries, project references and Dependency Injection this application can have it's access point easily changed from any of the available methods supported in C# by simply replacing one project, and wiring the rest back up through project references and method calls. This allows a quick and easy transformation from on-prem to cloud to serverless applications.

# Getting Started
This application WILL NOT run completely locally due to it requiring a Database. The steps to produce that database and run it can be found in the DB folder of this repo. You will need to have the DB running, and this application running to access it's endpoints through Swagger.
