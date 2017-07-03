/**
 * Created by jeisonlopez on 2/07/17.
 */
(function (angular) {
    'use strict';

    angular.module('app', ['ngComponentRouter','index', 'detail', 'create','ui.utils.masks'])
        .config(function ($locationProvider) {
            $locationProvider.html5Mode(true);
        })
        .value('$routerRootComponent', 'app')
        .component('app', {
            template: '<ng-outlet></ng-outlet>',
            bindings: { $router: '<' },
            $routeConfig: [
                { path: "/", name: "Index", component: "index", useAsDefault: true },
                { path: "/detail/:id", name: "Detail", component: "detail" },
                { path: "/administration", name: "Create", component: "create" }
            ]
        });
})(window.angular);