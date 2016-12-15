'use strict';

var url = require('url');


var Default = require('./DefaultService');


module.exports.climate_state = function climate_state (req, res, next) {
  Default.climate_state(req.swagger.params, res, next);
};

module.exports.set_temps = function set_temps (req, res, next) {
  Default.set_temps(req.swagger.params, res, next);
};

module.exports.vehicleGET = function vehicleGET (req, res, next) {
  Default.vehicleGET(req.swagger.params, res, next);
};

module.exports.vehiclesIdData_requestDrive_stateGET = function vehiclesIdData_requestDrive_stateGET (req, res, next) {
  Default.vehiclesIdData_requestDrive_stateGET(req.swagger.params, res, next);
};
