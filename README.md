# F# Mutable Variable Bug

This repository demonstrates a common error in F# involving mutable variables and their side effects within a function. The `add` function modifies its input parameters, resulting in unexpected and difficult-to-debug behavior.

The solution illustrates a better approach using immutable variables and pure functions, improving code clarity, predictability, and maintainability.  This is a key principle of functional programming.