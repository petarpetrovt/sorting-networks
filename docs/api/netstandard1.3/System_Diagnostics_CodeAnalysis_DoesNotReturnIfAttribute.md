#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')
## DoesNotReturnIfAttribute Class
Specifies that the method will not return if the associated [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
parameter is passed the specified value.  
```csharp
internal sealed class DoesNotReturnIfAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; DoesNotReturnIfAttribute  
### Constructors

***
[DoesNotReturnIfAttribute(bool)](System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute_DoesNotReturnIfAttribute(bool).md 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool)')

Initializes a new instance of the [DoesNotReturnIfAttribute](System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute.md 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')  
class with the specified parameter value.  
### Properties

***
[ParameterValue](System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute_ParameterValue.md 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue')

Gets the condition parameter value.  
Code after the method is considered unreachable by diagnostics if the argument  
to the associated parameter matches this value.  
