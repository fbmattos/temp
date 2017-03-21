/**
 * NOTE: This class is auto generated by the akka-scala (beta) swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * For any issue or feedback, please open a ticket via https://github.com/swagger-api/swagger-codegen/issues/new
 */
package io.swagger.client.api

import io.swagger.client.model.Inline_response_200
import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object DefaultApi {

  /**
   * 
   * 
   * Expected answers:
   *   code 200 : Seq[String] (OK)
   */
  def somethingArrayGet(): ApiRequest[Seq[String]] =
    ApiRequest[Seq[String]](ApiMethods.GET, "https://virtserver.swaggerhub.com/fbmattos/Examples_for_Mocking/1.0.0", "/something_array", "application/json")
      .withSuccessResponse[Seq[String]](200)
        /**
   * 
   * 
   * Expected answers:
   *   code 200 : Inline_response_200 (OK)
   */
  def somethingBasicGet(): ApiRequest[Inline_response_200] =
    ApiRequest[Inline_response_200](ApiMethods.GET, "https://virtserver.swaggerhub.com/fbmattos/Examples_for_Mocking/1.0.0", "/something_basic", "application/json")
      .withSuccessResponse[Inline_response_200](200)
      

}

