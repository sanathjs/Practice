app.service("angularService", function ($http) {
    debugger;
    //get All Eployee
    this.getPatients = function () {
        return $http.get("Home/getPatientlist");
    };

    // get Employee By Id
    this.getPatient = function (PatientID) {
        var response = $http({
            method: "post",
            url: "Home/GetPatientById",
            params: {
                id: JSON.stringify(employeeID)
            }
        });
        return response;
    }

    // Update Employee 
    this.updatePatient = function (Patient) {
        var response = $http({
            method: "post",
            url: "Home/UpdateEmployee",
            data: JSON.stringify(Patient),
            dataType: "json"
        });
        return response;
    }

    // Add Employee
    this.AddPatient = function (Patient) {
        var response = $http({
            method: "post",
            url: "Home/AddEmployee",
            data: JSON.stringify(Patient),
            dataType: "json"
        });
        return response;
    }

    //Delete Employee
    this.DeletePatient = function (PatientId) {
        var response = $http({
            method: "post",
            url: "Home/DeleteEmployee",
            params: {
                employeeId: JSON.stringify(PatientId)
            }
        });
        return response;
    }
});