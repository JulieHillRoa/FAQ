var FAQ = angular.module("FAQ", ['ui.bootstrap', 'ngRoute']);

FAQ.config(function ($routeProvider) {
    $routeProvider
    .when("/", { templateUrl: "Faqs.html", controller: "HomeController" })
    .when('/Ask', {
        controller: 'HomeController',
        templateUrl: 'AskQuestion.html'
    })
    .when('/Faq', {
        controller: 'HomeController',
        templateUrl: 'Faqs.html'
    })
    .when('/Faq/:id', {
        controller: 'FaqController',
        templateUrl: 'FaqsCategory.html'
    })
    .when('/SeeUnanswered', {
         controller: 'AdminController',
         templateUrl: 'SeeUnanswerdQuestions.html'
     })
    .otherwise({
        controller: "HomeController",
        templateUrl: "Faqs.html"
    });
})



FAQ.controller('HomeController', function ($scope, $http,$location) {

    var url = '../../api/Home/';
    $scope.onload = true;

    function getAll() {
    $http.get(url).
      success(function (allcategories) {
          $scope.category = allcategories;
          $scope.onload = false;
         
         
      }).
      error(function (data, status) {
          console.log(status + data);
      });
};

getAll();

$scope.sumbitQuestion = function () {
 
    var question = {
        email: $scope.email,
        categoryID: $scope.categoryID,
        question: $scope.message,
        
    };

    $http.post(url, question).
      success(function (data) {
          alert('Du har nå sendt et spøsrmål, du vil få svar innen 5 virkedager :)');
          $location.path('/Faq');
          
      }).
      error(function (data, status) {
          alert('OPS ! noe gikk galt');
      });
};


});

FAQ.controller("FaqController", function ($scope, $http, $routeParams,$route) {
     
    
    function getCat() {
        $http.get('../../api/Home/' + $routeParams.id).
        success(function (allQIncategories) {
            $scope.list = allQIncategories;
           

        }).
        error(function (data, status) {
            console.log(status + data);
        });
    };
    getCat();

});
