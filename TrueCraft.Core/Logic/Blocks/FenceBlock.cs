using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class FenceBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x55;
        
        public override byte ID { get { return 0x55; } }

        public override double Hardness { get { return 2; } }

        public override string DisplayName { get { return "Fence"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(4, 0);
        }
    }
}