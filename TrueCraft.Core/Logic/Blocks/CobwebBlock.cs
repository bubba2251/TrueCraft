using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class CobwebBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x1E;
        
        public override byte ID { get { return 0x1E; } }

        public override double Hardness { get { return 4; } }

        public override string DisplayName { get { return "Cobweb"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(11, 0);
        }
    }
}