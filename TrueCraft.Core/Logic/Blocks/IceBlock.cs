using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class IceBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x4F;
        
        public override byte ID { get { return 0x4F; } }

        public override double Hardness { get { return 0.5; } }

        public override string DisplayName { get { return "Ice"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(3, 4);
        }
    }
}