using System;

namespace Library
{
 
    public interface IEdge<TVertex> : IComparable<IEdge<TVertex>> where TVertex : IComparable<TVertex>
    {
        TVertex Source { get; set; }
        TVertex Destination { get; set; }

        bool IsWeighted { get; }
  
      
        Int64 Weight { get; set; }
    }
}

