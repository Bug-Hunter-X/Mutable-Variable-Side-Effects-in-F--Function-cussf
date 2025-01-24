let add x y = 
    let newX = x + y
    let newY = y + newX
    newX + newY

let x = 10
let y = 20

printf "%A" (add x y)

//Demonstrates immutability - x and y remain unchanged
printfn "x: %d, y: %d" x y