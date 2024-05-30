// ReSharper disable CheckNamespace
using System;
using System.Diagnostics;

namespace JetBrains.Annotations;

/// <summary>
/// Indicates that marked element is a CQRS Command.
/// </summary>
/// <example>
/// Class A and method Foo will be interpreted as Command by CQRS-related analyses.
/// <code>
/// [Command]
/// public class A {}
/// 
/// public class B
/// {
/// [Command]
/// void Foo() {}
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Constructor |
                AttributeTargets.Method |
                AttributeTargets.Property)]
[Conditional("JETBRAINS_ANNOTATIONS")]
public class CommandAttribute : Attribute { }

/// <summary>
/// Indicates that marked element is a CQRS Query.
/// </summary>
/// <example>
/// Class A and method Foo will be interpreted as Query by CQRS-related analyses.
/// <code>
/// [Query]
/// public class A {}
/// 
/// public class B
/// {
/// [Query]
/// void Foo() {}
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Constructor |
                AttributeTargets.Method |
                AttributeTargets.Property)]
[Conditional("JETBRAINS_ANNOTATIONS")]
public class QueryAttribute : Attribute { }

/// <summary>
/// Indicates that marked element is a CQRS CommandHandler.
/// </summary>
/// <example>
/// Class A will be interpreted as CommandHandler by CQRS-related analyses.
/// <code>
/// [CommandHandler]
/// public class A {}
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Constructor |
                AttributeTargets.Method |
                AttributeTargets.Property)]
[Conditional("JETBRAINS_ANNOTATIONS")]
public class CommandHandlerAttribute : Attribute { }

/// <summary>
/// Indicates that marked element is a CQRS QueryHandler.
/// </summary>
/// <example>
/// Class A will be interpreted as QueryHandler by CQRS-related analyses.
/// <code>
/// [QueryHandler]
/// public class A {}
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Constructor |
                AttributeTargets.Method |
                AttributeTargets.Property)]
[Conditional("JETBRAINS_ANNOTATIONS")]
public class QueryHandlerAttribute : Attribute { }

/// <summary>
/// Indicates that marked element must be excluded from CQRS-related analyses.
/// </summary>
/// <example>
/// Class A and method Foo will be excluded from CQRS-related analyses.
/// <code>
/// [NoCqrs]
/// public class A {}
/// 
/// public class B
/// {
/// [NoCqrs]
/// void Foo() {}
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Constructor |
                AttributeTargets.Method |
                AttributeTargets.Property)]
[Conditional("JETBRAINS_ANNOTATIONS")]
public class NoCqrsAttribute : Attribute { }
