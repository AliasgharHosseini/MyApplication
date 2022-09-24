//namespace Infrastructure
//{
//	public static class GenericUtility<T> : object
//	{
//		static GenericUtility()
//		{
//		}

//		public static string FixText(string? text)
//		{
//			if (string.IsNullOrEmpty(value: text))
//			{jbhjkhjb
//				return string.Empty;
//			}

//			text =
//				text.Trim();

//			if (text.Length == 0)
//			{
//				return string.Empty;
//			}

//			while (text.Contains(value: "  "))
//			{
//				text =
//					text.Replace
//					(oldValue: "  ", newValue: " ");
//			}

//			return text;
//		}

//		// **************************************************
//		// Solution (4)
//		// **************************************************
//		// **************************************************
//		// **************************************************
//		private static MyApplication.LoginForm? _loginForm;
//		// **************************************************

//		// **************************************************
//		/// <summary>
//		/// Lazy Loading = Lazy Initialization
//		/// </summary>
//		public static MyApplication.LoginForm LoginForm
//		{
//			get
//			{
//				if (_loginForm == null || _loginForm.IsDisposed)
//				{
//					_loginForm =
//						new MyApplication.LoginForm();
//				}

//				return _loginForm;
//			}
//		}
//		// **************************************************

//		// **************************************************
//		public static void DisposeLoginForm()
//		{
//			if (_loginForm != null)
//			{
//				if (_loginForm.IsDisposed == false)
//				{
//					_loginForm.Dispose();
//				}

//				_loginForm = null;
//			}
//		}
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		// **************************************************
//		// **************************************************
//		private static MyApplication.RegisterForm? _registerForm;
//		// **************************************************

//		// **************************************************
//		/// <summary>
//		/// Lazy Loading = Lazy Initialization
//		/// </summary>
//		public static MyApplication.RegisterForm RegisterForm
//		{
//			get
//			{
//				if (_registerForm == null || _registerForm.IsDisposed)
//				{
//					_registerForm =
//						new MyApplication.RegisterForm();
//				}

//				return _registerForm;
//			}
//		}
//		// **************************************************

//		// **************************************************
//		public static void DisposeRegisterForm()
//		{
//			if (_registerForm != null)
//			{
//				if (_registerForm.IsDisposed == false)
//				{
//					_registerForm.Dispose();
//				}

//				_registerForm = null;
//			}
//		}
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		// **************************************************
//		// **************************************************
//		private static MyApplication.MainForm? _mainForm;
//		// **************************************************

//		// **************************************************
//		/// <summary>
//		/// Lazy Loading = Lazy Initialization
//		/// </summary>
//		public static MyApplication.MainForm MainForm
//		{
//			get
//			{
//				if (_mainForm == null || _mainForm.IsDisposed)
//				{
//					_mainForm =
//						new MyApplication.MainForm();
//				}

//				return _mainForm;
//			}
//		}
//		// **************************************************

//		// **************************************************
//		public static void DisposeMainForm()
//		{
//			if (_mainForm != null)
//			{
//				if (_mainForm.IsDisposed == false)
//				{
//					_mainForm.Dispose();
//				}

//				_mainForm = null;
//			}
//		}
//		// **************************************************
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		public static Domain.User? AuthenticatedUser;
//		// **************************************************
//	}
//}
