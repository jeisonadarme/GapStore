/**
 * Created by jeisonlopez on 2/07/17.
 */
/**
 * Created by jeisonlopez on 2/07/17.
 */
(function (angular) {
    'use strict';

    function detail(articlesService){
        var $ctrl = this;
        this.$routerOnActivate = function(next) {
            var id = next.params.id;
            
            articlesService.get(id, function (error, response) {
                
                console.log(response);
                
                if (error){
                    toastr.error('An error has occurred:  ' + response.statusText, {timeOut: 5000});
                    return;    
                }
                
                console.log(response);
                if (response.data.success){
                    $ctrl.article = response.data.article;
                }else{
                    toastr.error('An error has occurred, try again later please.', {timeOut: 5000});
                }
            });
            
            
        };
    }

    angular.module('detail', ['articlesService'])
        .component('detail', {
            templateUrl: 'App/Home/Components/Detail/detail.html',
            bindings: {
                $router: '<'
            },
            controller: detail
        });
})(window.angular);