function solve(args) {
    var num = +args[0];
    var row = '';

    for (var i = 1; i <= num; i++) {
        for (var j = i; j <= num + (i-1); j++) {
            row+=j+' ';
        }
        console.log(row);
        row ='';
    }
}