var FAQ = angular.module('FAQ');


FAQ.controller('AdminController', function ($scope, $http, $route) {

    var url = '../../api/Admin/';
    $scope.unasweredsQuestions = true;
    $scope.ChangeQuestion = false;

    function getUnanswered() {
        $http.get(url).
          success(function (allcategories) {
              $scope.categorylist = allcategories;
              
          }).
          error(function (data, status) {
              console.log(status + data);
          });
};

    getUnanswered();


$scope.changeQuestion = function (id){
 
    $scope.unasweredsQuestions = false;
    $scope.ChangeQuestion = true;
   

    $http.get(url + id).
       success(function (question) {
           
           $scope.id = question.id;
           $scope.cid = question.categoryid;
           $scope.date = question.date;
           $scope.category = question.category;
           $scope.question = question.question;
           $scope.isfeguant = question.isfequant;
           $scope.email = question.email;
         
       }).
       error(function (data, status) {
           console.log(status + data);
       });
    
    
};


$scope.updateQuestion = function () {  
    var question = {
        id: $scope.id,
        categoryid: $scope.cid,
        date: $scope.date,
        question: $scope.question,
        answer: $scope.answer,
        isfequant: $scope.isfequant,
        email: $scope.email
    };
   
    $scope.unasweredsQuestions = true;
    $scope.ChangeQuestion = false;
       
    $http.put(url + $scope.id, question).
        success(function (data) {
         
            getUnanswered();
        }).
        error(function (data, status) {
            console.log(status + data);
        });
};

$scope.deleteQuestion = function (id) {

    $http.delete(url + id).
    success(function (data) {
        $route.reload();
    }).
      error(function (data, status) {
          console.log(status + data);
      });
};


});

