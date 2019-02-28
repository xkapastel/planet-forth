// This file is a part of Magic Word.
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

namespace MagicWord.Lang

open MathNet.Numerics
open MathNet.Numerics.LinearAlgebra

module Grammar =
  type private Vec = Vector<float>

  type private IFunction =
    abstract member Apply: Vec -> Vec
    abstract member Alter: unit -> unit
    abstract member Clear: unit -> unit

  type private Id() =
    interface IFunction with
      member __.Apply src = src
      member __.Alter ()  = ()
      member __.Clear ()  = ()
