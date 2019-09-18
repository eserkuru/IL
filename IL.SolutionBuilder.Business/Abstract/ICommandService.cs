using System;
using System.Collections.Generic;
using System.Text;

namespace IL.SolutionBuilder.Business.Abstract
{
    public interface ICommandService
    {
        void Run(List<string> commands);
    }
}
