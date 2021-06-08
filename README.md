# Getting Started with Lacework API 2.0 Documentation

## Getting Started

### Introduction

The Lacework API documentation is available directly from your Lacework Application at the following URI:
`https://YourLacework.lacework.net/api/v2/docs`, where `YourLacework` is your Lacework Application.

No login to the Lacework Console is required. However, there is a link to the Lacework API 2.0 documentation from the
Lacework Console. From the **Help** drop-down, select **API 2.0 Documentation**.

You can run the Lacework APIs using your favorite REST API tools such as curl or Postman. Example curl commands are listed in the API 2.0 documentation provided by the **Help** > **API** 2.0 Documentation menu option in the Lacework Console.

You can also run the Lacework API from the Lacework CLI command. For more information, see the
[CLI Documentation](https://github.com/lacework/go-sdk/wiki/CLI-Documentation).

### Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (LaceworkAPI20Documentation.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

### Installation

The following section explains how to use the LaceworkAPI20Documentation.Standard library in a new project.

#### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=createProject)

#### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=setStartup)

#### 3. Add reference of the library project

In order to use the Tester library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `Tester.Tests` and click `OK`. By doing this, we have added a reference of the `Tester.Tests` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=createReference)

#### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Lacework%20API%202.0%20Documentation-CSharp&workspaceName=LaceworkAPI20Documentation&projectName=LaceworkAPI20Documentation.Standard&rootNamespace=LaceworkAPI20Documentation.Standard&step=addCode)

### Initialize the API Client

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `DefaultHost` | `string` | *Default*: `"www.example.com"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
LaceworkAPI20Documentation.Standard.LaceworkAPI20DocumentationClient client = new LaceworkAPI20Documentation.Standard.LaceworkAPI20DocumentationClient.Builder()
    .Environment(Environment.Production)
    .DefaultHost("www.example.com")
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

Parameters for retries can be configured through the HttpClientConfiguration in the API Client:

| Parameters | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `NumberOfRetries` | `int` | Number of times the request is retried.<br>*Default*: `0` |
| `BackoffFactor` | `int` | Exponential backoff factor for duration between retry calls.<br>*Default*: `2` |
| `RetryInterval` | `double` | The time interval between the endpoint calls.<br>*Default*: `1` |
| `BackoffMax` | `TimeSpan` | The maximum back off time.<br>*Default*: `TimeSpan.FromSeconds(0)` |
| `StatusCodesToRetry` | `IList<int>` | List of Http status codes to invoke retry.<br>*Default*: `new List<int> { 408, 413, 429, 500, 502, 503, 504, 521, 522, 524, }` |
| `RequestMethodsToRetry` | `IList<HttpMethod>` | List of Http request methods to invoke retry.<br>*Default*: `new List<string> { "GET", "PUT", }.Select(val => new HttpMethod(val))` |

## Client Class Documentation

### Lacework API 2.0 DocumentationClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

#### Controllers

| Name | Description |
|  --- | --- |
| ACCESSTOKENSController | Gets ACCESSTOKENSController controller. |
| SCHEMASController | Gets SCHEMASController controller. |
| AgentAccessTokensController | Gets AgentAccessTokensController controller. |
| AlertChannelsController | Gets AlertChannelsController controller. |
| AlertRulesController | Gets AlertRulesController controller. |
| AuditLogsController | Gets AuditLogsController controller. |
| CloudAccountsController | Gets CloudAccountsController controller. |
| CloudActivitiesController | Gets CloudActivitiesController controller. |
| ContainerRegistriesController | Gets ContainerRegistriesController controller. |
| ContractInfoController | Gets ContractInfoController controller. |
| ReportRulesController | Gets ReportRulesController controller. |
| ResourceGroupsController | Gets ResourceGroupsController controller. |
| TeamMembersController | Gets TeamMembersController controller. |
| UserProfileController | Gets UserProfileController controller. |

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| DefaultHost | DefaultHost value. | `string` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Lacework API 2.0 DocumentationClient using the values provided for the builder. | `Builder` |

### Lacework API 2.0 DocumentationClient Builder Class

Class to build instances of Lacework API 2.0 DocumentationClient.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |

## API Reference

### List of APIs

* [ACCESS TOKENS](#access-tokens)
* [SCHEMAS](#schemas)
* [Agent Access Tokens](#agent-access-tokens)
* [Alert Channels](#alert-channels)
* [Alert Rules](#alert-rules)
* [Audit Logs](#audit-logs)
* [Cloud Accounts](#cloud-accounts)
* [Cloud Activities](#cloud-activities)
* [Container Registries](#container-registries)
* [Contract Info](#contract-info)
* [Report Rules](#report-rules)
* [Resource Groups](#resource-groups)
* [Team Members](#team-members)
* [User Profile](#user-profile)

### ACCESS TOKENS

#### Overview

[Generate access tokens](https://support.lacework.com/hc/en-us//articles/360011403853)  for API requests.

##### Get instance

An instance of the `ACCESSTOKENSController` class can be accessed from the API Client.

```
ACCESSTOKENSController aCCESSTOKENSController = client.ACCESSTOKENSController;
```

#### Generate Access Tokens

Get access tokens for the API requests by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/access/tokens`

After creating a secret key, administrators can generate Temporary API access (bearer) tokens that are used by clients  and client applications to access the Lacework API. Temporary API access (bearer) tokens are created by invoking the `POST https://YourLacework.lacework.net/api/v2/access/tokens` endpoint.

:information_source: **Note** This endpoint does not require authentication.

```csharp
GenerateAccessTokensAsync(
    string xLWUAKS,
    string contentType,
    Models.ApiV2AccessTokensRequest body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xLWUAKS` | `string` | Header, Required | YourSecretKey |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.ApiV2AccessTokensRequest`](#api-v2-access-tokens-request) | Body, Required | - |

##### Response Type

[`Task<Models.ApiV2AccessTokensResponse>`](#api-v2-access-tokens-response)

##### Example Usage

```csharp
string xLWUAKS = "X-LW-UAKS4";
string contentType = "application/json";
var body = new ApiV2AccessTokensRequest();
body.KeyId = "YourSecretKey";
body.ExpiryTime = 3600;

