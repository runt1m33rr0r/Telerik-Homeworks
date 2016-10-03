function solve(args) {
    var x = args[0];
    var y = args[1];

    var dist = Math.sqrt((1 - x) * (1 - x) + (1 - y) * (1 - y));
    var ptCircle = dist <= 1.5 ? "inside circle " : "outside circle ";
    var ptRect = (x >= -1 && x <= 5) && (y >= -1 && y <= 1) ? "inside rectangle " : "outside rectangle";

    return ptCircle + ptRect;
}