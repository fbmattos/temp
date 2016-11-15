'use strict';

exports.drive_state = function(args, res, next) {
  /**
   * parameters expected in the args:
  * id (String)
  **/
    var examples = {};
  examples['application/json'] = {
  "shift_state" : "sport",
  "heading" : 6,
  "latitude" : 37.4292,
  "speed" : 94.5,
  "longitude" : 122.1381
};
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
}

exports.set_temps = function(args, res, next) {
  /**
   * parameters expected in the args:
  * id (String)
  * driver_temp (String)
  * passenger_temp (String)
  **/
    var examples = {};
  examples['application/json'] = {
  "result" : true,
  "reason" : ""
};
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
}

exports.vehicleGET = function(args, res, next) {
  /**
   * parameters expected in the args:
  **/
    var examples = {};
  examples['application/json'] = {
  "color" : "Red",
  "vin" : "5YJSA1CN5CFP01657",
  "display_name" : "Fernando's Model S",
  "vehicle_id" : "1234567890"
};
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
}

