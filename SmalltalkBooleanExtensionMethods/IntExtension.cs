using System;
namespace SmalltalkBooleanExtensionMethods
{

	public static class IntExtension
	{
		public delegate Object ClosureWithNoExtraArgs ();
		public delegate void ActionClosureWithNoExtraArgs ();

		public static int timesRepeat (this int x, ClosureWithNoExtraArgs method)
		{
			for (int i = x; i > 0; i--) {
				method.DynamicInvoke ();
			}
			return x;
		}

		public static int timesRepeat (this int x, ActionClosureWithNoExtraArgs method)
		{
			for (int i = x; i > 0; i--) {
				method.DynamicInvoke ();
			}
			return x;
		}
		
	}
	
}

