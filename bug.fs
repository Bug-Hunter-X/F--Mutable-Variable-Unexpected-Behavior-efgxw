let mutable x = 10

let addOne x = x + 1

let y = addOne x

printf "%d %d" x y // Output: 10 11

x <- x + 1

printf "%d" x // Output: 11