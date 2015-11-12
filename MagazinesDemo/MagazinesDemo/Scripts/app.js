/// <reference path="typings/es6-promise/es6-promise.d.ts" />
alert("yo");
var p = new Promise(function (resolve, reject) {
    var r = new XMLHttpRequest();
    r.open("GET", "/api/magazines", true);
    r.onreadystatechange = function (ev) {
        if (r.readyState === 4) {
            resolve({ status: r.status, response: r.response });
        }
    };
    r.send();
});
var p2 = p.then(function (x) {
    if (x.status == 200)
        return x.response;
    else
        throw x.status;
});
var p3 = p2.then(function (result) { return result; }, function (error) { return alert("where was a problem"); });
var p4 = p3.then(function (result) { return JSON.parse(result); });
var p5 = p4.then(function (o) { return o.forEach(function (item) {
    var parent = document.getElementById("magazines");
    var div = document.createElement("div");
    div.innerText = item.title;
    parent.appendChild(div);
}); });
//# sourceMappingURL=app.js.map