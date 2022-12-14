"use strict"; // Included to prevent any legacy code weirdness

// IN JS, "//" is comments
// In C#, to make int -> specifically request an int
// In JS, we use dynamic typing to determine the data type of vars

var number = 1;
number = "some string";

console.log(number);

console.log("Hello, world!");

//let and var
var name = "Rich"; // var is function scoped
let pet = "Claude"; // let is block scoped

// hoisting... is a JS feature...
value = 5; // Assign a value to my variable before I declare it.
console.log(value) // Pass the undeclared variable to a function
var value; // Only after that, did we actually declare it (with var)
// Getting rid of line 21 will give us an error!

// operators... mostly the same as C# BUT "===" and "==" are different!
console.log(5=='5')
console.log(5==='5')

// Truthy and falsy
// false, 0, "", null, NaN, -0, 0n

// Type conversions
// 3 common ones
// to number, to string, to boolean

// Control Flow
// if/else
// loops  (for, while, do/while)
// conditionals
for(let i = 0; i < 10; i++) {
    console.log("Looped" + i);
}

if(5=='5') {
    console.log('Nyeah');
} else {
    console.log("Didn't work");
}

// Functions
// a JS function is handled like an object, has name parameters and a body
//function + name . Parameters go inside the parenthesis
function myFunc(from, text="none") {
    var funcScope = 5;
    let globalScoped = 12;
    console.log(from + ": " + text + " " + funcScope)
}

//console.log(funcScope);
//console.log(globalScoped)
myFunc("Jason", "Rich show us your hedgehog!");
myFunc("Jason");

try {
    function addNums(a, b) {
        return a + b;
    }

    function multNums(a, b) {
        return a * b;
    }

    function doMath(a, b, func) {
        return func(a, b);
    }

    let runFunc = addNums;
    let runFunc2 = multNums;
    console.log(doMath(5, 6, multNums))
} catch(o) {
    console.log("Error");
}