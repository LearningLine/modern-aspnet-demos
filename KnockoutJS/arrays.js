var vm = {
    surveys: ko.observableArray([
        {
            question: "What 's your favorite color",
            isVisible: true,
            created: new Date()
        },
        {
            question: "What 's your favorite food",
            isVisible: false,
            created: new Date()
        }
    ]),
    newSurveyText: ko.observable(""),
    newSurveyIsVisible: ko.observable(false),
};
vm.add = function() {
    vm.surveys.push(
    {
        question: ko.observable(vm.newSurveyText()),
        isVisible: ko.observable(vm.newSurveyIsVisible()),
        created: new Date(),
    });
    vm.newSurveyText("");
    vm.newSurveyIsVisible(false);
};


ko.applyBindings(vm);
