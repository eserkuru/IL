using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.ComplexTypes;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Business.Abstract
{
    public interface IUnitService
    {
        List<Unit> GetAll();

        void Add(Unit unit);

        void Update(Unit unit);

        void Delete(int unitId);

        Unit GetById(int unitId);

        List<Unit> GetListBySolution(int solutionId);

        List<UnitProjects> GetListUnitProjectsBySolutionId(int solutionId);
    }
}
