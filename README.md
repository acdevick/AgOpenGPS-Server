# AgOpenGPS-Server
This project is to provide supporting utilities for AgOpenGPS.

## Security ##

For the time being I have decided to use Okta for our security client. In order to authenticate you need to setup an Okta account. 

The setup is pretty easy, this [guide](https://developer.okta.com/quickstart/#/okta-sign-in-page/dotnet/aspnetcore) will walk you through creating an account and client.

You can use environment variables to configure the application once you have the Okta client setup.


|Env Variable|Value  |
|--|--|
| OKTA__OKTADOMAIN| [YOUR_OCTA_CLIENT_ID]|
| OKTA__CLIENTID| [client-secret] |
| OKTA__CLIENTSECRET| [YOUR_OKTA_CLIENT_SECRET]|

## Running Locally ##

To build and run the application issue the following commands in the ag-open-gps-web project directory from your terminal:

    dotnet build

    dotnet run

To run using docker-compose

    docker-compose up


    



