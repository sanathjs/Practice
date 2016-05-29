var app = angular.module('app', []);

app.controller('studentcontroller', function ($scope, $http) {
    $http.get('http://localhost:51147/').then(function (response) {
        $scope.patients=response.data
    });

});