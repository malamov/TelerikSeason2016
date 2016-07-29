function youngest(args) {
    var peopleNum = args.length / 3,
        people = [],
        youngestAge = Number.MAX_VALUE,
        personAge = 0,
        youngPIndex = 0;
    console.log(args);
    for (var i = 0; i < +peopleNum; i += 1) {

        people[i] = makePerson(args[i * 3], args[i * 3 + 1], +args[i * 3 + 2]);

        personAge = people[i].age;

        if (personAge < youngestAge) {
            youngPIndex = i;
            youngestAge = personAge;
        }
    }

    function makePerson(fName, lName, age) {
        return {
            fName: fName,
            lName: lName,
            age: age
        };
    }
    console.log(people[youngPIndex].fName + ' ' + people[youngPIndex].lName);
}




youngest([
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
]);