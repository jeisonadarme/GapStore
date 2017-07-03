/**
 * Created by jeisonlopez on 2/07/17.
 */
(function (angular) {
    'use strict';

    function index(articlesService, storesService){
        var $ctrl = this;
        this.$routerOnActivate = function() {
            getAll();
            storesService.getAll(function (response) {
                console.log(response);
                if (response.data.success){
                    $ctrl.stores = response.data.stores;
                }
            });
        };
        
        $ctrl.filterBy = function (id) {
            if(id === -1){
                getAll();
                return;
            }
            
            articlesService.getByStoreId(id, function (response) {
                console.log(response);
                if (response.data.success){
                    $ctrl.articles = response.data.articles;
                }
            });
        };
        
        function getAll() {
            articlesService.getAll(function (response) {
                console.log(response);
                if (response.data.success){
                    $ctrl.articles = response.data.articles;
                }
            });
        }
    }

    angular.module('index', ['articlesService','storesService'])
        .component('index', {
            templateUrl: 'App/Home/Components/Index/index.html',
            bindings: {
                $router: '<'
            },
            controller: index
        });
})(window.angular);