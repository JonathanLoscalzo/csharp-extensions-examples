# Extend interface with behavior. 
## Run
dotnet restore && dotnet run.

## Use
To provide helper functionality relevant to every implementation of an interface, if said functionality can be written in terms of the core interface. This is because **concrete implementations cannot otherwise be assigned to interfaces**.

For example, the LINQ to Objects operators are implemented as extension methods for all IEnumerable<T> types. Thus, any IEnumerable<> implementation is automatically LINQ-enabled.

## TIPS
DO NOT define extension methods implementing a feature in namespaces normally associated with other features. Instead, define them in the namespace associated with the feature they belong to.  
CONSIDER defining extension methods in the **same namespace as the extended type if the type is an interface and if the extension methods are meant to be used in most or all cases.**

_____________

