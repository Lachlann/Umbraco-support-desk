var SupportDeskCntrl = angular.module("umbraco");



SupportDeskCntrl.controller("SupportDesk", function ($scope, userService, $http) {
    $scope.answersLoading = true;
    userService.getCurrentUser().then(function (result) {
        console.log(result);
        $scope.user = result;
    });
    console.log("current user");
    

    $scope.rteProp = {
        label: 'bodyText',
        description: 'Load some stuff here',
        view: 'rte',
        config: {
            editor: {
                toolbar: ["code", "undo", "redo", "cut", "styleselect", "bold", "italic", "alignleft", "aligncenter", "alignright", "bullist", "numlist", "link", "umbmediapicker", "umbmacro", "table", "umbembeddialog"],
                stylesheets: [],
                dimensions: { height: 400, width: '100%' }
            }
        }
    };


    $http.get("/umbraco/api/faq/getallfaqs").
        then(function (result) {
            console.log(result);
            $scope.allfaqs = result.data;
            $scope.answersLoading = false;
        })

    $scope.askQuestion = function () {
        console.log($scope.question)
        $http.post("/umbraco/api/faq/addfaq", {
            Question: $scope.question,
            User: $scope.user.id,
            Status: "unsolved",
            Answer: ""
        }).then(function (result) {
            console.log(result);
            $scope.allfaqs = result.data;
        })
    }

    $scope.SubmitAnswer = function (faqId, Question) {
        console.log($scope.rteProp);
        console.log('update answer: ' + faqId);

        $http.post("/umbraco/api/faq/updatefaq", {
            TicketId: faqId,
            Question: Question,
            User: $scope.user,
            Status: "answered",
            Answer: $scope.rteProp.value
        }).then(function (result) {
            console.log(result);
            $scope.allfaqs = result.data;
        })
    }

});