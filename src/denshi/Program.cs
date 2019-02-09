// This file is a part of Denshi.
// Copyright (C) 2019 Matthew Blount

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Affero General Public License for more details.

// You should have received a copy of the GNU Affero General Public
// License along with this program.  If not, see
// <https://www.gnu.org/licenses/.

using System;
using ABC.Read;
using ABC.Norm;

namespace Denshi {
  class Program {
    static void Main(string[] args) {
      var norm = new CDSNorm();
      Console.Write("user@denshi\n> ");
      var line = Console.ReadLine();
      while (line != null) {
        var src = Term.FromString(line);
        var res = norm.Norm(src, 256);
        Console.WriteLine(res);
        Console.Write("user@denshi\n> ");
        line = Console.ReadLine();
      }
    }
  }
}