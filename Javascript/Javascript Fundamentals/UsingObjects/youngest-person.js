function solve(people) {
    var youngest = +people[2];
    var youngestName = people[0] + " " + people[1];

    for (var i = 0; i < people.length; i+=3) {
        if (+people[i + 2] < youngest) {
            youngest = +people[i + 2];
            youngestName = people[i] + " " + people[i + 1];
        }
    }

    console.log(youngestName);
}