try
{
    ApiV2AccessTokensResponse result = await aCCESSTOKENSController.GenerateAccessTokensAsync(xLWUAKS, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Access Key is null. | [`ApiV2AccessTokens400ErrorException`](#api-v2-access-tokens-400-error) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### SCHEMAS

#### Overview

Get details about the available Lacework schemas.

##### Get instance

An instance of the `SCHEMASController` class can be accessed from the API Client.

```
SCHEMASController sCHEMASController = client.SCHEMASController;
```

#### Schema Details

Get a list of available Lacework schema types by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/schemas`

Get details about a Lacework schema by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/schemas/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/schemas/AuditLogs`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SchemaDetailsAsync(
    string authorization,
    string contentType,
    string type)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | `string` | Template, Required | The schema type, or empty for a list of all schema types |

##### Response Type

`Task<object>`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string type = "AuditLogs";

try
{
    object result = await sCHEMASController.SchemaDetailsAsync(authorization, contentType, type);
}
catch (ApiException e){};
```

##### Example Response

```
[
  {
    "name": "accountName",
    "type": "string"
  },
  {
    "name": "createdTime",
    "type": "integer"
  },
  {
    "name": "eventDescription",
    "type": "string"
  },
  {
    "name": "eventName",
    "type": "string"
  },
  {
    "name": "userAction",
    "type": "string"
  },
  {
    "name": "userName",
    "type": "string"
  }
]
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Audits is invalid | [`ApiV2Schemas400ErrorException`](#api-v2-schemas-400-error) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Schema Details of Subtype

Get details about a Lacework schema by specifying a schema type and subtype  when invoking the endpoint.

> `GET https://YourLacework.lacework.net/api/v2/schemas/{type}/{subtype}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/schemas/AlertChannels/SlackChannel`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SchemaDetailsOfSubtypeAsync(
    string authorization,
    string contentType,
    string type,
    string subtype)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | `string` | Template, Required | the schema type |
| `subtype` | `string` | Template, Required | the subtype |

##### Response Type

`Task<object>`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string type = "AlertChannels";
string subtype = "SlackChannel";

try
{
    object result = await sCHEMASController.SchemaDetailsOfSubtypeAsync(authorization, contentType, type, subtype);
}
catch (ApiException e){};
```

##### Example Response

```
[
  {
    "required": [
      "type",
      "enabled",
      "name",
      "data"
    ],
    "properties": {
      "name": {
        "type": "string",
        "minLength": 1
      },
      "type": {
        "type": "string",
        "enum": [
          "SlackChannel"
        ]
      },
      "enabled": {
        "type": "number",
        "minimum": 0,
        "maximum": 1
      },
      "data": {
        "properties": {
          "slackUrl": {
            "type": "string",
            "pattern": "^https://hooks.slack.com([/][a-zA-Z0-9#-_]+)+$"
          }
        },
        "required": [
          "slackUrl"
        ],
        "additionalProperties": false,
        "type": "object"
      }
    }
  }
]
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid subtype | [`ApiV2Schemas400ErrorException`](#api-v2-schemas-400-error) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Agent Access Tokens

#### Overview

To connect to the Lacework instance, Lacework agents require  an [agent access token](https://support.lacework.com/hc/en-us/articles/360005318133).

##### Get instance

An instance of the `AgentAccessTokensController` class can be accessed from the API Client.

```
AgentAccessTokensController agentAccessTokensController = client.AgentAccessTokensController;
```

#### Create Agent Access Token

Create a new agent access token that is used by an agent to connect and send data to your Lacework instance, by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens`

Here is an example `body` payload:

> `{ "tokenAlias": "qa", "props": {"description":"QA group"} } }`

By default, if `tokenEnabled` is not set, the agent access token is enabled.

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateAgentAccessTokenAsync(
    string authorization,
    string contentType,
    Models.AgentAccessTokensCreateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.AgentAccessTokensCreateSchema`](#agent-access-tokens-create-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAgentAccessTokens>`](#response-agent-access-tokens)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new AgentAccessTokensCreateSchema();
body.TokenEnabled = "tokenEnabled4";
body.TokenAlias = "tokenAlias2";

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.CreateAgentAccessTokenAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Agent Access Tokens

Get a list of agent Access Tokens that are currently enabled in your Lacework instance, by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllAgentAccessTokensAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseAgentAccessTokensList>`](#response-agent-access-tokens-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAgentAccessTokensList result = await agentAccessTokensController.ListAllAgentAccessTokensAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "accessToken": "47d102752b57caa18b...",
      "createdTime": "2020-12-16T16:43:37.915Z",
      "props": "{\"CREATED_TIME\":1598530228648}",
      "tokenAlias": "Ops Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    },
    {
      "accessToken": "e2f32885791213cb41...",
      "createdTime": "2020-12-10T18:14:05.754Z",
      "props": "{\"CREATED_TIME\":1607624045577,\"DESCRIPTION\":\"testing agent\"}",
      "tokenAlias": "Dev Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Agent Access Tokens

Search all the enabled agent access tokens in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AgentAccessTokens/search`

To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

You can filter on the following fields:

* `accessToken`

* `createdTime`

* `tokenAlias`

* `tokenEnabled`

* `version`

Here is an example `body` payload:

> `{ "filters" : [ { "expression": "eq", "field": "tokenAlias", "value": "Eng" } ] }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchAgentAccessTokensAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAgentAccessTokensList>`](#response-agent-access-tokens-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAgentAccessTokensList result = await agentAccessTokensController.SearchAgentAccessTokensAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "accessToken": "47d102752b57caa18b...",
      "createdTime": "2020-12-16T16:43:37.915Z",
      "props": "{\"CREATED_TIME\":1598530228648}",
      "tokenAlias": "Ops Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    },
    {
      "accessToken": "e2f32885791213cb41...",
      "createdTime": "2020-12-10T18:14:05.754Z",
      "props": "{\"CREATED_TIME\":1607624045577,\"DESCRIPTION\":\"testing agent\"}",
      "tokenAlias": "Dev Agent",
      "tokenEnabled": "1",
      "version": "0.1"
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Agent Access Token Details

Get details about an agent access token  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`

You can get the `{id}` by invoking the `GET /api/v2/AgentAccessTokens` endpoint.  Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response.

:information_source: **Note** This endpoint does not require authentication.

```csharp
AgentAccessTokenDetailsAsync(
    string authorization,
    string contentType,
    string id)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `id` | `string` | Template, Required | Agent Access Token {id} |

##### Response Type

[`Task<Models.ResponseAgentAccessTokens>`](#response-agent-access-tokens)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string id = "id0";

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.AgentAccessTokenDetailsAsync(authorization, contentType, id);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Agent Access Token

Optionally update the `tokenEnabled`, `tokenAlias`, or `description`  settings of the passed in agent access token.  Update these settings by invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AgentAccessTokens/{id}`

You can get the agent access token id by calling the  `GET /api/v2/AgentAccessTokens` endpoint.

Replace `{id}` with the long hexadecimal access token identifier returned in the `accessToken`  field of the `GET /api/v2/AgentAccessTokens` endpoint response.

Here is an example `body` payload:

> `{ "tokenAlias": "Eng", "tokenEnabled": "1", "props": {"description":"Eng group"} } }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateAgentAccessTokenAsync(
    string authorization,
    string contentType,
    string id,
    Models.AgentAccessTokensUpdateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `id` | `string` | Template, Required | AgentAccessTokens {id} |
| `body` | [`Models.AgentAccessTokensUpdateSchema`](#agent-access-tokens-update-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAgentAccessTokens>`](#response-agent-access-tokens)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string id = "id0";
var body = new AgentAccessTokensUpdateSchema();

try
{
    ResponseAgentAccessTokens result = await agentAccessTokensController.UpdateAgentAccessTokenAsync(authorization, contentType, id, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "accessToken": "47d102752b57caa18b...",
    "createdTime": "2020-12-16T16:43:37.915Z",
    "props": "{\"CREATED_TIME\":1598530228648}",
    "tokenAlias": "Ops Agent",
    "tokenEnabled": "1",
    "version": "0.1"
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Alert Channels

#### Overview

Lacework combines [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194)  with [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733)  or [report rules](https://support.lacework.com/hc/en-us/articles/36004176675)  to provide a flexible method for routing alerts and reports.  <ul>  <li>For [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194), you define where to  send alerts or reports, such as to Jira, Slack, or email.</li>  <li>For [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733), you define information  about which alert types to send, such as critical and high severity compliance alerts.</li>  <li>For [report rules](https://support.lacework.com/hc/en-us/articles/36004176675), you define information about  which reports to send.</li>  </ul>

##### Get instance

An instance of the `AlertChannelsController` class can be accessed from the API Client.

```
AlertChannelsController alertChannelsController = client.AlertChannelsController;
```

#### Create Alert Channels

Create an alert channel by specifying parameters in the request body  when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateAlertChannelsAsync(
    string authorization,
    string contentType,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | `object` | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAlertChannels>`](#response-alert-channels)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseAlertChannels result = await alertChannelsController.CreateAlertChannelsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsS3",
    "data": {
      "s3CrossAccountCredentials": {
        "externalId": "123456",
        "roleArn": "arn:aws:iam::...",
        "bucketArn": "arn:aws:s3:::..."
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Alert Channels

Get a list of alert channels for the current user by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllAlertChannelsAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseAlertChannelsList>`](#response-alert-channels-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAlertChannelsList result = await alertChannelsController.ListAllAlertChannelsAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List Alert Channels by Type

Get a list of alert channels of the specified type by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/SlackChannel`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAlertChannelsByTypeAsync(
    string authorization,
    string contentType,
    Models.TypeEnum type)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | [`Models.TypeEnum`](#type) | Template, Required | Alert Channel Type |

##### Response Type

[`Task<Models.ResponseAlertChannelsList>`](#response-alert-channels-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
TypeEnum type = TypeEnum.VictorOps;

try
{
    ResponseAlertChannelsList result = await alertChannelsController.ListAlertChannelsByTypeAsync(authorization, contentType, type);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Alert Channels

Search alert channels by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchAlertChannelsAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAlertChannelsList>`](#response-alert-channels-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAlertChannelsList result = await alertChannelsController.SearchAlertChannelsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsS3",
      "data": {
        "s3CrossAccountCredentials": {
          "externalId": "123456",
          "roleArn": "arn:aws:iam::...",
          "bucketArn": "arn:aws:s3:::..."
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Test Alert Channels

Test the integration of an alert channel by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}/test`

:information_source: **Note** This endpoint does not require authentication.

```csharp
TestAlertChannelsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await alertChannelsController.TestAlertChannelsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Alert Channel Details

Get the details about an alert channel by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
AlertChannelDetailsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

##### Response Type

[`Task<Models.ResponseAlertChannels>`](#response-alert-channels)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    ResponseAlertChannels result = await alertChannelsController.AlertChannelDetailsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsS3",
    "data": {
      "s3CrossAccountCredentials": {
        "externalId": "123456",
        "roleArn": "arn:aws:iam::...",
        "bucketArn": "arn:aws:s3:::..."
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Alert Channels

Update an alert channel by specifying parameters in the request body  when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

In the request body, only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateAlertChannelsAsync(
    string authorization,
    string contentType,
    string intgGuid,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |
| `body` | `object` | Body, Required | Only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`. |

##### Response Type

[`Task<Models.ResponseAlertChannels>`](#response-alert-channels)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string intgGuid = "intgGuid8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseAlertChannels result = await alertChannelsController.UpdateAlertChannelsAsync(authorization, contentType, intgGuid, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsS3",
    "data": {
      "s3CrossAccountCredentials": {
        "externalId": "123456",
        "roleArn": "arn:aws:iam::...",
        "bucketArn": "arn:aws:s3:::..."
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Alert Channels

Delete an alert channel by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/AlertChannels/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteAlertChannelsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Alert Channel intgGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await alertChannelsController.DeleteAlertChannelsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Alert Rules

#### Overview

Lacework combines [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194) and  [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733) to provide a flexible method for  routing alerts.  For [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194), you define information  about where to send alerts, such as to Jira, Slack, or email.  For [alert rules](https://support.lacework.com/hc/en-us/articles/360042236733), you define information  about which alert types to send, such as critical and high severity compliance alerts.

##### Get instance

An instance of the `AlertRulesController` class can be accessed from the API Client.

```
AlertRulesController alertRulesController = client.AlertRulesController;
```

#### Create Alert Rules

Create an alert rules by specifying parameters in the request `body` when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertRules`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateAlertRulesAsync(
    string authorization,
    string contentType,
    Models.AlertRulesCreateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.AlertRulesCreateSchema`](#alert-rules-create-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAlertRules>`](#response-alert-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new AlertRulesCreateSchema();
body.Filters = new Filters();
body.IntgGuidList = new List<object>();
body.IntgGuidList.Add(ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"));
body.IntgGuidList.Add(ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"));
body.Type = "Event";

try
{
    ResponseAlertRules result = await alertRulesController.CreateAlertRulesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Alert Rules

List all the alert rules in your Lacework instance,  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertRules`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllAlertRulesAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseAlertRulesList>`](#response-alert-rules-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAlertRulesList result = await alertRulesController.ListAllAlertRulesAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Alert Rules

Search alert rules by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AlertRules/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

Here are some example `body` payloads:

* `{ "filters": [ { "field": "mcGuid", "expression": "rlike", "value": "123ABC" } ] }`

* `{ "filters": [ { "field": "mcGuid", "expression": "between", "values": [ "ABC_123", "DEC_456" ] } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "in", "values": [ "ABC_123", "DEF_456" ] } ] }`

* `{ "filters": [ { "field": "filters.name", "expression": "ilike", "value": "slack" } ] }`

* `{ "filters": [ { "field": "filters.resourceGroups", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "filters.severity", "expression": "eq", "value": "5" } ] }`

* `{ "filters": [ { "field": "filters.eventCategory", "expression": "eq", "value": "App" } ] }`

* `{ "filters": [ { "field": "reportNotificationTypes.agentEvents", "expression": "eq", "value": "false" } ] }`

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array.

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchAlertRulesAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAlertRulesList>`](#response-alert-rules-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseAlertRulesList result = await alertRulesController.SearchAlertRulesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Alert Rule Details

Get details about a Alert Rule  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
AlertRuleDetailsAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Alert Rule mcGuid |

##### Response Type

[`Task<Models.ResponseAlertRules>`](#response-alert-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    ResponseAlertRules result = await alertRulesController.AlertRuleDetailsAsync(authorization, contentType, mcGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Alert Rules

Update an alert rules by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/AlertRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked.  In the request body, only specify the parameter(s) that you want to update.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateAlertRulesAsync(
    string authorization,
    string contentType,
    string mcGuid,
    Models.AlertRulesUpdateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Alert Rules mcGuid |
| `body` | [`Models.AlertRulesUpdateSchema`](#alert-rules-update-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseAlertRules>`](#response-alert-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string mcGuid = "mcGuid4";
var body = new AlertRulesUpdateSchema();

try
{
    ResponseAlertRules result = await alertRulesController.UpdateAlertRulesAsync(authorization, contentType, mcGuid, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Alert Rules

Delete an Alert Rule by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/AlertRule/{mcGuid}`

Replace `{mcGuid}` with the `mcGuid` value returned for a Alert Rule in the response when the  `GET /api/v2/AlertRules` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteAlertRulesAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Alert Rules mcGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    await alertRulesController.DeleteAlertRulesAsync(authorization, contentType, mcGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Audit Logs

#### Overview

Audit logs allow you to view the history of all actions performed within a Lacework account so you know who made changes to the system and when. For example, you can see who suppressed certain alerts, what time an authentication setting was modified, etc. For more information, see [Audit Logs](https://support.lacework.com/hc/en-us/articles/360042198473-Audit-Logs).

##### Get instance

An instance of the `AuditLogsController` class can be accessed from the API Client.

```
AuditLogsController auditLogsController = client.AuditLogsController;
```

#### Audit Logs

Get Audit Logs by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/AuditLogs`

Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:

* `yyyy-MM-dd` for example, `2020-12-18`

* `yyyy-MM-ddTHH` for example, `2020-12-18T08`

* `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z`

* `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/AuditLogs?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`

:information_source: **Note** This endpoint does not require authentication.

```csharp
AuditLogsAsync(
    string authorization,
    string contentType,
    string startTime = null,
    string endTime = null)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `startTime` | `string` | Query, Optional | Start time |
| `endTime` | `string` | Query, Optional | End time |

##### Response Type

[`Task<Models.ResponseAuditLogsList>`](#response-audit-logs-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseAuditLogsList result = await auditLogsController.AuditLogsAsync(authorization, contentType, null, null);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Date | [`ResponseInvalidDateException`](#response-invalid-date) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Audit Logs

Search the audit logs by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/AuditLogs/search`

Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

For the `timeFilter` filter, these are the supported time formats:

* `yyyy-MM-dd` for example, `2020-12-18`

* `yyyy-MM-ddTHH` for example, `2020-12-18T08`

* `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z`

* `yyyy-MM-ddTHH:mm:ss.SSSZ`, for example, `2020-12-18T08:00:00.000Z`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchAuditLogsAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYTIMEFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYTIMEFILTERS`](#get-data-request-body-time-filters) | Body, Required | Filters in the request body |

##### Response Type

[`Task<Models.ResponseAuditLogsList>`](#response-audit-logs-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYTIMEFILTERS();

try
{
    ResponseAuditLogsList result = await auditLogsController.SearchAuditLogsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Date | [`ResponseInvalidDateException`](#response-invalid-date) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Cloud Accounts

#### Overview

Cloud Accounts are integrations between Lacework and Cloud providers such as Amazon Web Services, Microsoft Azure, and Google Cloud Platform.

##### Get instance

An instance of the `CloudAccountsController` class can be accessed from the API Client.

```
CloudAccountsController cloudAccountsController = client.CloudAccountsController;
```

#### Create Cloud Accounts

Create a cloud account by specifying parameters in the request  body when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/CloudAccounts`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateCloudAccountsAsync(
    string authorization,
    string contentType,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | `object` | Body, Required | - |

##### Response Type

[`Task<Models.ResponseCloudAccounts>`](#response-cloud-accounts)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseCloudAccounts result = await cloudAccountsController.CreateCloudAccountsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsCfg",
    "data": {
      "awsAccountId": "123456789012",
      "crossAccountCredentials": {
        "roleArn": "arn:aws:iam::...",
        "externalId": "123456"
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Cloud Accounts

Get a list of cloud accounts for the current user by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllCloudAccountsAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseCloudAccountsList>`](#response-cloud-accounts-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.ListAllCloudAccountsAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-01-28T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-01-30T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List Cloud Accounts by Type

Get a list of cloud accounts of the specified type by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{type}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/AwsCfg`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListCloudAccountsByTypeAsync(
    string authorization,
    string contentType,
    Models.Type1Enum type)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | [`Models.Type1Enum`](#type-1) | Template, Required | Cloud Accounts Type |

##### Response Type

[`Task<Models.ResponseCloudAccountsList>`](#response-cloud-accounts-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
Type1Enum type = Type1Enum.GcpAtSes;

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.ListCloudAccountsByTypeAsync(authorization, contentType, type);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-01-28T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-01-30T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Cloud Accounts

Search cloud accounts by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/CloudAccounts/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchCloudAccountsAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseCloudAccountsList>`](#response-cloud-accounts-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseCloudAccountsList result = await cloudAccountsController.SearchCloudAccountsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "createdOrUpdatedBy": "support@lacework.net",
      "createdOrUpdatedTime": "2021-01-28T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Support",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    },
    {
      "createdOrUpdatedBy": "info@lacework.net",
      "createdOrUpdatedTime": "2021-01-30T08:28:18Z",
      "enabled": 1,
      "intgGuid": "LWXYZ...",
      "isOrg": 0,
      "name": "Info",
      "props": "{object}",
      "state": "{object}",
      "type": "AwsCfg",
      "data": {
        "awsAccountId": "123456789012",
        "crossAccountCredentials": {
          "roleArn": "arn:aws:iam::...",
          "externalId": "123456"
        }
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Cloud Accounts Details

Get the details about a cloud account by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CloudAccountsDetailsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |

##### Response Type

[`Task<Models.ResponseCloudAccounts>`](#response-cloud-accounts)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    ResponseCloudAccounts result = await cloudAccountsController.CloudAccountsDetailsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsCfg",
    "data": {
      "awsAccountId": "123456789012",
      "crossAccountCredentials": {
        "roleArn": "arn:aws:iam::...",
        "externalId": "123456"
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Cloud Accounts

Update a cloud account by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateCloudAccountsAsync(
    string authorization,
    string contentType,
    string intgGuid,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |
| `body` | `object` | Body, Required | - |

##### Response Type

[`Task<Models.ResponseCloudAccounts>`](#response-cloud-accounts)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string intgGuid = "intgGuid8";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseCloudAccounts result = await cloudAccountsController.UpdateCloudAccountsAsync(authorization, contentType, intgGuid, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "createdOrUpdatedBy": "support@lacework.net",
    "createdOrUpdatedTime": "2021-02-08T08:28:18Z",
    "enabled": 1,
    "intgGuid": "LWXYZ...",
    "isOrg": 0,
    "name": "Support",
    "props": "{object}",
    "state": "{object}",
    "type": "AwsCfg",
    "data": {
      "awsAccountId": "123456789012",
      "crossAccountCredentials": {
        "roleArn": "arn:aws:iam::...",
        "externalId": "123456"
      }
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Cloud Accounts

Delete a cloud account by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/CloudAccounts/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteCloudAccountsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Cloud Account intgGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await cloudAccountsController.DeleteCloudAccountsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Cloud Activities

#### Overview

Get information about cloud activities for the integrated AWS Cloud Accounts in your Lacework.

##### Get instance

An instance of the `CloudActivitiesController` class can be accessed from the API Client.

```
CloudActivitiesController cloudActivitiesController = client.CloudActivitiesController;
```

#### Cloud Activities

Get cloud activities details by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/CloudActivities`

Optionally filter by specifying the `startTime` and `endTime` of a time range using the following formats:

* `yyyy-MM-dd` for example, `2020-12-18`

* `yyyy-MM-ddTHH` for example, `2020-12-18T08`

* `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z`

* `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/CloudActivities?startTime=2020-12-11T08:00:00Z&endTime=2020-12-18T08:00:00Z`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CloudActivitiesAsync(
    string authorization,
    string contentType,
    string startTime = null,
    string endTime = null)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `startTime` | `string` | Query, Optional | Start time |
| `endTime` | `string` | Query, Optional | End time |

##### Response Type

[`Task<Models.ResponseCloudActivitiesList>`](#response-cloud-activities-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseCloudActivitiesList result = await cloudActivitiesController.CloudActivitiesAsync(authorization, contentType, null, null);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Date | [`ResponseInvalidDateException`](#response-invalid-date) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Cloud Activities

Search cloud activities by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/CloudActivities/search`

Filters can be optionally specified in the request body. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

For the `timeFilter` filter, these are the supported time formats:

* `yyyy-MM-dd` for example, `2020-12-18`

* `yyyy-MM-ddTHH` for example, `2020-12-18T08`

* `yyyy-MM-ddTHH:mm:ssZ` for example, `2020-12-18T08:00:00Z`

* `yyyy-MM-ddTHH:mm:ss.SSSZ` for example, `2020-12-18T08:00:00.000Z`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchCloudActivitiesAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYTIMEFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYTIMEFILTERS`](#get-data-request-body-time-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseCloudActivitiesList>`](#response-cloud-activities-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYTIMEFILTERS();

try
{
    ResponseCloudActivitiesList result = await cloudActivitiesController.SearchCloudActivitiesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Date | [`ResponseInvalidDateException`](#response-invalid-date) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Container Registries

#### Overview

Lacework provides the ability to assess, identify, and report vulnerabilities found in the operating system software packages in a Docker container image. After integrating a container registry in Lacework, Lacework finds all container images in the registry repositories, assesses those container images for software packages with known vulnerabilities, and reports them.

##### Get instance

An instance of the `ContainerRegistriesController` class can be accessed from the API Client.

```
ContainerRegistriesController containerRegistriesController = client.ContainerRegistriesController;
```

#### Create Container Registries

Create a container registry by specifying parameters in the request  body when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateContainerRegistriesAsync(
    string authorization,
    string contentType,
    Models.ContVulnCfg2 body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.ContVulnCfg2`](#cont-vuln-cfg-2) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseContainerRegistries>`](#response-container-registries)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new ContVulnCfg2();
body.Name = "name6";
body.Type = "ContVulnCfg";
body.Enabled = 154.34;
body.Data = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseContainerRegistries result = await containerRegistriesController.CreateContainerRegistriesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Container Registries

Get a list of container registries for the current user by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllContainerRegistriesAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseContainerRegistriesList>`](#response-container-registries-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseContainerRegistriesList result = await containerRegistriesController.ListAllContainerRegistriesAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List Container Registries by Type

Get a list of container registries of the specified type by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{type}/{subtype}`

Here is an example invocation:

> `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/ContVulnCfg/AWS_ECR`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListContainerRegistriesByTypeAsync(
    string authorization,
    string contentType,
    Models.Type2Enum type,
    Models.ContVulnCfg1Enum subtype)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `type` | [`Models.Type2Enum`](#type-2) | Template, Required | Container Registry Type |
| `subtype` | [`Models.ContVulnCfg1Enum`](#cont-vuln-cfg-1) | Template, Required | Container Registry Subtype |

##### Response Type

[`Task<Models.ResponseContainerRegistriesList>`](#response-container-registries-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
Type2Enum type = Type2Enum.ContVulnCfg;
ContVulnCfg1Enum subtype = ContVulnCfg1Enum.V2REGISTRY;

try
{
    ResponseContainerRegistriesList result = await containerRegistriesController.ListContainerRegistriesByTypeAsync(authorization, contentType, type, subtype);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Container Registries

Search container registries by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ContainerRegistries/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request body, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchContainerRegistriesAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseContainerRegistriesList>`](#response-container-registries-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseContainerRegistriesList result = await containerRegistriesController.SearchContainerRegistriesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Container Registry Details

Get the details about a container registry by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ContainerRegistryDetailsAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Container Registry intgGuid |

##### Response Type

[`Task<Models.ResponseContainerRegistries>`](#response-container-registries)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    ResponseContainerRegistries result = await containerRegistriesController.ContainerRegistryDetailsAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Container Registries

Update a container registry by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`

In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateContainerRegistriesAsync(
    string authorization,
    string contentType,
    string intgGuid,
    Models.ContVulnCfg3 body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Container Registry intgGuid |
| `body` | [`Models.ContVulnCfg3`](#cont-vuln-cfg-3) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseContainerRegistries>`](#response-container-registries)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string intgGuid = "intgGuid8";
var body = new ContVulnCfg3();

try
{
    ResponseContainerRegistries result = await containerRegistriesController.UpdateContainerRegistriesAsync(authorization, contentType, intgGuid, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Container Registries

Delete a container registry by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/ContainerRegistries/{intgGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteContainerRegistriesAsync(
    string authorization,
    string contentType,
    string intgGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `intgGuid` | `string` | Template, Required | Container Registry intgGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string intgGuid = "intgGuid8";

try
{
    await containerRegistriesController.DeleteContainerRegistriesAsync(authorization, contentType, intgGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Contract Info

#### Overview

Get Lacework contract information.

##### Get instance

An instance of the `ContractInfoController` class can be accessed from the API Client.

```
ContractInfoController contractInfoController = client.ContractInfoController;
```

#### Contract Info

Return contract details about the Lacework licenses found on the Lacework instance,  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ContractInfo`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ContractInfoAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseContractInfoList>`](#response-contract-info-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseContractInfoList result = await contractInfoController.ContractInfoAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "objName": "CloudActivities",
      "props": {
        "contractStartUtc": "2020-12-01T00:00:00Z",
        "renewalUtc": "2021-03-01T00:00:00Z",
        "numPurchased": 1,
        "dataRetentionInDay": 90
      }
    },
    {
      "objName": "AWSConfig",
      "props": {
        "contractStartUtc": "2020-12-01T00:00:00Z",
        "renewalUtc": "2021-03-01T00:00:00Z",
        "numPurchased": 1,
        "dataRetentionInDay": 90
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Report Rules

#### Overview

Lacework combines [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194)  and [report rules](https://support.lacework.com/hc/en-us/articles/36004176675) to provide a flexible method  for routing reports.  For [report rules](https://support.lacework.com/hc/en-us/articles/36004176675), you define information about  which reports to send.  For [alert channels](https://support.lacework.com/hc/en-us/articles/360041773194), you define where to send reports such as to Jira, Slack, or email.

##### Get instance

An instance of the `ReportRulesController` class can be accessed from the API Client.

```
ReportRulesController reportRulesController = client.ReportRulesController;
```

#### Create Report Rule

Create a Report Rule in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ReportRules`

You can get the unique identifiers for the alert channels (`intGuidList`) array by invoking the `GET /api/v2/ReportRules` endpoint.

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateReportRuleAsync(
    string authorization,
    string contentType,
    Models.ReportRulesCreateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.ReportRulesCreateSchema`](#report-rules-create-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseReportRules>`](#response-report-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new ReportRulesCreateSchema();
body.Filters = new Filters3();
body.IntgGuidList = new List<object>();
body.IntgGuidList.Add(ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"));
body.IntgGuidList.Add(ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"));
body.ReportNotificationTypes = new ReportNotificationTypes();
body.Type = "Report";

try
{
    ResponseReportRules result = await reportRulesController.CreateReportRuleAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Report Rules

List all the report rules in your Lacework instance,  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ReportRules`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllReportRulesAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseReportRulesList>`](#response-report-rules-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseReportRulesList result = await reportRulesController.ListAllReportRulesAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Report Rules

Search all the report rules in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ReportRules/search`

To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

Here are some example `body` payloads:

* `{ "filters": [ { "expression": "eq", "field": "name", "value": " Jane" } ] }`

* `{ "filters": [ { "field": "mcGuid", "expression": "rlike", "value": "123ABC" } ] }`

* `{ "filters": [ { "field": "mcGuid", "expression": "between", "values": [ "ABC_123", "DEC_456" ] } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "intgGuidList", "expression": "in", "values": [ "ABC_123", "DEF_456" ] } ] }`

* `{ "filters": [ { "field": "filters.name", "expression": "ilike", "value": "slack" } ] }`

* `{ "filters": [ { "field": "filters.resourceGroups", "expression": "eq", "value": "ABC_123" } ] }`

* `{ "filters": [ { "field": "filters.severity", "expression": "eq", "value": "5" } ] }`

* `{ "filters": [ { "field": "filters.eventCategory", "expression": "eq", "value": "App" } ] }`

* `{ "filters": [ { "field": "reportNotificationTypes.agentEvents", "expression": "eq", "value": "false" } ] }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchReportRulesAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseReportRulesList>`](#response-report-rules-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseReportRulesList result = await reportRulesController.SearchReportRulesAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Report Rule Details

Get details about a Report Rule  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ReportRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Report Rule in the response when the  `GET /api/v2/ReportRules` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
ReportRuleDetailsAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Report Rule mcGuid |

##### Response Type

[`Task<Models.ResponseReportRules>`](#response-report-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    ResponseReportRules result = await reportRulesController.ReportRuleDetailsAsync(authorization, contentType, mcGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Report Rules

Update a report rule by specifying parameters in the request body when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/ReportRule/{mcGuid}`

Replace `{mcGuid}` with the `mcGuide` value returned for a Report Rule in the response, when the  `GET /api/v2/ReportRules` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateReportRulesAsync(
    string authorization,
    string contentType,
    string mcGuid,
    Models.ReportRulesUpdateSchema body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Report Rule mcGuid |
| `body` | [`Models.ReportRulesUpdateSchema`](#report-rules-update-schema) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseReportRules>`](#response-report-rules)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string mcGuid = "mcGuid4";
var body = new ReportRulesUpdateSchema();

try
{
    ResponseReportRules result = await reportRulesController.UpdateReportRulesAsync(authorization, contentType, mcGuid, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Report Rules

Delete a Report Rule by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/ReportRules/{mcGuid}`

Replace `{mcGuid}` with the `mcGuid` value returned for a Report Rule in the response when the  `GET /api/v2/ReportRules` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteReportRulesAsync(
    string authorization,
    string contentType,
    string mcGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `mcGuid` | `string` | Template, Required | Report Rule mcGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string mcGuid = "mcGuid4";

try
{
    await reportRulesController.DeleteReportRulesAsync(authorization, contentType, mcGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Resource Groups

#### Overview

##### Get instance

An instance of the `ResourceGroupsController` class can be accessed from the API Client.

```
ResourceGroupsController resourceGroupsController = client.ResourceGroupsController;
```

#### Create Resource Group

Create a resource groups by specifying parameters in the request `body` when invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ResourceGroups`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateResourceGroupAsync(
    string authorization,
    string contentType,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | `object` | Body, Required | - |

##### Response Type

[`Task<Models.ResponseResourceGroups>`](#response-resource-groups)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseResourceGroups result = await resourceGroupsController.CreateResourceGroupAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "guid": "LW_XYZ...",
    "isDefault": 1,
    "resourceGuid": "LWABC...",
    "resourceName": "AWS Resource Group",
    "resourceType": "AWS",
    "enabled": 1,
    "props": {
      "description": "AWS Resource Group",
      "accountIds": [
        "827398290830"
      ],
      "updatedBy": "abc@xyz.com",
      "lastUpdated": "1611257592628"
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Resource Groups

Get a list of all resource groups for the account by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ResourceGroups`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllResourceGroupsAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseResourceGroupsList>`](#response-resource-groups-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseResourceGroupsList result = await resourceGroupsController.ListAllResourceGroupsAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "guid": "LW_XYZ...",
      "isDefault": 1,
      "resourceGuid": "LWABC...",
      "resourceName": "AWS Resource Group",
      "resourceType": "AWS",
      "enabled": 1,
      "props": {
        "description": "AWS Resource Group",
        "accountIds": [
          "827398290830"
        ],
        "updatedBy": "abc@xyz.com",
        "lastUpdated": "1611257592628"
      }
    },
    {
      "guid": "LW_XYZ...",
      "isDefault": 0,
      "resourceGuid": "LWDEF...",
      "resourceName": "GCP Resource Group",
      "resourceType": "GCP",
      "enabled": 0,
      "props": {
        "description": "GCP Resource Group",
        "organization": "817397103268",
        "projects": [
          "gcpProject"
        ],
        "updatedBy": "abc@xyz.com",
        "lastUpdated": "1611257592638"
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Resource Groups

Search resource groups by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/ResourceGroups/search`

To limit the returned result, optionally specify one or more `filters` in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

In the request `body`, optionally specify the list of fields to return in the response by specifying the list in the `returns` array, for example, `"returns":[ "name", "type", "enabled" ]`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchResourceGroupsAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseResourceGroupsList>`](#response-resource-groups-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseResourceGroupsList result = await resourceGroupsController.SearchResourceGroupsAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": [
    {
      "guid": "LW_XYZ...",
      "isDefault": 1,
      "resourceGuid": "LWABC...",
      "resourceName": "AWS Resource Group",
      "resourceType": "AWS",
      "enabled": 1,
      "props": {
        "description": "AWS Resource Group",
        "accountIds": [
          "827398290830"
        ],
        "updatedBy": "abc@xyz.com",
        "lastUpdated": "1611257592628"
      }
    },
    {
      "guid": "LW_XYZ...",
      "isDefault": 0,
      "resourceGuid": "LWDEF...",
      "resourceName": "GCP Resource Group",
      "resourceType": "GCP",
      "enabled": 0,
      "props": {
        "description": "GCP Resource Group",
        "organization": "817397103268",
        "projects": [
          "gcpProject"
        ],
        "updatedBy": "abc@xyz.com",
        "lastUpdated": "1611257592638"
      }
    }
  ]
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Resource Groups Details

Get the details about a resource group by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ResourceGroupsDetailsAsync(
    string authorization,
    string contentType,
    string resourceGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `resourceGuid` | `string` | Template, Required | Resource Group resourceGuid |

##### Response Type

[`Task<Models.ResponseResourceGroups>`](#response-resource-groups)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string resourceGuid = "resourceGuid2";

try
{
    ResponseResourceGroups result = await resourceGroupsController.ResourceGroupsDetailsAsync(authorization, contentType, resourceGuid);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "guid": "LW_XYZ...",
    "isDefault": 1,
    "resourceGuid": "LWABC...",
    "resourceName": "AWS Resource Group",
    "resourceType": "AWS",
    "enabled": 1,
    "props": {
      "description": "AWS Resource Group",
      "accountIds": [
        "827398290830"
      ],
      "updatedBy": "abc@xyz.com",
      "lastUpdated": "1611257592628"
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Resource Groups

Update a resource group by specifying parameters in the request body  when invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`

In the request body, only specify the parameter(s) that you want to update, for example, `{ "enabled" : 0 }`.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateResourceGroupsAsync(
    string authorization,
    string contentType,
    string resourceGuid,
    object body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `resourceGuid` | `string` | Template, Required | Resource Group resourceGuid |
| `body` | `object` | Body, Required | Only specify the parameter(s)  that you want to update, for example, `{ "enabled" : 0 }`. |

##### Response Type

[`Task<Models.ResponseResourceGroups>`](#response-resource-groups)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string resourceGuid = "resourceGuid2";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseResourceGroups result = await resourceGroupsController.UpdateResourceGroupsAsync(authorization, contentType, resourceGuid, body);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "guid": "LW_XYZ...",
    "isDefault": 1,
    "resourceGuid": "LWABC...",
    "resourceName": "AWS Resource Group",
    "resourceType": "AWS",
    "enabled": 1,
    "props": {
      "description": "AWS Resource Group",
      "accountIds": [
        "827398290830"
      ],
      "updatedBy": "abc@xyz.com",
      "lastUpdated": "1611257592628"
    }
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Resource Groups

Delete a resource group by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/ResourceGroups/{resourceGuid}`

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteResourceGroupsAsync(
    string authorization,
    string contentType,
    string resourceGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `resourceGuid` | `string` | Template, Required | Resource Group resourceGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string resourceGuid = "resourceGuid2";

try
{
    await resourceGroupsController.DeleteResourceGroupsAsync(authorization, contentType, resourceGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### Team Members

#### Overview

Team members can be granted access to multiple Lacework accounts and have different roles for each account. Team members can also be granted organization-level roles. For more information, see [Team Members](https://support.lacework.com/hc/en-us/articles/360039936974).

##### Get instance

An instance of the `TeamMembersController` class can be accessed from the API Client.

```
TeamMembersController teamMembersController = client.TeamMembersController;
```

#### Create Team Members

Create a Team Member in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/TeamMembers`

Here is an example `body` payload:

> `{ "userName": "jane.smith@mycompany.com", "userEnabled": 1, "props": { "firstName": "Jane", "lastName": "Smith", "company": "myCompany", "accountAdmin": true } }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateTeamMembersAsync(
    string authorization,
    string contentType,
    object body,
    bool? orgAccess = null)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | `object` | Body, Required | - |
| `orgAccess` | `bool?` | Header, Optional | Org account privileges |

##### Response Type

[`Task<Models.ResponseTeamMembers>`](#response-team-members)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseTeamMembers result = await teamMembersController.CreateTeamMembersAsync(authorization, contentType, body, null);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "userName": "user1.test@lacework.net",
    "orgAccount": true,
    "url": "url",
    "orgAdmin": false,
    "orgUser": false,
    "accounts": [
      {
        "admin": "true",
        "custGuid": "CUST_GUID",
        "userGuid": "USER1_GUID",
        "userEnabled": "1"
      }
    ]
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### List All Team Members

Get a list of Team Members in your Lacework instance, by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/TeamMembers`

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListAllTeamMembersAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseTeamMembersList>`](#response-team-members-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseTeamMembersList result = await teamMembersController.ListAllTeamMembersAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Search Team Members

Search all the team members in your Lacework instance,  by invoking the following endpoint:

> `POST https://YourLacework.lacework.net/api/v2/TeamMembers/search`

To limit the returned result, optionally specify one or more filters in the request `body`. For more information about using filters, see the [Simple & Advanced Search section](/api/v2/docs/#tag/OVERVIEW).

You can filter on the following fields:

* `custGuid`

* `userGuid`

* `userName`

* `userEnabled`

Here is an example `body` payload:

> `{ "filters" : [ { "expression": "eq", "field": "userName", "value": "jane.smith@mycompany.com" } ] }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
SearchTeamMembersAsync(
    string authorization,
    string contentType,
    Models.GETDATAREQUESTBODYFILTERS body)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `body` | [`Models.GETDATAREQUESTBODYFILTERS`](#get-data-request-body-filters) | Body, Required | - |

##### Response Type

[`Task<Models.ResponseTeamMembersList>`](#response-team-members-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
var body = new GETDATAREQUESTBODYFILTERS();

try
{
    ResponseTeamMembersList result = await teamMembersController.SearchTeamMembersAsync(authorization, contentType, body);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Team Member Details

Get details about a Team Member  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
TeamMemberDetailsAsync(
    string authorization,
    string contentType,
    string userGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `userGuid` | `string` | Template, Required | Team Member userGuid |

##### Response Type

[`Task<Models.ResponseTeamMembers>`](#response-team-members)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string userGuid = "userGuid2";

try
{
    ResponseTeamMembers result = await teamMembersController.TeamMemberDetailsAsync(authorization, contentType, userGuid);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "userName": "user1.test@lacework.net",
    "orgAccount": true,
    "url": "url",
    "orgAdmin": false,
    "orgUser": false,
    "accounts": [
      {
        "admin": "true",
        "custGuid": "CUST_GUID",
        "userGuid": "USER1_GUID",
        "userEnabled": "1"
      }
    ]
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid data | [`ResponseInvalidTypeException`](#response-invalid-type) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Update Team Member

Optionally update the `userName` and`userEnabled` settings and the `props`  sub-settings of the passed in Team Member.  Update these settings by invoking the following endpoint:

> `PATCH https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response, when the  `GET /api/v2/TeamMembers` endpoint is invoked.

Here is an example `body` payload:

> `{ "props": {"firstName":"Jane"} }`

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateTeamMemberAsync(
    string authorization,
    string contentType,
    string userGuid,
    object body,
    bool? orgAccess = null)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `userGuid` | `string` | Template, Required | Team Member userGuid |
| `body` | `object` | Body, Required | - |
| `orgAccess` | `bool?` | Header, Optional | Org account privileges |

##### Response Type

[`Task<Models.ResponseUpdateTeamMember>`](#response-update-team-member)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "application/json";
string userGuid = "userGuid2";
object body = ApiHelper.JsonDeserialize<Object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");

try
{
    ResponseUpdateTeamMember result = await teamMembersController.UpdateTeamMemberAsync(authorization, contentType, userGuid, body, null);
}
catch (ApiException e){};
```

##### Example Response *(as JSON)*

```json
{
  "data": {
    "userName": "user1.test@lacework.net",
    "orgAccount": true,
    "url": "url",
    "orgAdmin": false,
    "orgUser": false,
    "accounts": [
      {
        "admin": "true",
        "custGuid": "CUST_GUID",
        "userGuid": "USER1_GUID",
        "userEnabled": "1"
      }
    ]
  }
}
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

#### Delete Team Member

Delete a Team Member by invoking the following endpoint:

> `DELETE https://YourLacework.lacework.net/api/v2/TeamMembers/{userGuid}`

Replace `{userGuid}` with the `userGuid` value returned for a Team Member in the response when the  `GET /api/v2/TeamMembers` endpoint is invoked.

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteTeamMemberAsync(
    string authorization,
    string contentType,
    string userGuid)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |
| `userGuid` | `string` | Template, Required | Team Member userGuid |

##### Response Type

`Task`

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";
string userGuid = "userGuid2";

try
{
    await teamMembersController.DeleteTeamMemberAsync(authorization, contentType, userGuid);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

### User Profile

#### Overview

An organization can contain multiple accounts so you can also manage components such as alerts,  resource groups, team members, and audit logs at a more granular level inside an organization.  For more information, see [Organization Overview](https://support.lacework.com/hc/en-us/articles/360041727394).

##### Get instance

An instance of the `UserProfileController` class can be accessed from the API Client.

```
UserProfileController userProfileController = client.UserProfileController;
```

#### List Sub-Accounts

List all the sub-accounts that are managed by the `YourLacework` account,  by invoking the following endpoint:

> `GET https://YourLacework.lacework.net/api/v2/UserProfile`

For example if you specify the `IT20.MyCompany` organization account in  `YourLacework`, all the sub-accounts of the `IT20` account are listed.

Here is an example invocation:

> `GET https://IT20.MyCompany.lacework.net/api/v2/UserProfile`

Details about organization accounts and non-organization accounts are reported in the response.  In addition, details about authorization and privileges are also listed.

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListSubAccountsAsync(
    string authorization,
    string contentType)
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string` | Header, Required | Bearer AccessToken |
| `contentType` | `string` | Header, Required | application/json |

##### Response Type

[`Task<Models.ResponseUserProfileList>`](#response-user-profile-list)

##### Example Usage

```csharp
string authorization = "Authorization8";
string contentType = "Content-Type2";

try
{
    ResponseUserProfileList result = await userProfileController.ListSubAccountsAsync(authorization, contentType);
}
catch (ApiException e){};
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not found | [`Response404Exception`](#response-404) |
| 500 | Internal Server Error | [`ResponseInternalErrorException`](#response-internal-error) |

## Model Reference

### Structures

* [Agent Access Tokens](#agent-access-tokens-1)
* [Agent Access Tokens Create Schema](#agent-access-tokens-create-schema)
* [Agent Access Tokens Update Schema](#agent-access-tokens-update-schema)
* [Alert Rules](#alert-rules-1)
* [Alert Rules Create Schema](#alert-rules-create-schema)
* [Alert Rules Update Schema](#alert-rules-update-schema)
* [Audit Logs](#audit-logs-2)
* [Cloud Activities](#cloud-activities-2)
* [Contract Info](#contract-info-2)
* [GET DATA REQUEST BODY FILTERS](#get-data-request-body-filters)
* [GET DATA REQUEST BODY TIME FILTERS](#get-data-request-body-time-filters)
* [Report Rules](#report-rules-1)
* [Report Rules Create Schema](#report-rules-create-schema)
* [Report Rules Update Schema](#report-rules-update-schema)
* [User Profile](#user-profile-1)
* [Access Key Credentials](#access-key-credentials)
* [Access Key Credentials 4](#access-key-credentials-4)
* [Access Key Credentials 6](#access-key-credentials-6)
* [Access Key Credentials 8](#access-key-credentials-8)
* [Account](#account)
* [Api V2 Access Tokens Request](#api-v2-access-tokens-request)
* [Api V2 Access Tokens Response](#api-v2-access-tokens-response)
* [AWS ECR - AWS IAM Role](#aws-ecr-aws-iam-role)
* [AWS ECR - AWS IAM Role 2](#aws-ecr-aws-iam-role-2)
* [AWS ECR - AWS Key ID Access Key](#aws-ecr-aws-key-id-access-key)
* [AWS ECR - AWS Key ID Access Key 2](#aws-ecr-aws-key-id-access-key-2)
* [AWS Resource Group](#aws-resource-group)
* [AWS Resource Group 1](#aws-resource-group-1)
* [AWS Resource Group 2](#aws-resource-group-2)
* [Aws Cfg](#aws-cfg)
* [Aws Cfg 1](#aws-cfg-1)
* [Aws Cfg 2](#aws-cfg-2)
* [Aws Ct Sqs](#aws-ct-sqs)
* [Aws Ct Sqs 1](#aws-ct-sqs-1)
* [Aws Ct Sqs 2](#aws-ct-sqs-2)
* [Aws S3](#aws-s3)
* [Aws S31](#aws-s31)
* [Aws S32](#aws-s32)
* [Aws Us Gov Cfg](#aws-us-gov-cfg)
* [Aws Us Gov Cfg 1](#aws-us-gov-cfg-1)
* [Aws Us Gov Cfg 2](#aws-us-gov-cfg-2)
* [Aws Us Gov Ct Sqs](#aws-us-gov-ct-sqs)
* [Aws Us Gov Ct Sqs 1](#aws-us-gov-ct-sqs-1)
* [Aws Us Gov Ct Sqs 2](#aws-us-gov-ct-sqs-2)
* [Azure Resource Group](#azure-resource-group)
* [Azure Resource Group 1](#azure-resource-group-1)
* [Azure Resource Group 2](#azure-resource-group-2)
* [Azure Al Seq](#azure-al-seq)
* [Azure Al Seq 1](#azure-al-seq-1)
* [Azure Al Seq 2](#azure-al-seq-2)
* [Azure Cfg](#azure-cfg)
* [Azure Cfg 1](#azure-cfg-1)
* [Azure Cfg 2](#azure-cfg-2)
* [Channel Props](#channel-props)
* [Channel Props 2](#channel-props-2)
* [Cisco Spark Webhook](#cisco-spark-webhook)
* [Cisco Spark Webhook 1](#cisco-spark-webhook-1)
* [Cisco Spark Webhook 2](#cisco-spark-webhook-2)
* [Cloudwatch Eb](#cloudwatch-eb)
* [Cloudwatch Eb 1](#cloudwatch-eb-1)
* [Cloudwatch Eb 2](#cloudwatch-eb-2)
* [Container Resource Group](#container-resource-group)
* [Container Resource Group 1](#container-resource-group-1)
* [Container Resource Group 2](#container-resource-group-2)
* [Cont Vuln Cfg](#cont-vuln-cfg)
* [Cont Vuln Cfg 2](#cont-vuln-cfg-2)
* [Cont Vuln Cfg 3](#cont-vuln-cfg-3)
* [Credentials](#credentials)
* [Credentials 2](#credentials-2)
* [Credentials 3](#credentials-3)
* [Credentials 5](#credentials-5)
* [Credentials 11](#credentials-11)
* [Credentials 15](#credentials-15)
* [Credentials 16](#credentials-16)
* [Credentials 17](#credentials-17)
* [Credentials 23](#credentials-23)
* [Credentials 24](#credentials-24)
* [Credentials 25](#credentials-25)
* [Cross Account Credentials](#cross-account-credentials)
* [Cross Account Credentials 4](#cross-account-credentials-4)
* [Data](#data)
* [Data 1](#data-1)
* [Data 2](#data-2)
* [Data 3](#data-3)
* [Data 4](#data-4)
* [Data 5](#data-5)
* [Data 6](#data-6)
* [Data 7](#data-7)
* [Data 8](#data-8)
* [Data 9](#data-9)
* [Data 10](#data-10)
* [Data 11](#data-11)
* [Data 12](#data-12)
* [Data 13](#data-13)
* [Data 14](#data-14)
* [Data 19](#data-19)
* [Data 30](#data-30)
* [Data 31](#data-31)
* [Data 32](#data-32)
* [Data 33](#data-33)
* [Data 34](#data-34)
* [Data 35](#data-35)
* [Data 36](#data-36)
* [Data 37](#data-37)
* [Data 38](#data-38)
* [Data 39](#data-39)
* [Data 40](#data-40)
* [Data 41](#data-41)
* [Data 42](#data-42)
* [Data 43](#data-43)
* [Data 44](#data-44)
* [Data 45](#data-45)
* [Data 46](#data-46)
* [Data 47](#data-47)
* [Data 48](#data-48)
* [Data 49](#data-49)
* [Data 50](#data-50)
* [Data 51](#data-51)
* [Data 52](#data-52)
* [Data 61](#data-61)
* [Data 62](#data-62)
* [Data 63](#data-63)
* [Data 64](#data-64)
* [Data 65](#data-65)
* [Data 66](#data-66)
* [Data 67](#data-67)
* [Data 68](#data-68)
* [Datadog](#datadog)
* [Datadog 1](#datadog-1)
* [Datadog 2](#datadog-2)
* [Docker Hub](#docker-hub)
* [Docker Hub 2](#docker-hub-2)
* [Docker V2 Registry](#docker-v2-registry)
* [Docker V2 Registry 2](#docker-v2-registry-2)
* [Email User](#email-user)
* [Email User 1](#email-user-1)
* [Email User 2](#email-user-2)
* [Event Data](#event-data)
* [Event Data 2](#event-data-2)
* [Filters](#filters)
* [Filters 1](#filters-1)
* [Filters 3](#filters-3)
* [Format Key 1 Value 1 Key 2 Value 2](#format-key-1-value-1-key-2-value-2)
* [GCP Resource Group](#gcp-resource-group)
* [GCP Resource Group 1](#gcp-resource-group-1)
* [GCP Resource Group 2](#gcp-resource-group-2)
* [Gcp at Ses](#gcp-at-ses)
* [Gcp at Ses 1](#gcp-at-ses-1)
* [Gcp at Ses 2](#gcp-at-ses-2)
* [Gcp Cfg](#gcp-cfg)
* [Gcp Cfg 1](#gcp-cfg-1)
* [Gcp Cfg 2](#gcp-cfg-2)
* [Gcp Pubsub](#gcp-pubsub)
* [Gcp Pubsub 1](#gcp-pubsub-1)
* [Gcp Pubsub 2](#gcp-pubsub-2)
* [Github Container Registry](#github-container-registry)
* [Github Container Registry 2](#github-container-registry-2)
* [Google Container Registry GCR](#google-container-registry-gcr)
* [Google Container Registry GCR 2](#google-container-registry-gcr-2)
* [Ibm Qradar](#ibm-qradar)
* [Ibm Qradar 1](#ibm-qradar-1)
* [Ibm Qradar 2](#ibm-qradar-2)
* [Identifier Tag S for Scan](#identifier-tag-s-for-scan)
* [Inline Scanner](#inline-scanner)
* [Inline Scanner 2](#inline-scanner-2)
* [Jira](#jira)
* [JIRA CLOUD](#jira-cloud)
* [JIRA CLOUD2](#jira-cloud2)
* [JIRA SERVER](#jira-server)
* [JIRA SERVER2](#jira-server2)
* [Jira 1](#jira-1)
* [Jira 2](#jira-2)
* [Lacework Accounts Resource Group](#lacework-accounts-resource-group)
* [Lacework Accounts Resource Group 1](#lacework-accounts-resource-group-1)
* [Lacework Accounts Resource Group 2](#lacework-accounts-resource-group-2)
* [Limit by Label S Optional](#limit-by-label-s-optional)
* [Machine Resource Group](#machine-resource-group)
* [Machine Resource Group 1](#machine-resource-group-1)
* [Machine Resource Group 2](#machine-resource-group-2)
* [Microsoft Teams](#microsoft-teams)
* [Microsoft Teams 1](#microsoft-teams-1)
* [Microsoft Teams 2](#microsoft-teams-2)
* [New Relic Insights](#new-relic-insights)
* [New Relic Insights 1](#new-relic-insights-1)
* [New Relic Insights 2](#new-relic-insights-2)
* [Notification Types](#notification-types)
* [Pager Duty Api](#pager-duty-api)
* [Pager Duty Api 1](#pager-duty-api-1)
* [Pager Duty Api 2](#pager-duty-api-2)
* [Props](#props)
* [Props 1](#props-1)
* [Props 2](#props-2)
* [Props 3](#props-3)
* [Props 4](#props-4)
* [Props 5](#props-5)
* [Props 6](#props-6)
* [Props 7](#props-7)
* [Props 8](#props-8)
* [Props 9](#props-9)
* [Props 10](#props-10)
* [Props 11](#props-11)
* [Props 12](#props-12)
* [Props 13](#props-13)
* [Props 14](#props-14)
* [Props 15](#props-15)
* [Props 16](#props-16)
* [Props 17](#props-17)
* [Props 18](#props-18)
* [Props 22](#props-22)
* [Proxy Scanner](#proxy-scanner)
* [Proxy Scanner 2](#proxy-scanner-2)
* [Report Notification Types](#report-notification-types)
* [Response Agent Access Tokens](#response-agent-access-tokens)
* [Response Agent Access Tokens List](#response-agent-access-tokens-list)
* [Response Alert Channels](#response-alert-channels)
* [Response Alert Channels List](#response-alert-channels-list)
* [Response Alert Rules](#response-alert-rules)
* [Response Alert Rules List](#response-alert-rules-list)
* [Response Audit Logs List](#response-audit-logs-list)
* [Response Cloud Accounts](#response-cloud-accounts)
* [Response Cloud Accounts List](#response-cloud-accounts-list)
* [Response Cloud Activities List](#response-cloud-activities-list)
* [Response Container Registries](#response-container-registries)
* [Response Container Registries List](#response-container-registries-list)
* [Response Contract Info List](#response-contract-info-list)
* [Response Report Rules](#response-report-rules)
* [Response Report Rules List](#response-report-rules-list)
* [Response Resource Groups](#response-resource-groups)
* [Response Resource Groups List](#response-resource-groups-list)
* [Response Team Members](#response-team-members)
* [Response Team Members List](#response-team-members-list)
* [Response Update Team Member](#response-update-team-member)
* [Response User Profile List](#response-user-profile-list)
* [S3 Cross Account Credentials](#s3-cross-account-credentials)
* [S3 Cross Account Credentials 2](#s3-cross-account-credentials-2)
* [Service Now Rest](#service-now-rest)
* [Service Now Rest 1](#service-now-rest-1)
* [Service Now Rest 2](#service-now-rest-2)
* [Slack Channel](#slack-channel)
* [Slack Channel 1](#slack-channel-1)
* [Slack Channel 2](#slack-channel-2)
* [Splunk Hec](#splunk-hec)
* [Splunk Hec 1](#splunk-hec-1)
* [Splunk Hec 2](#splunk-hec-2)
* [Time Filter](#time-filter)
* [Victor Ops](#victor-ops)
* [Victor Ops 1](#victor-ops-1)
* [Victor Ops 2](#victor-ops-2)
* [Webhook](#webhook)
* [Webhook 1](#webhook-1)
* [Webhook 2](#webhook-2)
* [With Org-Access](#with-org-access)
* [With Org-Access 1](#with-org-access-1)
* [With Org-Access 2](#with-org-access-2)
* [Without Org-Access](#without-org-access)
* [Without Org-Access 1](#without-org-access-1)
* [Without Org-Access 2](#without-org-access-2)

#### Agent Access Tokens

##### Class Name

`AgentAccessTokens`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TokenEnabled` | `string` | Required | - |
| `TokenAlias` | `string` | Required | - |
| `AccessToken` | `string` | Optional | - |
| `CreatedTime` | `string` | Optional | - |
| `Props` | `string` | Optional | - |
| `Version` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "tokenEnabled": "tokenEnabled0",
  "tokenAlias": "tokenAlias8",
  "accessToken": null,
  "createdTime": null,
  "props": null,
  "version": null
}
```

#### Agent Access Tokens Create Schema

##### Class Name

`AgentAccessTokensCreateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TokenEnabled` | `string` | Required | - |
| `TokenAlias` | `string` | Required | - |

##### Example (as JSON)

```json
{
  "tokenEnabled": "tokenEnabled0",
  "tokenAlias": "tokenAlias8"
}
```

#### Agent Access Tokens Update Schema

##### Class Name

`AgentAccessTokensUpdateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TokenEnabled` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "tokenEnabled": null
}
```

#### Alert Rules

##### Class Name

`AlertRules`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters`](#filters) | Required | - |
| `IntgGuidList` | `object` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Type` | `string` | Required | **Default**: `"Event"`<br>*Default: `"Event"`* |
| `McGuid` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "type": "Event"
}
```

#### Alert Rules Create Schema

##### Class Name

`AlertRulesCreateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters`](#filters) | Required | - |
| `IntgGuidList` | `object` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Type` | `string` | Required | **Default**: `"Event"`<br>*Default: `"Event"`* |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "type": "Event"
}
```

#### Alert Rules Update Schema

##### Class Name

`AlertRulesUpdateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters`](#filters) | Optional | - |
| `IntgGuidList` | `object` | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null
}
```

#### Audit Logs

##### Class Name

`AuditLogs`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatedTime` | `int?` | Optional | - |
| `AccountName` | `string` | Optional | - |
| `UserName` | `string` | Optional | - |
| `EventName` | `string` | Optional | - |
| `UserAction` | `string` | Optional | - |
| `EventDescription` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "createdTime": null,
  "accountName": null,
  "userName": null,
  "eventName": null,
  "userAction": null,
  "eventDescription": null
}
```

#### Cloud Activities

##### Class Name

`CloudActivities`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `int?` | Optional | - |
| `EndTime` | `int?` | Optional | - |
| `EventType` | `string` | Optional | - |
| `EventId` | `double?` | Optional | - |
| `EventModel` | `string` | Optional | - |
| `EventActor` | `string` | Optional | - |
| `EntityMap` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "startTime": null,
  "endTime": null,
  "eventType": null,
  "eventId": null,
  "eventModel": null,
  "eventActor": null,
  "entityMap": null
}
```

#### Contract Info

##### Class Name

`ContractInfo`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ObjName` | `string` | Optional | - |
| `Props` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "objName": null,
  "props": null
}
```

#### GET DATA REQUEST BODY FILTERS

##### Class Name

`GETDATAREQUESTBODYFILTERS`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`List<Models.Filters1>`](#filters-1) | Optional | - |
| `Returns` | `List<string>` | Optional | - |

##### Example (as JSON)

```json
{
  "filters": null,
  "returns": null
}
```

#### GET DATA REQUEST BODY TIME FILTERS

##### Class Name

`GETDATAREQUESTBODYTIMEFILTERS`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TimeFilter` | [`Models.TimeFilter`](#time-filter) | Optional | - |
| `Filters` | [`List<Models.Filters1>`](#filters-1) | Optional | - |
| `Returns` | `List<string>` | Optional | - |

##### Example (as JSON)

```json
{
  "timeFilter": null,
  "filters": null,
  "returns": null
}
```

#### Report Rules

##### Class Name

`ReportRules`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters3`](#filters-3) | Required | - |
| `IntgGuidList` | `object` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `ReportNotificationTypes` | [`Models.ReportNotificationTypes`](#report-notification-types) | Required | - |
| `Type` | `string` | Required | **Default**: `"Report"`<br>*Default: `"Report"`* |
| `McGuid` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "reportNotificationTypes": null,
  "type": "Report"
}
```

#### Report Rules Create Schema

##### Class Name

`ReportRulesCreateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters3`](#filters-3) | Required | - |
| `IntgGuidList` | `object` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `ReportNotificationTypes` | [`Models.ReportNotificationTypes`](#report-notification-types) | Required | - |
| `Type` | `string` | Required | **Default**: `"Report"`<br>*Default: `"Report"`* |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "reportNotificationTypes": null,
  "type": "Report"
}
```

#### Report Rules Update Schema

##### Class Name

`ReportRulesUpdateSchema`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters3`](#filters-3) | Optional | - |
| `IntgGuidList` | `object` | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `ReportNotificationTypes` | [`Models.ReportNotificationTypes`](#report-notification-types) | Optional | - |

##### Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "reportNotificationTypes": null
}
```

#### User Profile

##### Class Name

`UserProfile`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | - |
| `OrgAccount` | `bool` | Required | - |
| `Url` | `string` | Optional | - |
| `OrgAdmin` | `bool?` | Optional | - |
| `OrgUser` | `bool?` | Optional | - |
| `Accounts` | [`List<Models.Account>`](#account) | Required | list of accounts this user has access to<br>**Constraints**: *Minimum Items*: `1` |

##### Example (as JSON)

```json
{
  "username": "username0",
  "orgAccount": false,
  "url": null,
  "orgAdmin": null,
  "orgUser": null,
  "accounts": [
    {
      "admin": null,
      "accountName": null,
      "custGuid": null,
      "userGuid": null,
      "userEnabled": null
    },
    {
      "admin": null,
      "accountName": null,
      "custGuid": null,
      "userGuid": null,
      "userEnabled": null
    }
  ]
}
```

#### Access Key Credentials

##### Class Name

`AccessKeyCredentials`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | **Constraints**: *Pattern*: `^\d{12}$` |
| `AccessKeyId` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

##### Example (as JSON)

```json
{
  "accountId": "accountId0",
  "accessKeyId": "accessKeyId4",
  "secretAccessKey": "secretAccessKey0"
}
```

#### Access Key Credentials 4

##### Class Name

`AccessKeyCredentials4`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Optional | **Constraints**: *Pattern*: `^\d{12}$` |
| `AccessKeyId` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

##### Example (as JSON)

```json
{
  "accountId": null,
  "accessKeyId": null,
  "secretAccessKey": null
}
```

#### Access Key Credentials 6

##### Class Name

`AccessKeyCredentials6`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyId` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Required | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

##### Example (as JSON)

```json
{
  "accessKeyId": "accessKeyId4",
  "secretAccessKey": "secretAccessKey0"
}
```

#### Access Key Credentials 8

##### Class Name

`AccessKeyCredentials8`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyId` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Z0-9])[A-Z0-9]{20}(?![A-Z0-9])` |
| `SecretAccessKey` | `string` | Optional | **Constraints**: *Pattern*: `(^\|[^A-Za-z0-9/+=])[A-Za-z0-9/+=]{40}(?![A-Za-z0-9/+=])` |

##### Example (as JSON)

```json
{
  "accessKeyId": null,
  "secretAccessKey": null
}
```

#### Account

##### Class Name

`Account`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Admin` | `bool?` | Optional | - |
| `AccountName` | `string` | Optional | - |
| `CustGuid` | `string` | Optional | - |
| `UserGuid` | `string` | Optional | - |
| `UserEnabled` | [`Models.UserEnabledEnum?`](#user-enabled) | Optional | - |

##### Example (as JSON)

```json
{
  "admin": null,
  "accountName": null,
  "custGuid": null,
  "userGuid": null,
  "userEnabled": null
}
```

#### Api V2 Access Tokens Request

##### Class Name

`ApiV2AccessTokensRequest`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `KeyId` | `string` | Required | - |
| `ExpiryTime` | `int` | Required | Number of seconds, maximum value: 86400 or 24 hours. |

##### Example (as JSON)

```json
{
  "keyId": "YourSecretKey",
  "expiryTime": 3600
}
```

#### Api V2 Access Tokens Response

##### Class Name

`ApiV2AccessTokensResponse`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresAt` | `string` | Optional | datetime in the format of "yyyy-MM-ddTHH:mm:ss.SSSZ" |
| `Token` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "expiresAt": null,
  "token": null
}
```

#### AWS ECR - AWS IAM Role

##### Class Name

`AWSECRAWSIAMRole`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials`](#cross-account-credentials) | Required | - |
| `AwsAuthType` | `string` | Required | **Default**: `"AWS_IAM"`<br>*Default: `"AWS_IAM"`* |
| `RegistryType` | `string` | Required | **Default**: `"AWS_ECR"`<br>*Default: `"AWS_ECR"`* |
| `RegistryDomain` | `string` | Required | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "crossAccountCredentials": null,
  "awsAuthType": "AWS_IAM",
  "registryType": "AWS_ECR",
  "registryDomain": null
}
```

#### AWS ECR - AWS IAM Role 2

##### Class Name

`AWSECRAWSIAMRole2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials4`](#cross-account-credentials-4) | Optional | - |
| `AwsAuthType` | [`Models.AuthenticationTypeEnum?`](#authentication-type) | Optional | **Default**: `AuthenticationTypeEnum.AWS_IAM`<br>*Default: `AuthenticationTypeEnum.AWS_IAM`* |
| `RegistryType` | [`Models.RegistryTypeEnum?`](#registry-type) | Optional | - |
| `RegistryDomain` | `string` | Optional | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "crossAccountCredentials": null,
  "awsAuthType": null,
  "registryType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### AWS ECR - AWS Key ID Access Key

##### Class Name

`AWSECRAWSKeyIDAccessKey`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials6`](#access-key-credentials-6) | Required | - |
| `AwsAuthType` | `string` | Required | **Default**: `"AWS_ACCESS_KEY"`<br>*Default: `"AWS_ACCESS_KEY"`* |
| `RegistryType` | `string` | Required | **Default**: `"AWS_ECR"`<br>*Default: `"AWS_ECR"`* |
| `RegistryDomain` | `string` | Required | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": null,
  "awsAuthType": "AWS_ACCESS_KEY",
  "registryType": "AWS_ECR",
  "registryDomain": null
}
```

#### AWS ECR - AWS Key ID Access Key 2

##### Class Name

`AWSECRAWSKeyIDAccessKey2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials8`](#access-key-credentials-8) | Optional | - |
| `AwsAuthType` | [`Models.AuthenticationType1Enum?`](#authentication-type-1) | Optional | **Default**: `AuthenticationType1Enum.AWS_ACCESS_KEY`<br>*Default: `AuthenticationType1Enum.AWS_ACCESS_KEY`* |
| `RegistryType` | [`Models.RegistryTypeEnum?`](#registry-type) | Optional | - |
| `RegistryDomain` | `string` | Optional | **Constraints**: *Pattern*: `^(https://)?(http://)?(.*)(.dkr\.ecr.)(.*)(.amazonaws.com)$` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": null,
  "awsAuthType": null,
  "registryType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### AWS Resource Group

##### Class Name

`AWSResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"AWS"`<br>*Default: `"AWS"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props`](#props) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "AWS",
  "props": null
}
```

#### AWS Resource Group 1

##### Class Name

`AWSResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"AWS"`<br>*Default: `"AWS"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props6`](#props-6) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "AWS",
  "props": null
}
```

#### AWS Resource Group 2

##### Class Name

`AWSResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props12`](#props-12) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Aws Cfg

##### Class Name

`AwsCfg`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsCfg"`<br>*Default: `"AwsCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data45`](#data-45) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCfg",
  "enabled": null,
  "data": null
}
```

#### Aws Cfg 1

##### Class Name

`AwsCfg1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsCfg"`<br>*Default: `"AwsCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data45`](#data-45) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCfg",
  "enabled": null,
  "data": null
}
```

#### Aws Cfg 2

##### Class Name

`AwsCfg2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data61`](#data-61) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Aws Ct Sqs

##### Class Name

`AwsCtSqs`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsCtSqs"`<br>*Default: `"AwsCtSqs"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data46`](#data-46) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCtSqs",
  "enabled": null,
  "data": null
}
```

#### Aws Ct Sqs 1

##### Class Name

`AwsCtSqs1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsCtSqs"`<br>*Default: `"AwsCtSqs"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data46`](#data-46) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsCtSqs",
  "enabled": null,
  "data": null
}
```

#### Aws Ct Sqs 2

##### Class Name

`AwsCtSqs2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data62`](#data-62) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Aws S3

##### Class Name

`AwsS3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsS3"`<br>*Default: `"AwsS3"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data`](#data) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsS3",
  "enabled": null,
  "data": null
}
```

#### Aws S31

##### Class Name

`AwsS31`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsS3"`<br>*Default: `"AwsS3"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data`](#data) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsS3",
  "enabled": null,
  "data": null
}
```

#### Aws S32

##### Class Name

`AwsS32`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data30`](#data-30) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Cfg

##### Class Name

`AwsUsGovCfg`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsUsGovCfg"`<br>*Default: `"AwsUsGovCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data47`](#data-47) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCfg",
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Cfg 1

##### Class Name

`AwsUsGovCfg1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsUsGovCfg"`<br>*Default: `"AwsUsGovCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data47`](#data-47) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCfg",
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Cfg 2

##### Class Name

`AwsUsGovCfg2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data63`](#data-63) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Ct Sqs

##### Class Name

`AwsUsGovCtSqs`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsUsGovCtSqs"`<br>*Default: `"AwsUsGovCtSqs"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data48`](#data-48) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCtSqs",
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Ct Sqs 1

##### Class Name

`AwsUsGovCtSqs1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AwsUsGovCtSqs"`<br>*Default: `"AwsUsGovCtSqs"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data48`](#data-48) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AwsUsGovCtSqs",
  "enabled": null,
  "data": null
}
```

#### Aws Us Gov Ct Sqs 2

##### Class Name

`AwsUsGovCtSqs2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data64`](#data-64) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Azure Resource Group

##### Class Name

`AzureResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"AZURE"`<br>*Default: `"AZURE"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props1`](#props-1) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "AZURE",
  "props": null
}
```

#### Azure Resource Group 1

##### Class Name

`AzureResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"AZURE"`<br>*Default: `"AZURE"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props7`](#props-7) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "AZURE",
  "props": null
}
```

#### Azure Resource Group 2

##### Class Name

`AzureResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props13`](#props-13) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Azure Al Seq

##### Class Name

`AzureAlSeq`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AzureAlSeq"`<br>*Default: `"AzureAlSeq"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data49`](#data-49) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AzureAlSeq",
  "enabled": null,
  "data": null
}
```

#### Azure Al Seq 1

##### Class Name

`AzureAlSeq1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AzureAlSeq"`<br>*Default: `"AzureAlSeq"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data49`](#data-49) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AzureAlSeq",
  "enabled": null,
  "data": null
}
```

#### Azure Al Seq 2

##### Class Name

`AzureAlSeq2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data65`](#data-65) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Azure Cfg

##### Class Name

`AzureCfg`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AzureCfg"`<br>*Default: `"AzureCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data50`](#data-50) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AzureCfg",
  "enabled": null,
  "data": null
}
```

#### Azure Cfg 1

##### Class Name

`AzureCfg1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"AzureCfg"`<br>*Default: `"AzureCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data50`](#data-50) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "AzureCfg",
  "enabled": null,
  "data": null
}
```

#### Azure Cfg 2

##### Class Name

`AzureCfg2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data66`](#data-66) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Channel Props

##### Class Name

`ChannelProps`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipients` | `object` | Required | a list of email addresses |

##### Example (as JSON)

```json
{
  "recipients": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ]
}
```

#### Channel Props 2

##### Class Name

`ChannelProps2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipients` | `object` | Optional | a list of email addresses |

##### Example (as JSON)

```json
{
  "recipients": null
}
```

#### Cisco Spark Webhook

##### Class Name

`CiscoSparkWebhook`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"CiscoSparkWebhook"`<br>*Default: `"CiscoSparkWebhook"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data1`](#data-1) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "CiscoSparkWebhook",
  "enabled": null,
  "data": null
}
```

#### Cisco Spark Webhook 1

##### Class Name

`CiscoSparkWebhook1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"CiscoSparkWebhook"`<br>*Default: `"CiscoSparkWebhook"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data1`](#data-1) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "CiscoSparkWebhook",
  "enabled": null,
  "data": null
}
```

#### Cisco Spark Webhook 2

##### Class Name

`CiscoSparkWebhook2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data31`](#data-31) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Cloudwatch Eb

##### Class Name

`CloudwatchEb`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"CloudwatchEb"`<br>*Default: `"CloudwatchEb"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data2`](#data-2) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "CloudwatchEb",
  "enabled": null,
  "data": null
}
```

#### Cloudwatch Eb 1

##### Class Name

`CloudwatchEb1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"CloudwatchEb"`<br>*Default: `"CloudwatchEb"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data2`](#data-2) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "CloudwatchEb",
  "enabled": null,
  "data": null
}
```

#### Cloudwatch Eb 2

##### Class Name

`CloudwatchEb2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data32`](#data-32) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Container Resource Group

##### Class Name

`ContainerResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"CONTAINER"`<br>*Default: `"CONTAINER"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props4`](#props-4) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "CONTAINER",
  "props": null
}
```

#### Container Resource Group 1

##### Class Name

`ContainerResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"CONTAINER"`<br>*Default: `"CONTAINER"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props10`](#props-10) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "CONTAINER",
  "props": null
}
```

#### Container Resource Group 2

##### Class Name

`ContainerResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props16`](#props-16) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Cont Vuln Cfg

##### Class Name

`ContVulnCfg`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"ContVulnCfg"`<br>*Default: `"ContVulnCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | `object` | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "ContVulnCfg",
  "enabled": null,
  "data": null
}
```

#### Cont Vuln Cfg 2

##### Class Name

`ContVulnCfg2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"ContVulnCfg"`<br>*Default: `"ContVulnCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "ContVulnCfg",
  "enabled": null,
  "data": null
}
```

#### Cont Vuln Cfg 3

##### Class Name

`ContVulnCfg3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Credentials

##### Class Name

`Credentials`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&’*+/=?`{\|}~^-]+(?:\.[\w!#$%&’*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": "clientId6",
  "privateKeyId": "privateKeyId6",
  "clientEmail": "clientEmail0",
  "privateKey": "privateKey2"
}
```

#### Credentials 2

##### Class Name

`Credentials2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&’*+/=?`{\|}~^-]+(?:\.[\w!#$%&’*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": null,
  "privateKeyId": null,
  "clientEmail": null,
  "privateKey": null
}
```

#### Credentials 3

##### Class Name

`Credentials3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ClientSecret` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": "clientId6",
  "clientSecret": "clientSecret2"
}
```

#### Credentials 5

##### Class Name

`Credentials5`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&’*+/=?`{\|}~^-]+(?:\.[\w!#$%&’*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": "clientId6",
  "privateKeyId": "privateKeyId6",
  "clientEmail": "clientEmail0",
  "privateKey": null
}
```

#### Credentials 11

##### Class Name

`Credentials11`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ClientSecret` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": null,
  "clientSecret": null
}
```

#### Credentials 15

##### Class Name

`Credentials15`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | - |
| `Password` | `string` | Required | - |

##### Example (as JSON)

```json
{
  "username": "username0",
  "password": "password4"
}
```

#### Credentials 16

##### Class Name

`Credentials16`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&'*+/=?`{\|}~^-]+(?:\.[\w!#$%&'*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": "clientId6",
  "privateKeyId": "privateKeyId6",
  "clientEmail": "clientEmail0",
  "privateKey": "privateKey2"
}
```

#### Credentials 17

##### Class Name

`Credentials17`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Required | - |
| `Ssl` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "username": "username0",
  "password": "password4",
  "ssl": null
}
```

#### Credentials 23

##### Class Name

`Credentials23`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "username": null,
  "password": null
}
```

#### Credentials 24

##### Class Name

`Credentials24`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `PrivateKeyId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ClientEmail` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `^[\w!#$%&'*+/=?`{\|}~^-]+(?:\.[\w!#$%&'*+/=?`{\|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$` |
| `PrivateKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "clientId": null,
  "privateKeyId": null,
  "clientEmail": null,
  "privateKey": null
}
```

#### Credentials 25

##### Class Name

`Credentials25`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Optional | - |
| `Ssl` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "username": null,
  "password": null,
  "ssl": null
}
```

#### Cross Account Credentials

##### Class Name

`CrossAccountCredentials`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

##### Example (as JSON)

```json
{
  "externalId": "externalId4",
  "roleArn": "roleArn0"
}
```

#### Cross Account Credentials 4

##### Class Name

`CrossAccountCredentials4`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

##### Example (as JSON)

```json
{
  "externalId": null,
  "roleArn": null
}
```

#### Data

##### Class Name

`Data`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `S3CrossAccountCredentials` | [`Models.S3CrossAccountCredentials`](#s3-cross-account-credentials) | Required | - |

##### Example (as JSON)

```json
{
  "s3CrossAccountCredentials": {
    "externalId": "externalId2",
    "roleArn": "roleArn2",
    "bucketArn": "bucketArn6"
  }
}
```

#### Data 1

##### Class Name

`Data1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhook` | `string` | Required | **Constraints**: *Pattern*: `^https://(api.ciscospark\|webexapis).com/v1/webhooks/incoming([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "webhook": "webhook2"
}
```

#### Data 2

##### Class Name

`Data2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `EventBusArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:events:([a-zA-Z0-9]{1}[a-zA-Z0-9-]+[a-zA-Z0-9]{1}):([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)?$` |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "eventBusArn": "eventBusArn2"
}
```

#### Data 3

##### Class Name

`Data3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatadogType` | [`Models.DatadogServiceEnum`](#datadog-service) | Required | **Default**: `DatadogServiceEnum.Enum_Logs Detail`<br>*Default: `DatadogServiceEnum.Enum_Logs Detail`* |
| `DatadogSite` | [`Models.DatadogSiteEnum`](#datadog-site) | Required | **Default**: `DatadogSiteEnum.com`<br>*Default: `DatadogSiteEnum.com`* |
| `ApiKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "datadogType": "Logs Detail",
  "datadogSite": "com",
  "apiKey": null
}
```

#### Data 4

##### Class Name

`Data4`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChannelProps` | [`Models.ChannelProps`](#channel-props) | Optional | - |
| `NotificationTypes` | [`Models.NotificationTypes`](#notification-types) | Optional | - |

##### Example (as JSON)

```json
{
  "channelProps": null,
  "notificationTypes": null
}
```

#### Data 5

##### Class Name

`Data5`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `Credentials` | [`Models.Credentials`](#credentials) | Required | - |
| `ProjectId` | `string` | Required | - |
| `TopicId` | `string` | Required | - |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": "privateKey8"
  },
  "projectId": "projectId0",
  "topicId": "topicId2"
}
```

#### Data 6

##### Class Name

`Data6`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QradarCommType` | [`Models.CommunicationTypeEnum`](#communication-type) | Required | **Default**: `CommunicationTypeEnum.HTTPS`<br>*Default: `CommunicationTypeEnum.HTTPS`* |
| `QradarHostUrl` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `.+[a-zA-Z0-9]$` |
| `QradarHostPort` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65535` |

##### Example (as JSON)

```json
{
  "qradarCommType": "HTTPS",
  "qradarHostUrl": null
}
```

#### Data 7

##### Class Name

`Data7`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TeamsUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-_\.]*(outlook\|webhook).office.com/webhook[a-zA-Z0-9#-_]*([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "teamsUrl": "teamsUrl6"
}
```

#### Data 8

##### Class Name

`Data8`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InsertKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `AccountId` | `double` | Required | - |

##### Example (as JSON)

```json
{
  "insertKey": "insertKey6",
  "accountId": 31.8
}
```

#### Data 9

##### Class Name

`Data9`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApiIntgKey` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "apiIntgKey": "apiIntgKey6"
}
```

#### Data 10

##### Class Name

`Data10`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `UserName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `InstanceUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://[A-Za-z0-9]+[.]{1}service-now[.]{1}com/?$` |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "userName": "userName2",
  "password": "password4",
  "instanceUrl": "instanceUrl6",
  "customTemplateFile": null
}
```

#### Data 11

##### Class Name

`Data11`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SlackUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://hooks.slack.com([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "slackUrl": "slackUrl0"
}
```

#### Data 12

##### Class Name

`Data12`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HecToken` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Channel` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Host` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Port` | `double` | Required | **Constraints**: `>= 0`, `<= 65536` |
| `Ssl` | `bool?` | Optional | - |
| `EventData` | [`Models.EventData`](#event-data) | Required | - |

##### Example (as JSON)

```json
{
  "hecToken": "hecToken6",
  "channel": null,
  "host": "host8",
  "port": 110.4,
  "ssl": null,
  "eventData": {
    "index": "index6",
    "source": "source4"
  }
}
```

#### Data 13

##### Class Name

`Data13`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IntgUrl` | `string` | Required | **Constraints**: *Maximum Length*: `2083`, *Pattern*: `^https:\/\/alert.victorops.com\/integrations\/generic\/([0-9]+)\/alert\/[a-zA-Z0-9-._~!$&'()*+%,;=:@]+\/[a-zA-Z0-9-._~!$&'()*+%,;=:@]+$` |

##### Example (as JSON)

```json
{
  "intgUrl": "intgUrl6"
}
```

#### Data 14

##### Class Name

`Data14`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookUrl` | `string` | Required | **Constraints**: *Pattern*: `https:\/\/[A-Za-z0-9\/\-&?_.=:]+` |

##### Example (as JSON)

```json
{
  "webhookUrl": "webhookUrl2"
}
```

#### Data 19

##### Class Name

`Data19`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChannelProps` | [`Models.ChannelProps`](#channel-props) | Optional | - |

##### Example (as JSON)

```json
{
  "channelProps": null
}
```

#### Data 30

##### Class Name

`Data30`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `S3CrossAccountCredentials` | [`Models.S3CrossAccountCredentials2`](#s3-cross-account-credentials-2) | Optional | - |

##### Example (as JSON)

```json
{
  "s3CrossAccountCredentials": null
}
```

#### Data 31

##### Class Name

`Data31`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhook` | `string` | Optional | **Constraints**: *Pattern*: `^https://(api.ciscospark\|webexapis).com/v1/webhooks/incoming([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "webhook": null
}
```

#### Data 32

##### Class Name

`Data32`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `EventBusArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:events:([a-zA-Z0-9]{1}[a-zA-Z0-9-]+[a-zA-Z0-9]{1}):([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)?$` |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "eventBusArn": null
}
```

#### Data 33

##### Class Name

`Data33`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatadogType` | [`Models.DatadogServiceEnum?`](#datadog-service) | Optional | **Default**: `DatadogServiceEnum.Enum_Logs Detail`<br>*Default: `DatadogServiceEnum.Enum_Logs Detail`* |
| `DatadogSite` | [`Models.DatadogSiteEnum?`](#datadog-site) | Optional | **Default**: `DatadogSiteEnum.com`<br>*Default: `DatadogSiteEnum.com`* |
| `ApiKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "datadogType": null,
  "datadogSite": null,
  "apiKey": null
}
```

#### Data 34

##### Class Name

`Data34`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChannelProps` | [`Models.ChannelProps2`](#channel-props-2) | Optional | - |

##### Example (as JSON)

```json
{
  "channelProps": null
}
```

#### Data 35

##### Class Name

`Data35`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `Credentials` | [`Models.Credentials2`](#credentials-2) | Optional | - |
| `ProjectId` | `string` | Optional | - |
| `TopicId` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "credentials": null,
  "projectId": null,
  "topicId": null
}
```

#### Data 36

##### Class Name

`Data36`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QradarCommType` | [`Models.CommunicationTypeEnum?`](#communication-type) | Optional | **Default**: `CommunicationTypeEnum.HTTPS`<br>*Default: `CommunicationTypeEnum.HTTPS`* |
| `QradarHostUrl` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `.+[a-zA-Z0-9]$` |
| `QradarHostPort` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65535` |

##### Example (as JSON)

```json
{
  "qradarCommType": null,
  "qradarHostUrl": null,
  "qradarHostPort": null
}
```

#### Data 37

##### Class Name

`Data37`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TeamsUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-_\.]*(outlook\|webhook).office.com/webhook[a-zA-Z0-9#-_]*([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "teamsUrl": null
}
```

#### Data 38

##### Class Name

`Data38`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InsertKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `AccountId` | `double?` | Optional | - |

##### Example (as JSON)

```json
{
  "insertKey": null,
  "accountId": null
}
```

#### Data 39

##### Class Name

`Data39`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApiIntgKey` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "apiIntgKey": null
}
```

#### Data 40

##### Class Name

`Data40`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `UserName` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Password` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `InstanceUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://[A-Za-z0-9]+[.]{1}service-now[.]{1}com/?$` |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "issueGrouping": null,
  "userName": null,
  "password": null,
  "instanceUrl": null,
  "customTemplateFile": null
}
```

#### Data 41

##### Class Name

`Data41`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SlackUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://hooks.slack.com([/][a-zA-Z0-9#-_]+)+$` |

##### Example (as JSON)

```json
{
  "slackUrl": null
}
```

#### Data 42

##### Class Name

`Data42`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HecToken` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Channel` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Host` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Port` | `double?` | Optional | **Constraints**: `>= 0`, `<= 65536` |
| `Ssl` | `bool?` | Optional | - |
| `EventData` | [`Models.EventData2`](#event-data-2) | Optional | - |

##### Example (as JSON)

```json
{
  "hecToken": null,
  "channel": null,
  "host": null,
  "port": null,
  "ssl": null,
  "eventData": null
}
```

#### Data 43

##### Class Name

`Data43`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IntgUrl` | `string` | Optional | **Constraints**: *Maximum Length*: `2083`, *Pattern*: `^https:\/\/alert.victorops.com\/integrations\/generic\/([0-9]+)\/alert\/[a-zA-Z0-9-._~!$&'()*+%,;=:@]+\/[a-zA-Z0-9-._~!$&'()*+%,;=:@]+$` |

##### Example (as JSON)

```json
{
  "intgUrl": null
}
```

#### Data 44

##### Class Name

`Data44`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhookUrl` | `string` | Optional | **Constraints**: *Pattern*: `https:\/\/[A-Za-z0-9\/\-&?_.=:]+` |

##### Example (as JSON)

```json
{
  "webhookUrl": null
}
```

#### Data 45

##### Class Name

`Data45`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials`](#cross-account-credentials) | Required | - |

##### Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": {
    "externalId": "externalId0",
    "roleArn": "roleArn6"
  }
}
```

#### Data 46

##### Class Name

`Data46`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials`](#cross-account-credentials) | Required | - |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |
| `AccountMappingFile` | `Stream` | Optional | - |
| `AccountMapping` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": {
    "externalId": "externalId0",
    "roleArn": "roleArn6"
  },
  "queueUrl": "queueUrl4",
  "accountMappingFile": null,
  "accountMapping": null
}
```

#### Data 47

##### Class Name

`Data47`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials`](#access-key-credentials) | Required | - |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": {
    "accountId": "accountId0",
    "accessKeyId": "accessKeyId6",
    "secretAccessKey": "secretAccessKey0"
  }
}
```

#### Data 48

##### Class Name

`Data48`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials`](#access-key-credentials) | Required | - |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": {
    "accountId": "accountId0",
    "accessKeyId": "accessKeyId6",
    "secretAccessKey": "secretAccessKey0"
  },
  "queueUrl": "queueUrl4"
}
```

#### Data 49

##### Class Name

`Data49`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials3`](#credentials-3) | Required | - |
| `TenantId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `QueueUrl` | `string` | Required | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-]*.queue.core.windows.net/[a-zA-Z0-9-]*` |

##### Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "clientSecret": "clientSecret8"
  },
  "tenantId": "tenantId6",
  "queueUrl": "queueUrl4"
}
```

#### Data 50

##### Class Name

`Data50`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials3`](#credentials-3) | Required | - |
| `TenantId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "clientSecret": "clientSecret8"
  },
  "tenantId": "tenantId6"
}
```

#### Data 51

##### Class Name

`Data51`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials5`](#credentials-5) | Required | - |
| `IdType` | [`Models.IntegrationLevelEnum`](#integration-level) | Required | - |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `SubscriptionName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": null
  },
  "idType": "ORGANIZATION",
  "id": "id0",
  "subscriptionName": "subscriptionName2"
}
```

#### Data 52

##### Class Name

`Data52`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials`](#credentials) | Required | - |
| `IdType` | [`Models.IntegrationLevelEnum`](#integration-level) | Required | - |
| `Id` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": {
    "clientId": "clientId0",
    "privateKeyId": "privateKeyId2",
    "clientEmail": "clientEmail6",
    "privateKey": "privateKey8"
  },
  "idType": "ORGANIZATION",
  "id": "id0"
}
```

#### Data 61

##### Class Name

`Data61`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials4`](#cross-account-credentials-4) | Optional | - |

##### Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": null
}
```

#### Data 62

##### Class Name

`Data62`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AwsAccountId` | `string` | Optional | - |
| `CrossAccountCredentials` | [`Models.CrossAccountCredentials4`](#cross-account-credentials-4) | Optional | - |
| `QueueUrl` | `string` | Optional | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |
| `AccountMappingFile` | `Stream` | Optional | - |
| `AccountMapping` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "awsAccountId": null,
  "crossAccountCredentials": null,
  "queueUrl": null,
  "accountMappingFile": null,
  "accountMapping": null
}
```

#### Data 63

##### Class Name

`Data63`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials4`](#access-key-credentials-4) | Optional | - |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": null
}
```

#### Data 64

##### Class Name

`Data64`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessKeyCredentials` | [`Models.AccessKeyCredentials4`](#access-key-credentials-4) | Optional | - |
| `QueueUrl` | `string` | Optional | **Constraints**: *Pattern*: `^((http[s]?\|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$` |

##### Example (as JSON)

```json
{
  "accessKeyCredentials": null,
  "queueUrl": null
}
```

#### Data 65

##### Class Name

`Data65`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials11`](#credentials-11) | Optional | - |
| `TenantId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `QueueUrl` | `string` | Optional | **Constraints**: *Pattern*: `^https://[a-zA-Z0-9-]*.queue.core.windows.net/[a-zA-Z0-9-]*` |

##### Example (as JSON)

```json
{
  "credentials": null,
  "tenantId": null,
  "queueUrl": null
}
```

#### Data 66

##### Class Name

`Data66`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials11`](#credentials-11) | Optional | - |
| `TenantId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": null,
  "tenantId": null
}
```

#### Data 67

##### Class Name

`Data67`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials2`](#credentials-2) | Optional | - |
| `IdType` | [`Models.IntegrationLevelEnum?`](#integration-level) | Optional | - |
| `Id` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `SubscriptionName` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": null,
  "idType": null,
  "id": null,
  "subscriptionName": null
}
```

#### Data 68

##### Class Name

`Data68`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials2`](#credentials-2) | Optional | - |
| `IdType` | [`Models.IntegrationLevelEnum?`](#integration-level) | Optional | - |
| `Id` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "credentials": null,
  "idType": null,
  "id": null
}
```

#### Datadog

##### Class Name

`Datadog`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Datadog"`<br>*Default: `"Datadog"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data3`](#data-3) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Datadog",
  "enabled": null,
  "data": {
    "datadogType": "Logs Detail",
    "datadogSite": "com",
    "apiKey": null
  }
}
```

#### Datadog 1

##### Class Name

`Datadog1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Datadog"`<br>*Default: `"Datadog"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data3`](#data-3) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Datadog",
  "enabled": null,
  "data": {
    "datadogType": "Logs Detail",
    "datadogSite": "com",
    "apiKey": null
  }
}
```

#### Datadog 2

##### Class Name

`Datadog2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data33`](#data-33) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Docker Hub

##### Class Name

`DockerHub`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials15`](#credentials-15) | Required | - |
| `RegistryType` | `string` | Required | **Default**: `"DOCKERHUB"`<br>*Default: `"DOCKERHUB"`* |
| `RegistryDomain` | `string` | Required | **Default**: `"index.docker.io"`<br>*Default: `"index.docker.io"`* |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": "DOCKERHUB",
  "registryDomain": "index.docker.io"
}
```

#### Docker Hub 2

##### Class Name

`DockerHub2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials23`](#credentials-23) | Optional | - |
| `RegistryType` | [`Models.RegistryType2Enum?`](#registry-type-2) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomain2Enum?`](#registry-domain-2) | Optional | **Default**: `RegistryDomain2Enum.Enum_indexdockerio`<br>*Default: `RegistryDomain2Enum.Enum_indexdockerio`* |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### Docker V2 Registry

##### Class Name

`DockerV2Registry`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials17`](#credentials-17) | Required | - |
| `RegistryType` | `string` | Required | **Default**: `"V2_REGISTRY"`<br>*Default: `"V2_REGISTRY"`* |
| `RegistryDomain` | `string` | Required | - |
| `RegistryNotifications` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": "V2_REGISTRY",
  "registryDomain": null
}
```

#### Docker V2 Registry 2

##### Class Name

`DockerV2Registry2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials25`](#credentials-25) | Optional | - |
| `RegistryType` | [`Models.RegistryType4Enum?`](#registry-type-4) | Optional | - |
| `RegistryDomain` | `string` | Optional | - |
| `RegistryNotifications` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": null,
  "registryDomain": null,
  "registryNotifications": null
}
```

#### Email User

##### Class Name

`EmailUser`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"EmailUser"`<br>*Default: `"EmailUser"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data4`](#data-4) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "EmailUser",
  "enabled": null,
  "data": null
}
```

#### Email User 1

##### Class Name

`EmailUser1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"EmailUser"`<br>*Default: `"EmailUser"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data19`](#data-19) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "EmailUser",
  "enabled": null,
  "data": null
}
```

#### Email User 2

##### Class Name

`EmailUser2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data34`](#data-34) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Event Data

##### Class Name

`EventData`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Index` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Source` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "index": "index4",
  "source": "source4"
}
```

#### Event Data 2

##### Class Name

`EventData2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Index` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Source` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

##### Example (as JSON)

```json
{
  "index": null,
  "source": null
}
```

#### Filters

##### Class Name

`Filters`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Description` | `string` | Optional | - |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `ResourceGroups` | `object` | Optional | one or more unique resource groups |
| `EventCategory` | [`List<Models.EventCategoryEnum>`](#event-category) | Optional | one or more unique event categories<br>**Constraints**: *Unique Items Required* |
| `Severity` | [`List<Models.SeverityEnum>`](#severity) | Optional | 1=Critical 2=High 3=Medium 4=Low 5=Info<br>**Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

##### Example (as JSON)

```json
{
  "name": null,
  "description": null,
  "enabled": null,
  "resourceGroups": null,
  "eventCategory": null,
  "severity": null
}
```

#### Filters 1

##### Class Name

`Filters1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Expression` | [`Models.ExpressionEnum?`](#expression) | Optional | - |
| `Field` | `string` | Optional | - |
| `MValue` | `string` | Optional | - |
| `Values` | `List<string>` | Optional | - |

##### Example (as JSON)

```json
{
  "expression": null,
  "field": null,
  "value": null,
  "values": null
}
```

#### Filters 3

##### Class Name

`Filters3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Description` | `string` | Optional | - |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `ResourceGroups` | `object` | Optional | one or more unique resource groups |
| `Severity` | [`List<Models.SeverityEnum>`](#severity) | Optional | 1=Critical 2=High 3=Medium 4=Low 5=Info<br>**Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

##### Example (as JSON)

```json
{
  "name": null,
  "description": null,
  "enabled": null,
  "resourceGroups": null,
  "severity": null
}
```

#### Format Key 1 Value 1 Key 2 Value 2

##### Class Name

`FormatKey1Value1Key2Value2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Abc` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "abc": null
}
```

#### GCP Resource Group

##### Class Name

`GCPResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"GCP"`<br>*Default: `"GCP"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props2`](#props-2) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "GCP",
  "props": null
}
```

#### GCP Resource Group 1

##### Class Name

`GCPResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"GCP"`<br>*Default: `"GCP"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props8`](#props-8) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "GCP",
  "props": null
}
```

#### GCP Resource Group 2

##### Class Name

`GCPResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props14`](#props-14) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Gcp at Ses

##### Class Name

`GcpAtSes`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpAtSes"`<br>*Default: `"GcpAtSes"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data51`](#data-51) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpAtSes",
  "enabled": null,
  "data": null
}
```

#### Gcp at Ses 1

##### Class Name

`GcpAtSes1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpAtSes"`<br>*Default: `"GcpAtSes"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data51`](#data-51) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpAtSes",
  "enabled": null,
  "data": null
}
```

#### Gcp at Ses 2

##### Class Name

`GcpAtSes2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data67`](#data-67) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Gcp Cfg

##### Class Name

`GcpCfg`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpCfg"`<br>*Default: `"GcpCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data52`](#data-52) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpCfg",
  "enabled": null,
  "data": null
}
```

#### Gcp Cfg 1

##### Class Name

`GcpCfg1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpCfg"`<br>*Default: `"GcpCfg"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data52`](#data-52) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpCfg",
  "enabled": null,
  "data": null
}
```

#### Gcp Cfg 2

##### Class Name

`GcpCfg2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data68`](#data-68) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Gcp Pubsub

##### Class Name

`GcpPubsub`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpPubsub"`<br>*Default: `"GcpPubsub"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data5`](#data-5) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpPubsub",
  "enabled": null,
  "data": null
}
```

#### Gcp Pubsub 1

##### Class Name

`GcpPubsub1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"GcpPubsub"`<br>*Default: `"GcpPubsub"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data5`](#data-5) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "GcpPubsub",
  "enabled": null,
  "data": null
}
```

#### Gcp Pubsub 2

##### Class Name

`GcpPubsub2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data35`](#data-35) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Github Container Registry

##### Class Name

`GithubContainerRegistry`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials17`](#credentials-17) | Required | - |
| `RegistryType` | `string` | Required | **Default**: `"GHCR"`<br>*Default: `"GHCR"`* |
| `RegistryDomain` | `string` | Required | **Default**: `"ghcr.io"`<br>*Default: `"ghcr.io"`* |
| `RegistryNotifications` | `bool?` | Optional | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": "GHCR",
  "registryDomain": "ghcr.io"
}
```

#### Github Container Registry 2

##### Class Name

`GithubContainerRegistry2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials25`](#credentials-25) | Optional | - |
| `RegistryType` | [`Models.RegistryType6Enum?`](#registry-type-6) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomain4Enum?`](#registry-domain-4) | Optional | - |
| `RegistryNotifications` | `bool?` | Optional | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": null,
  "registryDomain": null,
  "registryNotifications": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### Google Container Registry GCR

##### Class Name

`GoogleContainerRegistryGCR`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials16`](#credentials-16) | Required | - |
| `RegistryType` | `string` | Required | **Default**: `"GCP_GCR"`<br>*Default: `"GCP_GCR"`* |
| `RegistryDomain` | [`Models.RegistryDomainEnum`](#registry-domain) | Required | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": "GCP_GCR",
  "registryDomain": null
}
```

#### Google Container Registry GCR 2

##### Class Name

`GoogleContainerRegistryGCR2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials24`](#credentials-24) | Optional | - |
| `RegistryType` | [`Models.RegistryType3Enum?`](#registry-type-3) | Optional | - |
| `RegistryDomain` | [`Models.RegistryDomainEnum?`](#registry-domain) | Optional | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "credentials": null,
  "registryType": null,
  "registryDomain": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### Ibm Qradar

##### Class Name

`IbmQradar`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"IbmQradar"`<br>*Default: `"IbmQradar"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data6`](#data-6) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "IbmQradar",
  "enabled": null,
  "data": {
    "qradarCommType": "HTTPS",
    "qradarHostUrl": null
  }
}
```

#### Ibm Qradar 1

##### Class Name

`IbmQradar1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"IbmQradar"`<br>*Default: `"IbmQradar"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data6`](#data-6) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "IbmQradar",
  "enabled": null,
  "data": {
    "qradarCommType": "HTTPS",
    "qradarHostUrl": null
  }
}
```

#### Ibm Qradar 2

##### Class Name

`IbmQradar2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data36`](#data-36) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Identifier Tag S for Scan

##### Class Name

`IdentifierTagSForScan`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Abc` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "abc": null
}
```

#### Inline Scanner

##### Class Name

`InlineScanner`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegistryType` | `string` | Required | **Default**: `"INLINE_SCANNER"`<br>*Default: `"INLINE_SCANNER"`* |
| `LimitNumScan` | [`Models.LimitNumberOfScansForThisIntegrationEnum?`](#limit-number-of-scans-for-this-integration) | Optional | **Default**: `LimitNumberOfScansForThisIntegrationEnum.Enum_15`<br>*Default: `LimitNumberOfScansForThisIntegrationEnum.Enum_15`* |
| `IdentifierTag` | [`List<Models.IdentifierTagSForScan>`](#identifier-tag-s-for-scan) | Optional | - |

##### Example (as JSON)

```json
{
  "registryType": "INLINE_SCANNER"
}
```

#### Inline Scanner 2

##### Class Name

`InlineScanner2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegistryType` | [`Models.RegistryType5Enum?`](#registry-type-5) | Optional | - |
| `LimitNumScan` | [`Models.LimitNumberOfScansForThisIntegrationEnum?`](#limit-number-of-scans-for-this-integration) | Optional | **Default**: `LimitNumberOfScansForThisIntegrationEnum.Enum_15`<br>*Default: `LimitNumberOfScansForThisIntegrationEnum.Enum_15`* |
| `IdentifierTag` | [`List<Models.IdentifierTagSForScan>`](#identifier-tag-s-for-scan) | Optional | - |

##### Example (as JSON)

```json
{
  "registryType": null,
  "limitNumScan": null,
  "identifierTag": null
}
```

#### Jira

##### Class Name

`Jira`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Jira"`<br>*Default: `"Jira"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | `object` | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Jira",
  "enabled": null,
  "data": null
}
```

#### JIRA CLOUD

##### Class Name

`JIRACLOUD`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `JiraType` | [`Models.JiraTypeEnum?`](#jira-type) | Optional | **Default**: `JiraTypeEnum.JIRA_CLOUD`<br>*Default: `JiraTypeEnum.JIRA_CLOUD`* |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `JiraUrl` | `string` | Required | **Constraints**: *Pattern*: `[a-zA-Z0-9]\.(atlassian\.net\|jira\.com)$` |
| `ProjectId` | `string` | Required | - |
| `IssueType` | `string` | Required | - |
| `Username` | `string` | Required | - |
| `ApiToken` | `string` | Required | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "jiraType": null,
  "issueGrouping": null,
  "jiraUrl": "jiraUrl4",
  "projectId": "projectId0",
  "issueType": "issueType0",
  "username": "username0",
  "apiToken": "apiToken6",
  "customTemplateFile": null
}
```

#### JIRA CLOUD2

##### Class Name

`JIRACLOUD2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `JiraType` | [`Models.JiraTypeEnum?`](#jira-type) | Optional | **Default**: `JiraTypeEnum.JIRA_CLOUD`<br>*Default: `JiraTypeEnum.JIRA_CLOUD`* |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `JiraUrl` | `string` | Optional | **Constraints**: *Pattern*: `[a-zA-Z0-9]\.(atlassian\.net\|jira\.com)$` |
| `ProjectId` | `string` | Optional | - |
| `IssueType` | `string` | Optional | - |
| `Username` | `string` | Optional | - |
| `ApiToken` | `string` | Optional | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "jiraType": null,
  "issueGrouping": null,
  "jiraUrl": null,
  "projectId": null,
  "issueType": null,
  "username": null,
  "apiToken": null,
  "customTemplateFile": null
}
```

#### JIRA SERVER

##### Class Name

`JIRASERVER`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `JiraType` | [`Models.JiraType1Enum?`](#jira-type-1) | Optional | **Default**: `JiraType1Enum.JIRA_SERVER`<br>*Default: `JiraType1Enum.JIRA_SERVER`* |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `JiraUrl` | `string` | Required | **Constraints**: *Pattern*: `[A-Za-z0-9\/\-&?_.=:]+` |
| `ProjectId` | `string` | Required | - |
| `IssueType` | `string` | Required | - |
| `Username` | `string` | Required | - |
| `Password` | `string` | Required | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "jiraType": null,
  "issueGrouping": null,
  "jiraUrl": "jiraUrl4",
  "projectId": "projectId0",
  "issueType": "issueType0",
  "username": "username0",
  "password": "password4",
  "customTemplateFile": null
}
```

#### JIRA SERVER2

##### Class Name

`JIRASERVER2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `JiraType` | [`Models.JiraType1Enum?`](#jira-type-1) | Optional | **Default**: `JiraType1Enum.JIRA_SERVER`<br>*Default: `JiraType1Enum.JIRA_SERVER`* |
| `IssueGrouping` | [`Models.GroupIssuesByEnum?`](#group-issues-by) | Optional | **Default**: `GroupIssuesByEnum.Events`<br>*Default: `GroupIssuesByEnum.Events`* |
| `JiraUrl` | `string` | Optional | **Constraints**: *Pattern*: `[A-Za-z0-9\/\-&?_.=:]+` |
| `ProjectId` | `string` | Optional | - |
| `IssueType` | `string` | Optional | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `CustomTemplateFile` | `Stream` | Optional | - |

##### Example (as JSON)

```json
{
  "jiraType": null,
  "issueGrouping": null,
  "jiraUrl": null,
  "projectId": null,
  "issueType": null,
  "username": null,
  "password": null,
  "customTemplateFile": null
}
```

#### Jira 1

##### Class Name

`Jira1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Jira"`<br>*Default: `"Jira"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Jira",
  "enabled": null,
  "data": null
}
```

#### Jira 2

##### Class Name

`Jira2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Lacework Accounts Resource Group

##### Class Name

`LaceworkAccountsResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"LW_ACCOUNT"`<br>*Default: `"LW_ACCOUNT"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props5`](#props-5) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "LW_ACCOUNT",
  "props": null
}
```

#### Lacework Accounts Resource Group 1

##### Class Name

`LaceworkAccountsResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"LW_ACCOUNT"`<br>*Default: `"LW_ACCOUNT"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props11`](#props-11) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "LW_ACCOUNT",
  "props": null
}
```

#### Lacework Accounts Resource Group 2

##### Class Name

`LaceworkAccountsResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props17`](#props-17) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Limit by Label S Optional

##### Class Name

`LimitByLabelSOptional`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Abc` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "abc": null
}
```

#### Machine Resource Group

##### Class Name

`MachineResourceGroup`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceGuid` | `string` | Optional | - |
| `Guid` | `string` | Optional | - |
| `GuidType` | `string` | Optional | - |
| `IsDefault` | `double?` | Optional | - |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"MACHINE"`<br>*Default: `"MACHINE"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props3`](#props-3) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "MACHINE",
  "props": null
}
```

#### Machine Resource Group 1

##### Class Name

`MachineResourceGroup1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `ResourceType` | `string` | Required | **Default**: `"MACHINE"`<br>*Default: `"MACHINE"`* |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props9`](#props-9) | Required | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "resourceType": "MACHINE",
  "props": null
}
```

#### Machine Resource Group 2

##### Class Name

`MachineResourceGroup2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceName` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | [`Models.EnabledEnum?`](#enabled) | Optional | - |
| `Props` | [`Models.Props15`](#props-15) | Optional | - |

##### Example (as JSON)

```json
{
  "resourceName": null,
  "enabled": null,
  "props": null
}
```

#### Microsoft Teams

##### Class Name

`MicrosoftTeams`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"MicrosoftTeams"`<br>*Default: `"MicrosoftTeams"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data7`](#data-7) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "MicrosoftTeams",
  "enabled": null,
  "data": null
}
```

#### Microsoft Teams 1

##### Class Name

`MicrosoftTeams1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"MicrosoftTeams"`<br>*Default: `"MicrosoftTeams"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data7`](#data-7) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "MicrosoftTeams",
  "enabled": null,
  "data": null
}
```

#### Microsoft Teams 2

##### Class Name

`MicrosoftTeams2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data37`](#data-37) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### New Relic Insights

##### Class Name

`NewRelicInsights`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"NewRelicInsights"`<br>*Default: `"NewRelicInsights"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data8`](#data-8) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "NewRelicInsights",
  "enabled": null,
  "data": null
}
```

#### New Relic Insights 1

##### Class Name

`NewRelicInsights1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"NewRelicInsights"`<br>*Default: `"NewRelicInsights"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data8`](#data-8) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "NewRelicInsights",
  "enabled": null,
  "data": null
}
```

#### New Relic Insights 2

##### Class Name

`NewRelicInsights2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data38`](#data-38) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Notification Types

##### Class Name

`NotificationTypes`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | [`Models.ReportScheduleEnum?`](#report-schedule) | Optional | **Default**: `ReportScheduleEnum.Enum_1200 GMT`<br>*Default: `ReportScheduleEnum.Enum_1200 GMT`* |
| `AwsCisS3` | `bool?` | Optional | - |
| `Pci` | `bool?` | Optional | - |
| `Soc` | `bool?` | Optional | - |
| `Hipaa` | `bool?` | Optional | - |
| `Nist80053Rev4` | `bool?` | Optional | - |
| `Nist800171Rev2` | `bool?` | Optional | - |
| `Iso2700` | `bool?` | Optional | - |
| `AzureCis` | `bool?` | Optional | - |
| `AzurePci` | `bool?` | Optional | - |
| `AzureSoc` | `bool?` | Optional | - |
| `GcpCis` | `bool?` | Optional | - |
| `GcpPci` | `bool?` | Optional | - |
| `GcpSoc` | `bool?` | Optional | - |
| `AgentEvents` | `bool?` | Optional | - |
| `AwsCloudtrailEvents` | `bool?` | Optional | - |
| `AwsComplianceEvents` | `bool?` | Optional | - |
| `AzureComplianceEvents` | `bool?` | Optional | - |
| `GcpComplianceEvents` | `bool?` | Optional | - |
| `AzureActivityLogEvents` | `bool?` | Optional | - |
| `GcpAuditTrailEvents` | `bool?` | Optional | - |
| `NoEvents` | `bool?` | Optional | - |
| `TrendReport` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "time": null,
  "awsCisS3": null,
  "pci": null,
  "soc": null,
  "hipaa": null,
  "nist800-53Rev4": null,
  "nist800-171Rev2": null,
  "iso2700": null,
  "azureCis": null,
  "azurePci": null,
  "azureSoc": null,
  "gcpCis": null,
  "gcpPci": null,
  "gcpSoc": null,
  "agentEvents": null,
  "awsCloudtrailEvents": null,
  "awsComplianceEvents": null,
  "azureComplianceEvents": null,
  "gcpComplianceEvents": null,
  "azureActivityLogEvents": null,
  "gcpAuditTrailEvents": null,
  "noEvents": null,
  "trendReport": null
}
```

#### Pager Duty Api

##### Class Name

`PagerDutyApi`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"PagerDutyApi"`<br>*Default: `"PagerDutyApi"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data9`](#data-9) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "PagerDutyApi",
  "enabled": null,
  "data": null
}
```

#### Pager Duty Api 1

##### Class Name

`PagerDutyApi1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"PagerDutyApi"`<br>*Default: `"PagerDutyApi"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data9`](#data-9) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "PagerDutyApi",
  "enabled": null,
  "data": null
}
```

#### Pager Duty Api 2

##### Class Name

`PagerDutyApi2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data39`](#data-39) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Props

##### Class Name

`Props`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `AccountIds` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "accountIds": [
    "accountIds5",
    "accountIds6"
  ]
}
```

#### Props 1

##### Class Name

`Props1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Tenant` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Subscriptions` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "tenant": "tenant4",
  "subscriptions": [
    "subscriptions9"
  ]
}
```

#### Props 2

##### Class Name

`Props2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `Organization` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Projects` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "organization": "organization6",
  "projects": [
    "projects1",
    "projects2"
  ]
}
```

#### Props 3

##### Class Name

`Props3`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `MachineTags` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Required | **Constraints**: *Minimum Items*: `1` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "machineTags": [
    {
      "abc": null
    },
    {
      "abc": null
    }
  ]
}
```

#### Props 4

##### Class Name

`Props4`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `ContainerLabels` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Required | **Constraints**: *Minimum Items*: `1` |
| `ContainerTags` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "containerLabels": [
    {
      "abc": null
    },
    {
      "abc": null
    },
    {
      "abc": null
    }
  ],
  "containerTags": [
    "containerTags5",
    "containerTags6",
    "containerTags7"
  ]
}
```

#### Props 5

##### Class Name

`Props5`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdatedBy` | `string` | Optional | - |
| `LastUpdated` | `double?` | Optional | - |
| `Description` | `string` | Optional | - |
| `LwAccounts` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "updatedBy": null,
  "lastUpdated": null,
  "description": null,
  "lwAccounts": [
    "lwAccounts2",
    "lwAccounts3",
    "lwAccounts4"
  ]
}
```

#### Props 6

##### Class Name

`Props6`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `AccountIds` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "accountIds": [
    "accountIds5",
    "accountIds6"
  ]
}
```

#### Props 7

##### Class Name

`Props7`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `Tenant` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Subscriptions` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "tenant": "tenant4",
  "subscriptions": [
    "subscriptions9"
  ]
}
```

#### Props 8

##### Class Name

`Props8`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `Organization` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Projects` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "organization": "organization6",
  "projects": [
    "projects1",
    "projects2"
  ]
}
```

#### Props 9

##### Class Name

`Props9`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `MachineTags` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Required | **Constraints**: *Minimum Items*: `1` |

##### Example (as JSON)

```json
{
  "description": null,
  "machineTags": [
    {
      "abc": null
    },
    {
      "abc": null
    }
  ]
}
```

#### Props 10

##### Class Name

`Props10`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `ContainerLabels` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Required | **Constraints**: *Minimum Items*: `1` |
| `ContainerTags` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "containerLabels": [
    {
      "abc": null
    },
    {
      "abc": null
    },
    {
      "abc": null
    }
  ],
  "containerTags": [
    "containerTags5",
    "containerTags6",
    "containerTags7"
  ]
}
```

#### Props 11

##### Class Name

`Props11`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `LwAccounts` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "lwAccounts": [
    "lwAccounts2",
    "lwAccounts3",
    "lwAccounts4"
  ]
}
```

#### Props 12

##### Class Name

`Props12`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `AccountIds` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "accountIds": null
}
```

#### Props 13

##### Class Name

`Props13`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `Tenant` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Subscriptions` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "tenant": null,
  "subscriptions": null
}
```

#### Props 14

##### Class Name

`Props14`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `Organization` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Projects` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "organization": null,
  "projects": null
}
```

#### Props 15

##### Class Name

`Props15`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `MachineTags` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Optional | **Constraints**: *Minimum Items*: `1` |

##### Example (as JSON)

```json
{
  "description": null,
  "machineTags": null
}
```

#### Props 16

##### Class Name

`Props16`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `ContainerLabels` | [`List<Models.FormatKey1Value1Key2Value2>`](#format-key-1-value-1-key-2-value-2) | Optional | **Constraints**: *Minimum Items*: `1` |
| `ContainerTags` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "containerLabels": null,
  "containerTags": null
}
```

#### Props 17

##### Class Name

`Props17`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `LwAccounts` | `List<string>` | Optional | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

##### Example (as JSON)

```json
{
  "description": null,
  "lwAccounts": null
}
```

#### Props 18

##### Class Name

`Props18`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Required | - |
| `LastName` | `string` | Required | - |
| `Company` | `string` | Required | - |
| `AccountAdmin` | `bool?` | Optional | should this user be the admin of current account, will be ignore if org-access is true<br>**Default**: `false`<br>*Default: `false`* |

##### Example (as JSON)

```json
{
  "firstName": "firstName4",
  "lastName": "lastName4",
  "company": "company0",
  "accountAdmin": null
}
```

#### Props 22

##### Class Name

`Props22`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Company` | `string` | Optional | - |
| `AccountAdmin` | `bool?` | Optional | should this user be the admin of current account, will be ignore if org-access is true<br>**Default**: `false`<br>*Default: `false`* |

##### Example (as JSON)

```json
{
  "firstName": null,
  "lastName": null,
  "company": null,
  "accountAdmin": null
}
```

#### Proxy Scanner

##### Class Name

`ProxyScanner`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegistryType` | `string` | Required | **Default**: `"PROXY_SCANNER"`<br>*Default: `"PROXY_SCANNER"`* |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "registryType": "PROXY_SCANNER"
}
```

#### Proxy Scanner 2

##### Class Name

`ProxyScanner2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegistryType` | [`Models.RegistryType7Enum?`](#registry-type-7) | Optional | - |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](#limit-number-of-images-per-repo) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5`<br>*Default: `LimitNumberOfImagesPerRepoEnum.Enum_5`* |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](#limit-by-label-s-optional) | Optional | - |

##### Example (as JSON)

```json
{
  "registryType": null,
  "limitNumImg": null,
  "limitByRep": null,
  "limitByTag": null,
  "limitByLabel": null
}
```

#### Report Notification Types

##### Class Name

`ReportNotificationTypes`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AgentEvents` | `bool?` | Optional | - |
| `AwsCisS3` | `bool?` | Optional | - |
| `AwsCloudtrailEvents` | `bool?` | Optional | - |
| `AwsComplianceEvents` | `bool?` | Optional | - |
| `AzureActivityLogEvents` | `bool?` | Optional | - |
| `AzureCis` | `bool?` | Optional | - |
| `AzureComplianceEvents` | `bool?` | Optional | - |
| `AzurePci` | `bool?` | Optional | - |
| `AzureSoc` | `bool?` | Optional | - |
| `GcpAuditTrailEvents` | `bool?` | Optional | - |
| `GcpCis` | `bool?` | Optional | - |
| `GcpComplianceEvents` | `bool?` | Optional | - |
| `GcpPci` | `bool?` | Optional | - |
| `GcpSoc` | `bool?` | Optional | - |
| `Hipaa` | `bool?` | Optional | - |
| `Iso2700` | `bool?` | Optional | - |
| `Nist80053Rev4` | `bool?` | Optional | - |
| `Nist800171Rev2` | `bool?` | Optional | - |
| `OpenShiftCompliance` | `bool?` | Optional | - |
| `OpenShiftComplianceEvents` | `bool?` | Optional | - |
| `Pci` | `bool?` | Optional | - |
| `Soc` | `bool?` | Optional | - |
| `AwsSocRev2` | `bool?` | Optional | - |
| `TrendReport` | `bool?` | Optional | - |

##### Example (as JSON)

```json
{
  "agentEvents": null,
  "awsCisS3": null,
  "awsCloudtrailEvents": null,
  "awsComplianceEvents": null,
  "azureActivityLogEvents": null,
  "azureCis": null,
  "azureComplianceEvents": null,
  "azurePci": null,
  "azureSoc": null,
  "gcpAuditTrailEvents": null,
  "gcpCis": null,
  "gcpComplianceEvents": null,
  "gcpPci": null,
  "gcpSoc": null,
  "hipaa": null,
  "iso2700": null,
  "nist800-53Rev4": null,
  "nist800-171Rev2": null,
  "openShiftCompliance": null,
  "openShiftComplianceEvents": null,
  "pci": null,
  "soc": null,
  "awsSocRev2": null,
  "trendReport": null
}
```

#### Response Agent Access Tokens

##### Class Name

`ResponseAgentAccessTokens`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Models.AgentAccessTokens`](#agent-access-tokens-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Agent Access Tokens List

##### Class Name

`ResponseAgentAccessTokensList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.AgentAccessTokens>`](#agent-access-tokens-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Alert Channels

##### Class Name

`ResponseAlertChannels`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Alert Channels List

##### Class Name

`ResponseAlertChannelsList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Alert Rules

##### Class Name

`ResponseAlertRules`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Models.AlertRules`](#alert-rules-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Alert Rules List

##### Class Name

`ResponseAlertRulesList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.AlertRules>`](#alert-rules-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Audit Logs List

##### Class Name

`ResponseAuditLogsList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.AuditLogs>`](#audit-logs-2) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Cloud Accounts

##### Class Name

`ResponseCloudAccounts`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Cloud Accounts List

##### Class Name

`ResponseCloudAccountsList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Cloud Activities List

##### Class Name

`ResponseCloudActivitiesList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.CloudActivities>`](#cloud-activities-2) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Container Registries

##### Class Name

`ResponseContainerRegistries`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Models.ContVulnCfg`](#cont-vuln-cfg) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Container Registries List

##### Class Name

`ResponseContainerRegistriesList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.ContVulnCfg>`](#cont-vuln-cfg) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Contract Info List

##### Class Name

`ResponseContractInfoList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.ContractInfo>`](#contract-info-2) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Report Rules

##### Class Name

`ResponseReportRules`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Models.ReportRules`](#report-rules-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Report Rules List

##### Class Name

`ResponseReportRulesList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.ReportRules>`](#report-rules-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Resource Groups

##### Class Name

`ResponseResourceGroups`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Resource Groups List

##### Class Name

`ResponseResourceGroupsList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Team Members

##### Class Name

`ResponseTeamMembers`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Team Members List

##### Class Name

`ResponseTeamMembersList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response Update Team Member

##### Class Name

`ResponseUpdateTeamMember`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `object` | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### Response User Profile List

##### Class Name

`ResponseUserProfileList`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.UserProfile>`](#user-profile-1) | Optional | - |

##### Example (as JSON)

```json
{
  "data": null
}
```

#### S3 Cross Account Credentials

##### Class Name

`S3CrossAccountCredentials`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |
| `BucketArn` | `string` | Required | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:s3:([a-zA-Z0-9-_]+)?:([0-9]{12})?:([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

##### Example (as JSON)

```json
{
  "externalId": "externalId4",
  "roleArn": "roleArn0",
  "bucketArn": "bucketArn4"
}
```

#### S3 Cross Account Credentials 2

##### Class Name

`S3CrossAccountCredentials2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalId` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `RoleArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:iam:([a-zA-Z0-9-_]+)?:([0-9]{12}):([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |
| `BucketArn` | `string` | Optional | **Constraints**: *Pattern*: `^arn:aws(-[a-zA-Z]+)?:s3:([a-zA-Z0-9-_]+)?:([0-9]{12})?:([a-zA-Z0-9_-]+)([/:][a-zA-Z0-9_-]+)*$` |

##### Example (as JSON)

```json
{
  "externalId": null,
  "roleArn": null,
  "bucketArn": null
}
```

#### Service Now Rest

##### Class Name

`ServiceNowRest`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"ServiceNowRest"`<br>*Default: `"ServiceNowRest"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data10`](#data-10) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "ServiceNowRest",
  "enabled": null,
  "data": null
}
```

#### Service Now Rest 1

##### Class Name

`ServiceNowRest1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"ServiceNowRest"`<br>*Default: `"ServiceNowRest"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data10`](#data-10) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "ServiceNowRest",
  "enabled": null,
  "data": null
}
```

#### Service Now Rest 2

##### Class Name

`ServiceNowRest2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data40`](#data-40) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Slack Channel

##### Class Name

`SlackChannel`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"SlackChannel"`<br>*Default: `"SlackChannel"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data11`](#data-11) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "SlackChannel",
  "enabled": null,
  "data": null
}
```

#### Slack Channel 1

##### Class Name

`SlackChannel1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"SlackChannel"`<br>*Default: `"SlackChannel"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data11`](#data-11) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "SlackChannel",
  "enabled": null,
  "data": null
}
```

#### Slack Channel 2

##### Class Name

`SlackChannel2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data41`](#data-41) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Splunk Hec

##### Class Name

`SplunkHec`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"SplunkHec"`<br>*Default: `"SplunkHec"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data12`](#data-12) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "SplunkHec",
  "enabled": null,
  "data": null
}
```

#### Splunk Hec 1

##### Class Name

`SplunkHec1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"SplunkHec"`<br>*Default: `"SplunkHec"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data12`](#data-12) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "SplunkHec",
  "enabled": null,
  "data": null
}
```

#### Splunk Hec 2

##### Class Name

`SplunkHec2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data42`](#data-42) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Time Filter

##### Class Name

`TimeFilter`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `string` | Optional | - |
| `EndTime` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "startTime": null,
  "endTime": null
}
```

#### Victor Ops

##### Class Name

`VictorOps`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"VictorOps"`<br>*Default: `"VictorOps"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data13`](#data-13) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "VictorOps",
  "enabled": null,
  "data": null
}
```

#### Victor Ops 1

##### Class Name

`VictorOps1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"VictorOps"`<br>*Default: `"VictorOps"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data13`](#data-13) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "VictorOps",
  "enabled": null,
  "data": null
}
```

#### Victor Ops 2

##### Class Name

`VictorOps2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data43`](#data-43) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### Webhook

##### Class Name

`Webhook`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Webhook"`<br>*Default: `"Webhook"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1`<br>*Default: `0`* |
| `Props` | `object` | Optional | - |
| `Data` | [`Models.Data14`](#data-14) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Webhook",
  "enabled": null,
  "data": null
}
```

#### Webhook 1

##### Class Name

`Webhook1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Type` | `string` | Required | **Default**: `"Webhook"`<br>*Default: `"Webhook"`* |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data14`](#data-14) | Required | - |

##### Example (as JSON)

```json
{
  "name": null,
  "type": "Webhook",
  "enabled": null,
  "data": null
}
```

#### Webhook 2

##### Class Name

`Webhook2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double?` | Optional | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data44`](#data-44) | Optional | - |

##### Example (as JSON)

```json
{
  "name": null,
  "enabled": null,
  "data": null
}
```

#### With Org-Access

##### Class Name

`WithOrgAccess`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props18`](#props-18) | Required | - |
| `OrgAdmin` | `bool` | Required | should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `OrgUser` | `bool` | Required | should this user be the org user of this org, userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `AdminRoleAccounts` | `List<string>` | Required | list of account names that this user will be admin |
| `UserRoleAccounts` | `List<string>` | Required | list of account names that this user will be user |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](#user-enabled) | Required | - |
| `UserGuid` | `string` | Optional | user guid |

##### Example (as JSON)

```json
{
  "props": null,
  "orgAdmin": false,
  "orgUser": false,
  "adminRoleAccounts": null,
  "userRoleAccounts": null,
  "userName": null,
  "userEnabled": null
}
```

#### With Org-Access 1

##### Class Name

`WithOrgAccess1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props18`](#props-18) | Required | - |
| `OrgAdmin` | `bool` | Required | should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `OrgUser` | `bool` | Required | should this user be the org user of this org, userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `AdminRoleAccounts` | `List<string>` | Required | list of account names that this user will be admin |
| `UserRoleAccounts` | `List<string>` | Required | list of account names that this user will be user |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](#user-enabled) | Required | - |

##### Example (as JSON)

```json
{
  "props": null,
  "orgAdmin": false,
  "orgUser": false,
  "adminRoleAccounts": null,
  "userRoleAccounts": null,
  "userName": null,
  "userEnabled": null
}
```

#### With Org-Access 2

##### Class Name

`WithOrgAccess2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props22`](#props-22) | Optional | - |
| `OrgAdmin` | `bool?` | Optional | should this user be the org admin of this org, adminRoleAccounts and userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `OrgUser` | `bool?` | Optional | should this user be the org user of this org, userRoleAccounts list will be ignored<br>**Default**: `false`<br>*Default: `false`* |
| `AdminRoleAccounts` | `List<string>` | Optional | list of account names that this user will be admin |
| `UserRoleAccounts` | `List<string>` | Optional | list of account names that this user will be user |
| `UserEnabled` | [`Models.UserEnabledEnum?`](#user-enabled) | Optional | - |

##### Example (as JSON)

```json
{
  "props": null,
  "orgAdmin": null,
  "orgUser": null,
  "adminRoleAccounts": null,
  "userRoleAccounts": null,
  "userEnabled": null
}
```

#### Without Org-Access

##### Class Name

`WithoutOrgAccess`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props18`](#props-18) | Required | - |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](#user-enabled) | Required | - |
| `UserGuid` | `string` | Optional | user guid |
| `CustGuid` | `string` | Optional | customer guid |

##### Example (as JSON)

```json
{
  "props": {
    "firstName": "firstName0",
    "lastName": "lastName8",
    "company": "company6",
    "accountAdmin": null
  },
  "userName": "userName2",
  "userEnabled": 1,
  "userGuid": null,
  "custGuid": null
}
```

#### Without Org-Access 1

##### Class Name

`WithoutOrgAccess1`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props18`](#props-18) | Required | - |
| `UserName` | `string` | Required | user email address |
| `UserEnabled` | [`Models.UserEnabledEnum`](#user-enabled) | Required | - |

##### Example (as JSON)

```json
{
  "props": {
    "firstName": "firstName0",
    "lastName": "lastName8",
    "company": "company6",
    "accountAdmin": null
  },
  "userName": "userName2",
  "userEnabled": 1
}
```

#### Without Org-Access 2

##### Class Name

`WithoutOrgAccess2`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Props` | [`Models.Props22`](#props-22) | Optional | - |
| `UserEnabled` | [`Models.UserEnabledEnum?`](#user-enabled) | Optional | - |

##### Example (as JSON)

```json
{
  "props": null,
  "userEnabled": null
}
```

### Enumerations

* [Authentication Type](#authentication-type)
* [Authentication Type 1](#authentication-type-1)
* [Communication Type](#communication-type)
* [Cont Vuln Cfg 1](#cont-vuln-cfg-1)
* [Datadog Service](#datadog-service)
* [Datadog Site](#datadog-site)
* [Enabled](#enabled)
* [Event Category](#event-category)
* [Expression](#expression)
* [Group Issues By](#group-issues-by)
* [Integration Level](#integration-level)
* [Jira Type](#jira-type)
* [Jira Type 1](#jira-type-1)
* [Limit Number of Images Per Repo](#limit-number-of-images-per-repo)
* [Limit Number of Scans for This Integration](#limit-number-of-scans-for-this-integration)
* [Registry Domain](#registry-domain)
* [Registry Domain 2](#registry-domain-2)
* [Registry Domain 4](#registry-domain-4)
* [Registry Type](#registry-type)
* [Registry Type 2](#registry-type-2)
* [Registry Type 3](#registry-type-3)
* [Registry Type 4](#registry-type-4)
* [Registry Type 5](#registry-type-5)
* [Registry Type 6](#registry-type-6)
* [Registry Type 7](#registry-type-7)
* [Report Schedule](#report-schedule)
* [Severity](#severity)
* [Type](#type)
* [Type 1](#type-1)
* [Type 2](#type-2)
* [User Enabled](#user-enabled)

#### Authentication Type

##### Class Name

`AuthenticationTypeEnum`

##### Fields

| Name |
|  --- |
| `AWSIAM` |

#### Authentication Type 1

##### Class Name

`AuthenticationType1Enum`

##### Fields

| Name |
|  --- |
| `AWSACCESSKEY` |

#### Communication Type

##### Class Name

`CommunicationTypeEnum`

##### Fields

| Name |
|  --- |
| `HTTPS` |
| `EnumHTTPSSelfSignedCert` |

#### Cont Vuln Cfg 1

##### Class Name

`ContVulnCfg1Enum`

##### Fields

| Name |
|  --- |
| `AWSECR` |
| `DOCKERHUB` |
| `GCPGCR` |
| `GHCR` |
| `INLINESCANNER` |
| `PROXYSCANNER` |
| `V2REGISTRY` |

#### Datadog Service

##### Class Name

`DatadogServiceEnum`

##### Fields

| Name |
|  --- |
| `EnumLogsDetail` |
| `EnumLogsSummary` |
| `EnumEventsSummary` |

#### Datadog Site

##### Class Name

`DatadogSiteEnum`

##### Fields

| Name |
|  --- |
| `Com` |
| `Eu` |

#### Enabled

##### Class Name

`EnabledEnum`

##### Fields

| Name |
|  --- |
| `Enum0` |
| `Enum1` |

#### Event Category

##### Class Name

`EventCategoryEnum`

##### Fields

| Name |
|  --- |
| `Compliance` |
| `App` |
| `Cloud` |
| `File` |
| `Machine` |
| `User` |

#### Expression

##### Class Name

`ExpressionEnum`

##### Fields

| Name |
|  --- |
| `Eq` |
| `Ne` |
| `In` |
| `NotIn` |
| `Like` |
| `Ilike` |
| `NotLike` |
| `NotIlike` |
| `NotRlike` |
| `Rlike` |
| `Gt` |
| `Ge` |
| `Lt` |
| `Le` |
| `Between` |

#### Group Issues By

##### Class Name

`GroupIssuesByEnum`

##### Fields

| Name |
|  --- |
| `Events` |
| `Resources` |

#### Integration Level

##### Class Name

`IntegrationLevelEnum`

##### Fields

| Name |
|  --- |
| `ORGANIZATION` |
| `PROJECT` |

#### Jira Type

##### Class Name

`JiraTypeEnum`

##### Fields

| Name |
|  --- |
| `JIRACLOUD` |

#### Jira Type 1

##### Class Name

`JiraType1Enum`

##### Fields

| Name |
|  --- |
| `JIRASERVER` |

#### Limit Number of Images Per Repo

##### Class Name

`LimitNumberOfImagesPerRepoEnum`

##### Fields

| Name |
|  --- |
| `Enum5` |
| `Enum10` |
| `Enum15` |

#### Limit Number of Scans for This Integration

##### Class Name

`LimitNumberOfScansForThisIntegrationEnum`

##### Fields

| Name |
|  --- |
| `Enum5` |
| `Enum10` |
| `Enum15` |
| `Enum30` |
| `Enum45` |
| `Enum60` |

#### Registry Domain

##### Class Name

`RegistryDomainEnum`

##### Fields

| Name |
|  --- |
| `EnumGcrio` |
| `EnumUsgcrio` |
| `EnumEugcrio` |
| `EnumAsiagcrio` |

#### Registry Domain 2

##### Class Name

`RegistryDomain2Enum`

##### Fields

| Name |
|  --- |
| `EnumIndexdockerio` |

#### Registry Domain 4

##### Class Name

`RegistryDomain4Enum`

##### Fields

| Name |
|  --- |
| `EnumGhcrio` |

#### Registry Type

##### Class Name

`RegistryTypeEnum`

##### Fields

| Name |
|  --- |
| `AWSECR` |

#### Registry Type 2

##### Class Name

`RegistryType2Enum`

##### Fields

| Name |
|  --- |
| `DOCKERHUB` |

#### Registry Type 3

##### Class Name

`RegistryType3Enum`

##### Fields

| Name |
|  --- |
| `GCPGCR` |

#### Registry Type 4

##### Class Name

`RegistryType4Enum`

##### Fields

| Name |
|  --- |
| `V2REGISTRY` |

#### Registry Type 5

##### Class Name

`RegistryType5Enum`

##### Fields

| Name |
|  --- |
| `INLINESCANNER` |

#### Registry Type 6

##### Class Name

`RegistryType6Enum`

##### Fields

| Name |
|  --- |
| `GHCR` |

#### Registry Type 7

##### Class Name

`RegistryType7Enum`

##### Fields

| Name |
|  --- |
| `PROXYSCANNER` |

#### Report Schedule

##### Class Name

`ReportScheduleEnum`

##### Fields

| Name |
|  --- |
| `Enum0000GMT` |
| `Enum0100GMT` |
| `Enum0200GMT` |
| `Enum0300GMT` |
| `Enum0400GMT` |
| `Enum0500GMT` |
| `Enum0600GMT` |
| `Enum0700GMT` |
| `Enum0800GMT` |
| `Enum0900GMT` |
| `Enum1000GMT` |
| `Enum1100GMT` |
| `Enum1200GMT` |
| `Enum1300GMT` |
| `Enum1400GMT` |
| `Enum1500GMT` |
| `Enum1600GMT` |
| `Enum1700GMT` |
| `Enum1800GMT` |
| `Enum1900GMT` |
| `Enum2000GMT` |
| `Enum2100GMT` |
| `Enum2200GMT` |
| `Enum2300GMT` |

#### Severity

##### Class Name

`SeverityEnum`

##### Fields

| Name |
|  --- |
| `Enum1` |
| `Enum2` |
| `Enum3` |
| `Enum4` |
| `Enum5` |

#### Type

##### Class Name

`TypeEnum`

##### Fields

| Name |
|  --- |
| `AwsS3` |
| `CiscoSparkWebhook` |
| `CloudwatchEb` |
| `Datadog` |
| `EmailUser` |
| `GcpPubsub` |
| `IbmQradar` |
| `Jira` |
| `MicrosoftTeams` |
| `NewRelicInsights` |
| `PagerDutyApi` |
| `ServiceNowRest` |
| `SlackChannel` |
| `SplunkHec` |
| `VictorOps` |
| `Webhook` |

#### Type 1

##### Class Name

`Type1Enum`

##### Fields

| Name |
|  --- |
| `AwsCfg` |
| `AwsCtSqs` |
| `AwsUsGovCfg` |
| `AwsUsGovCtSqs` |
| `AzureAlSeq` |
| `AzureCfg` |
| `GcpAtSes` |
| `GcpCfg` |

#### Type 2

##### Class Name

`Type2Enum`

##### Fields

| Name |
|  --- |
| `ContVulnCfg` |

#### User Enabled

##### Class Name

`UserEnabledEnum`

##### Fields

| Name |
|  --- |
| `Enum1` |
| `Enum0` |

### Exceptions

* [Api V2 Access Tokens 400 Error](#api-v2-access-tokens-400-error)
* [Api V2 Schemas 400 Error](#api-v2-schemas-400-error)
* [Response 404](#response-404)
* [Response Internal Error](#response-internal-error)
* [Response Invalid Date](#response-invalid-date)
* [Response Invalid Type](#response-invalid-type)

#### Api V2 Access Tokens 400 Error

##### Class Name

`ApiV2AccessTokens400ErrorException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

#### Api V2 Schemas 400 Error

##### Class Name

`ApiV2Schemas400ErrorException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

#### Response 404

##### Class Name

`Response404Exception`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

#### Response Internal Error

##### Class Name

`ResponseInternalErrorException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

#### Response Invalid Date

##### Class Name

`ResponseInvalidDateException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

#### Response Invalid Type

##### Class Name

`ResponseInvalidTypeException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Optional | - |

##### Example (as JSON)

```json
{
  "message": null
}
```

## Utility Classes Documentation

### ApiHelper Class

HttpRequest stores necessary information about the http request.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpMethod | The HTTP verb to use for this request. | `HttpMethod` |
| QueryUrl | The query url for the http request. | `string` |
| QueryParameters | Query parameters collection for the current http request. | `Dictionary<string, object>` |
| Headers | Headers collection for the current http request. | `Dictionary<string, string>` |
| FormParameters | Form parameters for the current http request. | `List<KeyValuePair<string, object>>` |
| Body | Optional raw string to send as request body. | `object` |
| Username | Optional username for Basic Auth. | `string` |
| Password | Optional password for Basic Auth. | `string` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `DeepCloneObject<T>(T obj)` | Creates a deep clone of an object by serializing it into a json string and then deserializing back into an object. | `T` |
| `JsonSerialize(object obj, JsonConverter converter = null)` | JSON Serialization of a given object. | `string` |
| `JsonDeserialize<T>(string json, JsonConverter converter = null)` | JSON Deserialization of the given json string. | `T` |

## Common Code Documentation

### HttpRequest Class

HttpResponse stores necessary information about the http response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| RawBody | Gets the stream of the body. | `Stream` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpRequest(HttpMethod method, string queryUrl)` | Constructor to initialize the http request object. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, object body, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, body and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, form parameters and optional Basic auth params. |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `AddHeaders(Dictionary<string, string> HeadersToAdd)` | Concatenate values from a Dictionary to this object. | `Dictionary<string, string>` |
| `AddQueryParameters(Dictionary<string, object> queryParamaters)` | Concatenate values from a Dictionary to query parameters dictionary. | `void` |

### HttpResponse Class

HttpResponse stores necessary information about the http response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| RawBody | Gets the stream of the body. | `Stream` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpResponse(int statusCode, Dictionary<string, string> headers, Stream rawBody)` | Initializes a new instance of the <see cref="HttpResponse"/> class. |

### HttpStringResponse Class

HttpStringResponse inherits from HttpResponse and has additional property of string body.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| Body | Gets the raw string body of the http response. | `string` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpStringResponse(int statusCode, Dictionary<string, string> headers, Stream rawBody, string body) : base(statusCode, headers, rawBody)` | Initializes a new instance of the <see cref="HttpStringResponse"/> class. |

### HttpContext Class

Represents the contextual information of HTTP request and response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Request | Gets the http request in the current context. | `HttpRequest` |
| Response | Gets the http response in the current context. | `HttpResponse` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpContext(HttpRequest request, HttpResponse response)` | Initializes a new instance of the <see cref="HttpContext"/> class. |

### HttpClientConfiguration Class

HttpClientConfiguration represents the current state of the Http Client.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Timeout | Http client timeout. | `TimeSpan` |
| NumberOfRetries | Number of times the request is retried. | `int` |
| BackoffFactor | Exponential backoff factor for duration between retry calls. | `int` |
| RetryInterval | The time interval between the endpoint calls. | `double` |
| BackoffMax | The maximum back off time. | `TimeSpan` |
| StatusCodesToRetry | List of Http status codes to invoke retry. | `IList<int>` |
| RequestMethodsToRetry | List of Http request methods to invoke retry. | `IList<HttpMethod>` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `ToBuilder()` | Creates an object of the HttpClientConfiguration using the values provided for the builder. | `Builder` |

### HttpClientConfiguration Builder Class

Class to build instances of HttpClientConfiguration.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `NumberOfRetries(int numberOfRetries)` | Number of times the request is retried. | `Builder` |
| `BackoffFactor(int backoffFactor)` | Exponential backoff factor for duration between retry calls. | `Builder` |
| `RetryInterval(double retryInterval)` | The time interval between the endpoint calls. | `Builder` |
| `BackoffMax(TimeSpan backoffMax)` | The maximum back off time. | `Builder` |
| `StatusCodesToRetry(IList<int> statusCodesToRetry)` | List of Http status codes to invoke retry. | `Builder` |
| `RequestMethodsToRetry(IList<HttpMethod> requestMethodsToRetry)` | List of Http request methods to invoke retry. | `Builder` |
| `Build()` | Builds a new HttpClientConfiguration object using the set fields. | `HttpClientConfiguration` |

### IAuthManager Class

IAuthManager adds the authenticaion layer to the http calls.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Apply(HttpRequest httpRequest)` | Add authentication information to the HTTP Request. | `HttpRequest` |
| `ApplyAsync(HttpRequest httpRequest)` | Asynchronously add authentication information to the HTTP Request. | `Task<HttpRequest>` |

### ApiException Class

This is the base class for all exceptions that represent an error response from the server.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| ResponseCode | Gets the HTTP response code from the API request. | `int` |
| HttpContext | Gets or sets the HttpContext for the request and response. | `HttpContext` |

#### Constructors

| Name | Description |
|  --- | --- |
| `ApiException(string reason, HttpContext context)` | Initializes a new instance of the <see cref="ApiException"/> class. |

