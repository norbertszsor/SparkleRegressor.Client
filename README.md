# SparkleRegressor.Client

**Sparkle.Regressor.Client:** [Sparkle Core](https://github.com/norbertszsor/Sparkle.Core) provides a standalone DLL called [Sparkle.Regressor.Client](https://github.com/norbertszsor/SparkleRegressor.Client) that can be used independently in other projects to communicate with [Sparkle.Regressor](https://github.com/norbertszsor/Sparkle.Regressor). This enables seamless integration and interaction with the regression module in diverse applications.

## Configuration

Before using the SparkleRegressor.Client in your application, ensure you have configured the necessary settings. The client relies on a configuration section named "SRCSettings" in your appsettings.json file, or you can use the configuration builder to set it up. Here's an example configuration:

```json
"SRCSettings": {
  "BaseUrl": "http://localhost:8080",
  "AccessToken": "sr_a6pgo8edIH0d4qFg8AuWdV2YfcyW9cSM1kELcmFblI6Sqey6vkze9KsaXrUDE"
}
```

// In your ConfigureServices method in Startup.cs
```csharp
builder.Services.AddSparkleRegressorClient(builder.Configuration);
```

Ensure that the provided BaseUrl points to your SparkleRegressor API and AccessToken is a valid token for communication. If your API doesn't use an access token, you can omit this setting.


## Unit Testing

The SparkleRegressor.Client includes simple unit tests for dependency injection scenarios. These tests can serve as a reference for integrating the client into your application's testing suite.

## Environment Variable

For added flexibility, you can provide the ```SRC_ACCESS_TOKEN``` environment variable with a valid token. The client will use this token if the ```"AccessToken"``` setting is not provided in the configuration.

Feel free to adjust the configuration settings according to your specific requirements and ensure a smooth integration with SparkleRegressor.

## Version

The current version of SRC package can be found there [SRC Package](https://github.com/norbertszsor/SparkleRegressor.Client/pkgs/nuget/SparkleRegressor.Client)
