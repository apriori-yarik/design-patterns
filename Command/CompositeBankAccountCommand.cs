using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
    {
        public bool Success { get; set; }

        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public virtual void Undo()
        {
            foreach (var cmd in
              ((IEnumerable<BankAccountCommand>)this).Reverse())
            {
                cmd.Undo();
            }
        }
    }
}
