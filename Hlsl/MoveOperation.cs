﻿namespace HlslDecompiler.Hlsl
{
    public class MoveOperation : Operation
    {
        public MoveOperation(HlslTreeNode value)
        {
            AddChild(value);
        }

        public HlslTreeNode Value => Children[0];

        public override HlslTreeNode Reduce()
        {
            return Value.Reduce();
        }
    }
}
