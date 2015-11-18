(function () {
    'use strict';

    var app = angular.module('app', ['ngRoute']);

    app.config(['$routeProvider',
      function ($routeProvider) {
          $routeProvider.
            when('/index.html', {
                templateUrl: 'app/index/index.html',
                controller: 'indexController',
                controllerAs: 'controller'
            }).
            otherwise({
                redirectTo: '/index.html'
            });
      }]);

})();