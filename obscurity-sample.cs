//
// Sample for "Security by Obscurity"
//
// Authors:
//    Juraj Skripsky <js@hotfeet.ch>
//
// Copyright 2011 HotFeet GmbH (http://www.hotfeet.ch)
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

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