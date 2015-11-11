var p;

var Person = function(name) {
    this.name = name;
    var age;
    this.getAge = function () {
        return age;
    }
    this.setAge = function (value) {
        if (!typeof (value) == "number" || value < 0) {
            throw "ERROR";
        }
        age = value;
    }
}

p = new Person("Joe");
p.setAge(p.getAge() + 1);
p.age = 3;
