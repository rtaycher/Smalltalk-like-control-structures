using System;
namespace SmalltalkBooleanExtensionMethods
{


		public static class BooleanExtension
		{
			public delegate Object ClosureWithNoExtraArgs ();
			public delegate void ActionClosureWithNoExtraArgs ();

			public static Object ifTrue (this bool aBoolen, ClosureWithNoExtraArgs method)
			{
				if (aBoolen)
					return method.DynamicInvoke ();
				else
					return null;
			}

			public static Object ifTrue (this bool aBoolen, ActionClosureWithNoExtraArgs method)
			{
				if (aBoolen)
					return method.DynamicInvoke ();
				else
					return null;
			}


			public static Object ifFalse (this bool aBoolen, ClosureWithNoExtraArgs method)
			{
				if (!aBoolen)
					return method.DynamicInvoke ();
				else
					return null;
			}

			public static Object ifFalse (this bool aBoolen, ActionClosureWithNoExtraArgs method)
			{
				if (!aBoolen)
					return method.DynamicInvoke ();
				else
					return null;
			}


			public static Object ifTrueifFalse (this Boolean aBoolen, ClosureWithNoExtraArgs methodA, ClosureWithNoExtraArgs methodB)
			{
				if (aBoolen)
					return methodA.DynamicInvoke ();
				else
					return methodB.DynamicInvoke ();
			}

			public static Object ifTrueifFalse (this Boolean aBoolen, ActionClosureWithNoExtraArgs methodA, ActionClosureWithNoExtraArgs methodB)
			{
				if (aBoolen)
					return methodA.DynamicInvoke ();
				else
					return methodB.DynamicInvoke ();
			}
			
		}
	

}
