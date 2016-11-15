# DefaultApi

All URIs are relative to *https://virtserver.swaggerhub.com/fbmattos/Tesla-Demo/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**driveState**](DefaultApi.md#driveState) | **GET** /vehicles/{id}/data_request/drive_state | 
[**setTemps**](DefaultApi.md#setTemps) | **POST** /vehicles/{id}/command/set_temps | 
[**vehicleGet**](DefaultApi.md#vehicleGet) | **GET** /vehicle | 


<a name="driveState"></a>
# **driveState**
> InlineResponse2002 driveState(id)



Returns the driving and position state of the vehicle.

### Example
```java
// Import classes:
//import io.swagger.client.api.DefaultApi;

DefaultApi apiInstance = new DefaultApi();
String id = "id_example"; // String | The ID number of the car
try {
    InlineResponse2002 result = apiInstance.driveState(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#driveState");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The ID number of the car |

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setTemps"></a>
# **setTemps**
> InlineResponse2001 setTemps(id, driverTemp, passengerTemp)



Set the temperature target for the HVAC system.

### Example
```java
// Import classes:
//import io.swagger.client.api.DefaultApi;

DefaultApi apiInstance = new DefaultApi();
String id = "id_example"; // String | The ID number of the car
String driverTemp = "driverTemp_example"; // String | The desired temperature on the driver's side in celcius.
String passengerTemp = "passengerTemp_example"; // String | The desired temperature on the passenger's side in celcius.
try {
    InlineResponse2001 result = apiInstance.setTemps(id, driverTemp, passengerTemp);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setTemps");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The ID number of the car |
 **driverTemp** | **String**| The desired temperature on the driver&#39;s side in celcius. |
 **passengerTemp** | **String**| The desired temperature on the passenger&#39;s side in celcius. |

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="vehicleGet"></a>
# **vehicleGet**
> InlineResponse200 vehicleGet()



Details about owned vehicle

### Example
```java
// Import classes:
//import io.swagger.client.api.DefaultApi;

DefaultApi apiInstance = new DefaultApi();
try {
    InlineResponse200 result = apiInstance.vehicleGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#vehicleGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

