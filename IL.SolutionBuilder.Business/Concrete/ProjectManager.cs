using System.Collections.Generic;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Business.Concrete
{

    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;
        private readonly IFileCreateService _fileCreateService;

        public ProjectManager(IProjectDal projectDal, IFileCreateService fileCreateService)
        {
            _projectDal = projectDal;
            _fileCreateService = fileCreateService;
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetList();
        }

        public void Add(Project project)
        {
            _projectDal.Add(project);
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }

        public void Delete(int projectId)
        {
            _projectDal.Delete(new Project() { Id = projectId });
        }

        public Project GetById(int projectId)
        {
            return _projectDal.Get(p => p.Id == projectId);
        }

        public List<Project> GetListByUnitId(int unitId)
        {
            return _projectDal.GetList(p => p.Unit.Id == unitId);
        }

        public List<Project> GetListBySolutionId(int solutionId)
        {
            return _projectDal.GetListBySolution(solutionId);
        }


        public void CreateFile(int id)
        {
            var project = GetById(id);
            try
            {
                _fileCreateService.CreateProject(project.Id);
                project.IsFileCreated = true;
            }
            catch
            {
                project.IsFileCreated = false;
            }

            _projectDal.Update(project);
        }
    }
}
