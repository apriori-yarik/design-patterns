using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChain
{
    public class KillModifier : CreatureModifier
    {
        public KillModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {
        }
    }
}
