### Microsoft guideline for Extension methods
- X AVOID defining extension methods on System.Object.  
- X DO NOT put extension methods in the same namespace as the extended type unless it is for adding methods to interfaces or for dependency management.
- X AVOID defining two or more extension methods with the same signature, even if they reside in different namespaces.
- ✓ CONSIDER defining extension methods in the same namespace as the extended type if the type is an interface and if the extension methods are meant to be used in most or all cases.
- X DO NOT define extension methods implementing a feature in namespaces normally associated with other features. Instead, define them in the namespace associated with the feature they belong to.
- X AVOID generic naming of namespaces dedicated to extension methods (e.g., "Extensions"). Use a descriptive name (e.g., "Routing") instead.

_________________________________________________


### New syntax for C# 8 ! 

https://channel9.msdn.com/Blogs/Seth-Juarez/A-Preview-of-C-8-with-Mads-Torgersen#time=32m11s  

#### Extension Everything
``` 
extension CustomerExt extends Customer {
    //
}
``` 

#### Extension Interfaces

Extension interfaces, the ability to add new interfaces to existing classes, is also being considered. This would not be a C# 8 feature though, as it would require changes to the underlying run

