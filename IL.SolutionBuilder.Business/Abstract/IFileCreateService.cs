using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Business.Abstract
{
    public interface IFileCreateService
    {
        void CreateSolution(int id);
        void CreateProject(int id);
    }
}
