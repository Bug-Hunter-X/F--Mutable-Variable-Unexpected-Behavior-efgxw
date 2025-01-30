let x = ref 10 // Use a mutable reference instead

let addOne xRef = 
  xRef := !xRef + 1 // Dereference and modify the reference

let y = addOne x

printf "%d %d" !x y // Output: 11 11

// The value of x is now 11

printf "%d" !x // Output: 11