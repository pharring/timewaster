function gaussian(mu, sigma, method) {
    var x = method();
    return mu + x * sigma;
}

function box_muller() {
    var u1 = 1.0 - Math.random();
    var u2 = 1.0 - Math.random();
    return Math.sqrt(-2.0 * Math.log(u1)) * Math.sin(2 * Math.PI * u2);
}

function AbramowitzStegunApproximation(p) {
    var c0 = 2.515517;
    var c1 = 0.802853;
    var c2 = 0.010328;
    var d1 = 1.432788;
    var d2 = 0.189269;
    var d3 = 0.001308;

    var t = Math.sqrt(-2.0 * Math.log(p));
    var tt = t * t;
    var ttt = tt * t;
    return t - ((c0 + c1 * t + c2 * tt) / (1 + d1 * t + d2 * tt + d3 * ttt));
}

function AbramowitzStegun() {
    var p = Math.random();
    return p < 0.5 ? AbramowitzStegunApproximation(1.0 - p) : -AbramowitzStegunApproximation(p);
}

function arrayMax(arr) {
    var len = arr.length;
    var max = -Infinity;
    while (len--) {
        if (arr[len] > max) {
            max = arr[len];
        }
    }

    return max;
}

var c_buckets = 120;
var _values = new Array(c_buckets);

function Run(iterations, method) {
    _values.fill(0);

    var mean = _values.length / 2.0;
    var sigma = _values.length / 6.0;

    for (var i = 0; i < iterations; i++) {
        var bucketNumber = parseInt(gaussian(mean, sigma, method));
        if (bucketNumber >= 0 && bucketNumber < _values.length) {
            _values[bucketNumber]++;
        }
    }
}

function Print() {
    var max = arrayMax(_values);
    var rows = Math.floor(Math.min(30, max));
    var scale = max / rows;

    for (var i = 0; i < rows; i++) {
        var threshold = scale * (rows - i);
        var line = "";
        for (var j = 0; j < _values.length; j++) {
            line += (_values[j] >= threshold ? '*' : ' ');
        }

        console.log(line);
    }
}

var iterations = 100000000;

if (process.argv.length > 2) {
    iterations = parseInt(process.argv[2]);
}

var start = new Date().getTime();

console.log("Running " + iterations + " iterations.");

console.log("Box Muller:");
Run(iterations, box_muller);
Print();

console.log("Abramowitz/Stegun:");
Run(iterations, AbramowitzStegun);
Print();

var elapsed = (new Date().getTime()) - start;
console.log("Total time: " + elapsed + " ms");