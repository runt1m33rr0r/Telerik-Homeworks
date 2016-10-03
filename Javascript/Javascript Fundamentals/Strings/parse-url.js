function solve(args) {
    var input = args[0].split('');
    var lastIndex = 0;

    // get protocol
    var protocol = input.splice(0, input.indexOf(':'));
    input.splice(1, input.indexOf(':') + 2);
    console.log("protocol: " + protocol.join(''));

    //get server
    var server = input.splice(1, input.indexOf('/') - 1);
    input.splice(0, lastIndex + 1);

    console.log("server: " + server.join(''));
    console.log("resource: " + input.join(''));
}