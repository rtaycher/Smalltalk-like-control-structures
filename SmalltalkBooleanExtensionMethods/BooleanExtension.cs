using System;
namespace SmalltalkBooleanExtensionMethods
{

	public static class BooleanExtension
	{
		public static T ifTrue<T> (this bool aBoolean, Func<T> method)
		{
			if (aBoolean)
				return (T)method();
			else
				return default(T);
		}

		public static void ifTrue (this bool aBoolean, Action method)
		{
			if (aBoolean)
				method();
		}


		public static T ifFalse<T> (this bool aBoolean, Func<T> method)
		{
			if (!aBoolean)
				return (T)method();
			else
				return default(T);
		}

		public static void ifFalse (this bool aBoolean, Action method)
		{
			if (!aBoolean)
				method();
		}


		public static T ifTrueifFalse<T> (this Boolean aBoolean, Func<T> methodA, Func<T> methodB)
		{
			if (aBoolean)
				return (T)methodA();
			else
				return (T)methodB();
		}

		public static void ifTrueifFalse (this Boolean aBoolean, Action methodA, Action methodB)
		{
			if (aBoolean)
				methodA();
			else
				methodB();
		}
		
	}
	
	
}
