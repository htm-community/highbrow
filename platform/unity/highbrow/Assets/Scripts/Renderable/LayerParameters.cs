// Numenta Platform for Intelligent Computing (NuPIC)
// Copyright (C)  2017, Numenta, Inc.  Unless you have an agreement
// with Numenta, Inc., for a separate license for this software code, the
// following terms and conditions apply:
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero Public License version 3 as
// published by the Free Software Foundation.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Affero Public License for more details.
// You should have received a copy of the GNU Affero Public License
// along with this program.  If not, see http://www.gnu.org/licenses.
// http://numenta.org/licenses/
using System;
using System.Collections;
using UnityEngine;

namespace Numenta.Renderable
{
    [Serializable]
    public struct LayerParameters
    {
        [Tooltip("Layer Name")]
        public string name;
        [Tooltip("Number of minicolumns per dimension")]
        public Vector2 dimensions;
        [Tooltip("Minicolumn Parameters")]
        public MiniColumnParameters minicolumnParameters;
        [Tooltip("Spacing between layers")]
        public float spacing;

        public static readonly LayerParameters DEFAULT = new LayerParameters
        {
            dimensions = Vector2.one,
            minicolumnParameters = MiniColumnParameters.DEFAULT,
            spacing = 0
        };
    }
}
