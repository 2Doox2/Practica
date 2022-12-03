
let arr = []
let fruite = ["МДК!","Слово","Смысл!","Жизнь","Земля","Планета!","Красота","Округ!","Система!","Игорь!",
"САО","Продуктивность!","Орёл","Донецк!","Это!","Не бойся","***","-Боль","А","С"]
let Eroor=["!","-",",","_",".",";",":"]

function calc(str) {
    let result=0
    for (const Prepin of str) {
       if (Eroor.includes(Prepin)) {
        result++;
       } 
    }
    return result
}
let result = 0
fruite.forEach(element => {
    console.log(`${element} : ${calc(element)}`)
    result+=calc(element)
});
console.log (result)
 
