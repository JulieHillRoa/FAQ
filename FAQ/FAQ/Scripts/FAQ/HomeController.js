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
    .when('/SeeUnanswered', {
         controller: 'AdminController',
         templateUrl: 'SeeUnanswerdQuestions.html'
     })
    .when('/answer', {
        controller: 'AdminController',
        templateUrl: 'ChangeQuestion.html'
    })
    .otherwise({
        controller: "HomeController",
        templateUrl: "Faqs.html"
    });
})



FAQ.controller('HomeController', function ($scope, $http,$route) {

    var url = '../../api/Home/';
    $scope.all = true;
    $scope.showcategory = false;
    $scope.searchdiv = false;
    $scope.onload = true;

    function getAll() {
    $http.get(url).
      success(function (allcategories) {
          $scope.category = allcategories;
          console.log(allcategories);
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
          $route.reload();
          
      }).
      error(function (data, status) {
          alert('OPS ! noe gikk galt');
      });
};

$scope.seeCategory = function (id) {
    $scope.all = false;
    $scope.searchdiv = true;
    $scope.showcategory = true;
   

        $http.get(url+id).
          success(function (allQIncategories) {
              $scope.list = allQIncategories;
              console.log(allQIncategories);
              console.log(allQIncategories[0].category);
              

          }).
          error(function (data, status) {
              console.log(status + data);
          });
};



});

