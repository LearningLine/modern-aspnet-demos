function sayHello() {
    console.log("Hello my name is " + this + this.name);
}
var p = {
    name: "Paul",
    sayHello: sayHello
};
var p2 = {
    name: "David",
    sayHello: sayHello,
    sayHelloAgain : function() {
        sayHello();
        this.sayHello();
    },
    setup: function () {
        //var that = this;
        /*
        window.document.querySelector("#button").addEventListener("click",
    function () {
        window.document.querySelector("#myDiv").innerHTML = that.name;
    });*/
        window.document.querySelector("#button").addEventListener("click",
            () => window.document.querySelector("#myDiv").innerHTML = this.name
        );
    }
}
p2.sayHello();
p.sayHello();
var f = p.sayHello;
var f2 = p2.sayHello;
p2.setup();

console.log(f === f2);
f();
f2();


