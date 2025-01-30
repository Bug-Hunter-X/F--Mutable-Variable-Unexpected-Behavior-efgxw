# F# Mutable Variable Unexpected Behavior

This example demonstrates a potential issue with mutable variables in F# when passed to functions.

The initial value of `x` is 10. The `addOne` function adds 1 to its input, but it doesn't modify the original variable `x`.  After calling `addOne`, `x` remains 10, while `y` becomes 11.

However, when `x` is directly modified using `x <- x + 1`, the change is reflected, illustrating the mutable nature of `x`.