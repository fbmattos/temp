# SWGAdminOperationsApi

All URIs are relative to *https://dev-virtserver.swaggerhub.com/fbmattos/atest2/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addInventory**](SWGAdminOperationsApi.md#addinventory) | **POST** /inventory | adds an inventory item


# **addInventory**
```objc
-(NSNumber*) addInventoryWithInventoryItem: (SWGInventoryItem*) inventoryItem
        completionHandler: (void (^)(NSError* error)) handler;
```

adds an inventory item

Adds an item to the system

### Example 
```objc

SWGInventoryItem* inventoryItem = [[SWGInventoryItem alloc] init]; // Inventory item to add (optional)

SWGAdminOperationsApi*apiInstance = [[SWGAdminOperationsApi alloc] init];

// adds an inventory item
[apiInstance addInventoryWithInventoryItem:inventoryItem
          completionHandler: ^(NSError* error) {
                        if (error) {
                            NSLog(@"Error calling SWGAdminOperationsApi->addInventory: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inventoryItem** | [**SWGInventoryItem***](SWGInventoryItem*.md)| Inventory item to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

