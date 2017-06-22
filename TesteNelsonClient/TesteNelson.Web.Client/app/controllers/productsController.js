app.controller('productsController', ['$http', function ($http) {
    var self = this;

    self.items = [];

    $http.get('http://localhost:59975/api/products/').then(function (response) {
        self.items = response.data;
    }, function (error) {
        alert('Erro reportado: ' + error);
    });
}]);
