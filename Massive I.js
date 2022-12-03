console.log ("Massive I.js")
let before = [1,2,-3,4,-5,-6,7,8,9,-10,
-11,-12,13]
let after = before.map(elem =>{
    return elem<0?3:elem;
})
console.log ({before,after});
