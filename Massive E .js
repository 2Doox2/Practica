console.log ("Мassive E.js")
let arr = new Array()
let fruite = ["1","2","3","4","5","6","7","8","9","10",
"11","12","13","14","15","16","17","18","19","20"]
let F = fruite.map((val, i, arr) => i == 0 ? Math.max(...arr) : (i == arr.indexOf(Math.max(...arr)) ? arr[0] : val));
console.log(F);
