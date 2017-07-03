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
            articlesService.get(id, function (response) {
                console.log(response);
                if (response.data.success){
                    $ctrl.article = response.data.article;
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