var SupportDeskCntrl = angular.module("umbraco");


SupportDeskCntrl.controller("SupportDesk", function ($scope, userService) {
    $scope.user = userService.getCurrentUser();
    console.log($scope.user);
    $scope.myProperty = {
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

    $scope.askQuestion = function () {
        console.log($scope.question)
    }

});