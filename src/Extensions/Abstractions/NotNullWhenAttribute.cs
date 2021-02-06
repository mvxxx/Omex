// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

#if NETSTANDARD2_0 || NETFRAMEWORK // This marker attribute only available starting from netstandard 2.1, so we need a replacement to build for full framework
namespace System.Diagnostics.CodeAnalysis
{
	/// <summary>
	/// Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class NotNullWhenAttribute : Attribute
	{
		/// <summary>
		/// Initializes the attribute with the specified return value condition
		/// </summary>
		/// <param name="returnValue">
		/// The return value condition. If the method returns this value, the associated parameter will not be null
		/// </param>
		public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

		/// <summary>
		/// Gets the return value condition
		/// </summary>
		public bool ReturnValue { get; }
	}

	/// <summary>
	/// Specifies that the output will be non-null if the named parameter is non-null.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
	public sealed class NotNullIfNotNullAttribute : Attribute
	{
		/// <summary>
		/// Gets the associated parameter name.
		/// </summary>
		/// <remarks>
		/// The associated parameter name. The output will be non-null if the argument to the parameter specified is non-null.
		/// </remarks>
		public string ParameterName { get; }

		/// <summary>
		/// Initializes the attribute with the associated parameter name.
		/// </summary>
		/// <param name="parameterName">The associated parameter name. The output will be non-null if the argument to the parameter specified is non-null.</param>
		public NotNullIfNotNullAttribute(string parameterName) => ParameterName = parameterName;
	}
}
#endif
