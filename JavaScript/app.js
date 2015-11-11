
var temperatureData = function() {
    return
    [
        45,
        50,
        43
    ];
};

function nameOfDay(day)
{
    var result = "I don't know";
    switch (day) {
    case 0:
        result = "Sunday";
    case 1:
        result = "mon";break;
    case 2:
        result = "tue";break;
    case 3:
        return "Wed";
    case 4:
        result = "thu";break;
    case 5:
        result = "fri";break;
    case 6:
        result = "sat";break;
    }
    return result;
}
function write(x) {
    if (x){
        console.log("you passed true");
    }
        console.log("you passed true, I think")
}

var s = "10";
var number = parseInt(s, 10);
console.log(number);

write(false);
console.log(nameOfDay(3));

var x = 0.1;
var y = 0.2;
var z = x + y;
console.log(z === 0.3);
console.log(z);

var n = -1 / 0;
var n2 = parseInt("abc");
console.log(n);
console.log(isNaN(n2));
console.log(isNaN(n));
console.log(Number.isNaN(n));

var d = new Date();
console.log("Month = " + d.getMonth());
console.log("Day??? = " + d.getDay());
console.log("Day = " + d.getDate());

var input = 2;
var input2 = "2";

console.log(input + input2);

var array = ["a", "b", "c"];
for (var x in array) {
    console.log(x);
}
array.forEach(function (x) { console.log(x); });
//array[5] = "f";
array.push("f");
console.log(array.length);

console.log(array.length);
var table = {
    1: "a",
    2: "b",
    3: "c",
    5: "f"
};
array = [7, 15, 23, 9, 3];
array.sort(function (x, y) {
    if (x > y)
        return 1;
    else if (x < y)
        return -1;
    return 0;
});
array.forEach(function(x) {
    console.log(x);
});
var x = 0;
var y = 1;
console.log(x == y);

function buy(name, price, quantity) {
    //quantity = quantity || 1;
    if (quantity === void 0) quantity = 1;
    console.log("buying "
        + name + " at price "
        + price + " # quantity: " + quantity);
}

buy("iPad", 599);

function test(n) {
    var isNaN = n != -999;
    return isNaN;
}

test(3);
console.log(isNaN(3));