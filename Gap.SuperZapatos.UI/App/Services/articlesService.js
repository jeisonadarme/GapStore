/**
 * Created by jeisonlopez on 2/07/17.
 */
(function(){
    'use strict';

    angular.module('articlesService', [])
        .factory('articlesService', ['$http', function($http){
            
            var url = "http://localhost:5000";
            
            var getAll = function (callback) {
                $http({
                    url: url + "/services/articles",
                    method: "get"
                }).then(function (response) {
                    return callback(response);
                })
            };

            var get = function (id, callback) {
                $http({
                    url: url + "/services/articles/" + id,
                    method: "get"
                }).then(function successCallback(response) {
                    return callback(false, response);
                }, function errorCallback(response) {
                    return callback(true, response);
                });
            };
            
            var getByStoreId = function (id, callback) {
                $http({
                    url: url + "/services/articles/stores/" + id,
                    method: "get"
                }).then(function successCallback(response) {
                    return callback(false, response);
                }, function errorCallback(response) {
                    return callback(true, response);
                });
            };
            
            var post = function (article, callback) {
                $http({
                    url: url + "/article/create",
                    method: "post",
                    data: JSON.stringify(article)
                }).then(function successCallback(response) {
                    return callback(false, response);
                }, function errorCallback(response) {
                    return callback(true, response);
                });
            };
            
            return {
                getAll: getAll,
                get: get,
                getByStoreId: getByStoreId,
                post: post
            }
        }])
})();