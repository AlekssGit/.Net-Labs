using System;

namespace Tasks
{
    public enum Side
    {
        Left,
        Right
    }

    public class NodeTree<T> where T : IComparable
    {
        public NodeTree(T data)
        {
            Data = data;
        }
        public T Data { get; set; }

        public NodeTree<T> LeftNode { get; set; }

        public NodeTree<T> RightNode { get; set; }

        public NodeTree<T> ParentNode { get; set; }

        public Side? NodeSide =>
            ParentNode == null ? (Side?)null : ParentNode.LeftNode == this ? Side.Left : Side.Right;

        public override string ToString() => Data.ToString();
    }
}