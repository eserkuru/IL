using System.Collections.Generic;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.ComplexTypes;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Business.Concrete
{
    public class UnitManager : IUnitService
    {
        private readonly IUnitDal _unitDal;

        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        public List<Unit> GetAll()
        {
            return _unitDal.GetList();
        }

        public void Add(Unit unit)
        {
            _unitDal.Add(unit);
        }

        public void Update(Unit unit)
        {
            _unitDal.Update(unit);
        }

        public void Delete(int unitId)
        {
            _unitDal.Delete(new Unit { Id = unitId });
        }

        public Unit GetById(int unitId)
        {
            return _unitDal.Get(u => u.Id == unitId);
        }

        public List<Unit> GetListBySolution(int solutionId)
        {
            return _unitDal.GetList(u => u.Solution.Id == solutionId);
        }

        public List<UnitProjects> GetListUnitProjectsBySolutionId(int solutionId)
        {
            return _unitDal.GetUnitProjects(up => up.Solution.Id == solutionId);
        }
    }
}
