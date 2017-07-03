/**
 * Created by jeisonlopez on 2/07/17.
 */
(function(){
    'use strict';

    angular.module('storesService', [])
        .factory('storesService', ['$http', function($http){
            
            var url = "http://localhost:5000";
            
            var getAll = function (callback) {
                $http({
                    url: url + "/store/get",
                    method: "get"
                }).then(function (response) {
                    return callback(response);
                })
            };

            var get = function (id, callback) {
                $http({
                    url: url + "/" + id,
                    method: "get"
                }).then(function (response) {
                    return callback(response);
                })
            };
            
            return {
                getAll: getAll,
                get: get
            }
        }])
})();