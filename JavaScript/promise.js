
var p = new Promise(function(fulfill, reject) {

});

var p1 = new Promise(function (fulfill, reject) {
    setTimeout(function() { fulfill("hello"); }, 1000);
});



var p2 = p1.then(
    function (result) {
        console.log("p1 got result " + result);
        return "from p1: " + result;
    },
    function(error) {
        console.log("Ooops2 p1 got error" + error);
    });

var p3 = p1.then(
    function (result) {
        console.log("p1 got result " + result);
        throw "error in p3";
    },
    function (error) {
        console.log("Ooops2 p1 got error" + error);
    });
var p4 = p2.then(function(result) {
    console.log("p2 got result " + result);
        return "returning from p4 " + result;
    },
    function(error) {
        console.log("p2 got error" + error)
    }
);

var p5 = p3.then(function (result) {
    console.log("p3 got result " + result);
        
    },
    function (error) {
        console.log("ERROR!!! got error" + error);
        return "success";
    }
);
var p7 = p3.then(function (result) {
    console.log("p3 got result " + result);

},
    function (error) {
        console.log("ERROR!!! got error" + error);
        throw "ERROR again";
    }
);


var p6 = p5.then(function(result) {
    console.log("Got success from p5" + result);
}, function(error) {
    console.log("Got error from p5" + error);
});
var p8 = p7.then(function(result) {
    console.log("Got success from p7" + result);
}, function(error) {
    console.log("Got error from p7" + error);
});

var waitForTwoPromises = Promise.all([p1, p2]);
waitForTwoPromises.then(function(results) {
    console.log(results);
});

p = p;