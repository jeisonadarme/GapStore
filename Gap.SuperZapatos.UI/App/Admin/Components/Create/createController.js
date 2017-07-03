/**
 * Created by jeisonlopez on 3/07/17.
 */
/**
 * Created by jeisonlopez on 2/07/17.
 */
(function (angular) {
    'use strict';

    function create(articlesService, storesService){
        var $ctrl = this;
        this.$routerOnActivate = function() {
            storesService.getAll(function (response) {
                console.log(response);
                if (response.data.success){
                    $ctrl.stores = response.data.stores;
                }
            });
        };
        
        $ctrl.storeSubmit = function () {
            console.log($ctrl.store);
            $("#btn-create-store").button("loading");
            storesService.post($ctrl.store, function (error, response) {
                if (error){
                    toastr.error('An error has occurred, try again later please.', {timeOut: 5000});
                    $("#btn-create-store").button("reset");
                    return;    
                }
                
                console.log(response);
                if (response.data.success){
                    toastr.success('The store was created successfully.', {timeOut: 5000});
                    $("#btn-create-store").button("reset");
                    $ctrl.store = {};
                }else{
                    toastr.error('An error has occurred, try again later please.', {timeOut: 5000});
                }
            });
        };
        
        $ctrl.articleSubmit = function () {
            console.log($ctrl.article);
            $("#btn-create-article").button("loading");
            articlesService.post($ctrl.article, function (error, response) {
                if (error){
                    toastr.error('An error has occurred, try again later please.', {timeOut: 5000});
                    $("#btn-create-article").button("reset");
                    return;    
                }
                
                console.log(response);
                if (response.data.success){
                    toastr.success('The article was created successfully.', {timeOut: 5000});
                    $("#btn-create-article").button("reset");
                    $ctrl.article = {};
                }else{
                    toastr.error('An error has occurred, try again later please.', {timeOut: 5000});
                }
            });
        }
    }

    angular.module('create', ['articlesService','storesService'])
        .component('create', {
            templateUrl: 'App/Admin/Components/Create/create.html',
            bindings: {
                $router: '<'
            },
            controller: create
        });
})(window.angular);