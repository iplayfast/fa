using System;

namespace FA
{
	class Program
	{
		static void Main(string[] args)
		{
			var fa = CharFA<string>.Parse("hello|world!", "success!");
			fa.RenderToFile(@"..\..\..\helloworld.jpg");
			Console.WriteLine(fa);

			var tok = fa.Lex("helloworld".GetEnumerator(), "#ERROR");
			Console.WriteLine("{0}: {1}", tok.Key, new string(tok.Value));
		}
	}
}
