var survey = {
    question: ko.observable("What's your favorite color"),
    response: ko.observable("Blue"),
    height: ko.observable("10"),
    width: ko.observable("20"),
}

survey.surface = ko.computed(function () {
    return Number(survey.width()) * Number(survey.height());
}),

survey.width(Number(survey.width()) + 1);

survey.response.subscribe(function () {
    console.log("response changed");
});

ko.applyBindings(survey);
