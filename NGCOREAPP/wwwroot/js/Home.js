var app = angular.module("APP", []);
app.controller("Home", function ($scope, $http) {

    $scope.GenerateShort = function () {

        $http({
            method: "POST",
            headers: { "Content-Type": "Application/json; charset=utf-8" },
            url: "/Home/GenerateShortLink",
            data: $scope._link,
        }).then(function (result) {

            $scope.ShortLink = result.data;
            $scope.GetLinkList();

        });
    }
    $scope.GetLinkList = function () {

        $http({
            method: "POST",
            headers: { "Content-Type": "Application/json; charset=utf-8" },
            url: "/Home/GetLinkList",
        }).then(function (result) {

            $scope.LinkList = result.data;

        });


    }











});