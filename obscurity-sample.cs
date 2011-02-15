using System;
using System.Collections.Generic;
using System.Linq;
using s = System.String;
using c = System.Char;

static class Crypto {
	static void Main(s[] args) {
		// helper functions
		Func<s, c[]> explode = s => s.ToCharArray();
		Func<c[], s> implode = chrs => new string(chrs);
		Action<s> print = s => Console.WriteLine(s);

		// encryption
		Func<c, c> shift = chr => (c)(chr + 1);
		Func<c[], c[]> scramble =
			chrs => chrs.Reverse().Select(chr => shift(chr)).ToArray();

		// read input, encrypt, write output
  		c[] input = explode(args[0]);
  		c[] output = scramble(input);
  		print(implode(output));
	}
}