# AgOpenGPS-Server
This project is to provide supporting utilities for AgOpenGPS.

## Security ##

For the time being I have decided to use Okta for our security client. In order to authenticate you need to setup an Okta account. 

The setup is pretty easy, this [guide](https://developer.okta.com/quickstart/#/okta-sign-in-page/dotnet/aspnetcore) will walk you through creating an account and client.

You can use environment variables to configure the application once you have the Okta client setup.

```
    ASPNETCORE_ENVIRONMENT=Development
    OKTA__OKTADOMAIN=[YOUR_OCTKA_DOMAIN]
    OKTA__CLIENTID=[YOUR_OCTA_CLIENT_ID]
    OKTA__CLIENTSECRET=[YOUR_OKTA_CLIENT_SECRET]
```


