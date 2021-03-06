/**
 * This is a demo API
 * API to control the Tesla Model S
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package io.swagger.client.model;

import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;

@ApiModel(description = "")
public class InlineResponse2003 {
  
  @SerializedName("shift_state")
  private String shiftState = null;
  @SerializedName("heading")
  private Integer heading = null;
  @SerializedName("latitude")
  private Double latitude = null;
  @SerializedName("speed")
  private Double speed = null;
  @SerializedName("longitude")
  private Double longitude = null;

  /**
   **/
  @ApiModelProperty(value = "")
  public String getShiftState() {
    return shiftState;
  }
  public void setShiftState(String shiftState) {
    this.shiftState = shiftState;
  }

  /**
   * integer compass heading
   * minimum: 0.0
   * maximum: 359.0
   **/
  @ApiModelProperty(value = "integer compass heading")
  public Integer getHeading() {
    return heading;
  }
  public void setHeading(Integer heading) {
    this.heading = heading;
  }

  /**
   * degrees north of equator
   **/
  @ApiModelProperty(value = "degrees north of equator")
  public Double getLatitude() {
    return latitude;
  }
  public void setLatitude(Double latitude) {
    this.latitude = latitude;
  }

  /**
   **/
  @ApiModelProperty(value = "")
  public Double getSpeed() {
    return speed;
  }
  public void setSpeed(Double speed) {
    this.speed = speed;
  }

  /**
   * degrees west of the prime meridian
   **/
  @ApiModelProperty(value = "degrees west of the prime meridian")
  public Double getLongitude() {
    return longitude;
  }
  public void setLongitude(Double longitude) {
    this.longitude = longitude;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse2003 inlineResponse2003 = (InlineResponse2003) o;
    return (this.shiftState == null ? inlineResponse2003.shiftState == null : this.shiftState.equals(inlineResponse2003.shiftState)) &&
        (this.heading == null ? inlineResponse2003.heading == null : this.heading.equals(inlineResponse2003.heading)) &&
        (this.latitude == null ? inlineResponse2003.latitude == null : this.latitude.equals(inlineResponse2003.latitude)) &&
        (this.speed == null ? inlineResponse2003.speed == null : this.speed.equals(inlineResponse2003.speed)) &&
        (this.longitude == null ? inlineResponse2003.longitude == null : this.longitude.equals(inlineResponse2003.longitude));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (this.shiftState == null ? 0: this.shiftState.hashCode());
    result = 31 * result + (this.heading == null ? 0: this.heading.hashCode());
    result = 31 * result + (this.latitude == null ? 0: this.latitude.hashCode());
    result = 31 * result + (this.speed == null ? 0: this.speed.hashCode());
    result = 31 * result + (this.longitude == null ? 0: this.longitude.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse2003 {\n");
    
    sb.append("  shiftState: ").append(shiftState).append("\n");
    sb.append("  heading: ").append(heading).append("\n");
    sb.append("  latitude: ").append(latitude).append("\n");
    sb.append("  speed: ").append(speed).append("\n");
    sb.append("  longitude: ").append(longitude).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
