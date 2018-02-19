﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ludoop.Backend
{
    /// <summary>
    /// Class representing a 2D integer-precise vector.
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// Constructor for Vector2D takes a map index and a tile index to specify position,
        /// {Default is 0,0}
        /// </summary>
        /// <param name="x">Tile Index</param>
        /// <param name="y">Map Index</param>
        public Vector2D(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        private int x, y;

        /// <summary>
        /// Get and set for map index 
        /// </summary>
        public int X
        {
            get { return x; }
            set { this.x = value; }
        }
        
        /// <summary>
        /// get and set for tile index
        /// </summary>
        public int Y
        {
            get { return y; }
            set { this.y = value; }
        }

        /// <summary>
        /// Clones the current object
        /// </summary>
        /// <returns>Returns a Vector2D identical to the original object</returns>
        public Vector2D Clone()
        {
            return new Vector2D(this.X, this.Y);
        }

        /// <summary>
        /// Method for checking if two vectors coordinates match.
        /// </summary>
        /// <param name="other">Vector to match with.</param>
        /// <returns>Returns if THIS vector's coordinates matches OTHER vector's coordinates.</returns>
        public bool Match(Vector2D other) {
            return this.X == other.X && this.Y == other.Y;
        }

    }
}
