#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis').[DoesNotReturnIfAttribute](System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute.md 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')
## DoesNotReturnIfAttribute.DoesNotReturnIfAttribute(bool) Constructor
Initializes a new instance of the [DoesNotReturnIfAttribute](System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute.md 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')  
class with the specified parameter value.  
```csharp
public DoesNotReturnIfAttribute(bool parameterValue);
```
#### Parameters
<a name='System_Diagnostics_CodeAnalysis_DoesNotReturnIfAttribute_DoesNotReturnIfAttribute(bool)_parameterValue'></a>
`parameterValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The condition parameter value.  
Code after the method is considered unreachable by diagnostics if the argument  
to the associated parameter matches this value.  
  
