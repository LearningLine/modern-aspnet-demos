function Person(name, age) {
    this.name = name;
    this.age = age;
    
}



var p = new Person("Willie", 28);
Person.prototype.sayHello = function () {
    console.log("Hey, my name is " + this.name);
};

p.sayHello = function () { console.log("I am busy, don't want to talk"); }
p.sayHello();
delete (p.sayHello);
// don't do this delete (Person.prototype.sayHello);
p.sayHello();

var p2 = new Person("Luke", 23);
p2.sayHello();
console.log(p.name);
p.state = "AZ";
p['list of hobbies'] = ["bike", "hiking"];
