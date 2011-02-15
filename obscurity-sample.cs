using System;
using System.Collections.Generic;
using System.Linq;
using s = System.String;
using c = System.Char;

static class Crypto {
	static void Main(s[] args) {
		Func<s, c[]> explode = s => s.ToCharArray();
		Func<c[], s> implode = chrs => new string(chrs);

		Func<c, c> shift = chr => (c)(chr + 1);
		Func<c[], c[]> scramble =
			chrs => chrs.Reverse().Select(chr => shift(chr)).ToArray();

  		c[] input = explode(args[0]);
  		c[] output = scramble(input);
  		Console.WriteLine(implode(output));
	}
}