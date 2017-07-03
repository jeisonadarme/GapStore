/**
 * Created by jeisonlopez on 2/07/17.
 */
(function(){
    'use strict';

    angular.module('storesService', [])
        .factory('storesService', ['$http','urlApi', 'token', function($http, urlApi, token){
            
            var url = urlApi;
            
            var getAll = function (callback) {
                $http({
                    url: url + "/services/stores",
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
            
            var post = function (store, callback) {
                $http({
                    url: url + "/store/create",
                    method: "post",
                    data: store,
                    headers: {
                        'Authorization': token
                    }
                }).then(function successCallback(response) {
                    return callback(false, response);
                }, function errorCallback(response) {
                    return callback(true, response);
                });
            };
            
            return {
                getAll: getAll,
                get: get,
                post: post
            }
        }])
})();