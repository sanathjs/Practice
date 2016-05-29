var app = angular.module('app', ['ui.grid', 'ui.grid.pagination']);

app.controller('studentcontroller', function ($scope, angularService) {
    $scope.gridOptions1 = {
        paginationPageSizes: [25, 50, 75],
        paginationPageSize: 25,
        columnDefs: [
                      { name: 'Name' },
                      { name: 'Address' },
                      { name: 'DateOfBirth' },
                      { name: 'Phone' },
                      { name: 'EmergencyContact' },
                      { name: 'DateOfRegistration' }
        ]
    };
    //$http.get('Home/getPatientlist').then(function (response) {
    //    $scope.patients = response.data
    //    $scope.gridOptions1.data = response.data;
    //});

    GetAllPatients();
    //To Get All Records  
    function GetAllPatients() {
        var getData = angularService.getPatients();
        getData.then(function (pat) {
            $scope.patients = pat.data;
            $scope.gridOptions1.data = pat.data;
        }, function () {
            alert('Error in getting records');
        });
    }
    debugger;
    $scope.SearchPatient = function (Patient) {
        var getData = angularService.getPatient(Patient.Id);
    }
});

