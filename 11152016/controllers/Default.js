'use strict';

var url = require('url');


var Default = require('./DefaultService');


module.exports.drive_state = function drive_state (req, res, next) {
  Default.drive_state(req.swagger.params, res, next);
};

module.exports.set_temps = function set_temps (req, res, next) {
  Default.set_temps(req.swagger.params, res, next);
};

module.exports.vehicleGET = function vehicleGET (req, res, next) {
  Default.vehicleGET(req.swagger.params, res, next);
};
