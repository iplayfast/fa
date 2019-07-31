using System;

namespace FA
{
	class Program
	{
		static void Main(string[] args)
		{
			var nfa = CharFA<string>.Parse("hello|world!", "success!");
			var dfa = nfa.ToDfa();
			var opts = new CharFA<string>.DotGraphOptions();
			opts.DebugSourceNfa = nfa;
			opts.DebugString = "he";
			dfa.TrimDuplicates();
			dfa.RenderToFile(@"..\..\..\helloworld.jpg",opts);
			Console.WriteLine(dfa);

			var tok = dfa.Lex("helloworld".GetEnumerator(), "#ERROR");
			Console.WriteLine("{0}: {1}", tok.Key, new string(tok.Value));
		}
	}
}
