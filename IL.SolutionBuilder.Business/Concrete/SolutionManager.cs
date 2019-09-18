using System.Collections.Generic;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Business.Concrete
{

    public class SolutionManager : ISolutionService
    {
        private readonly ISolutionDal _solutionDal;
        private readonly IUnitDal _unitDal;
        private readonly IProjectDal _projectDal;
        private readonly IFileCreateService _fileCreateService;

        public SolutionManager(ISolutionDal solutionDal, IFileCreateService fileCreateService, IProjectDal projectDal, IUnitDal unitDal)
        {
            _solutionDal = solutionDal;
            _fileCreateService = fileCreateService;
            _projectDal = projectDal;
            _unitDal = unitDal;
        }

        public List<Solution> GetAll()
        {
            return _solutionDal.GetList();
        }

        public void Add(Solution solution)
        {
            _solutionDal.Add(solution);
        }

        public void Update(Solution solution)
        {
            _solutionDal.Update(solution);


        }

        public void Delete(int solutionId)
        {
            _solutionDal.Delete(new Solution { Id = solutionId });
        }

        public Solution GetById(int solutionId)
        {
            return _solutionDal.Get(s => s.Id == solutionId);
        }

        public Solution GetByUnitId(int unitId)
        {
            return _solutionDal.GetWithUnitId(unitId);
        }

        public Solution GetByProjectId(int projectId)
        {
            return _solutionDal.GetWithProjectId(projectId);
        }

        public void AddWithDefaultProject(Solution solution)
        {
            _solutionDal.Add(solution);

            var defaultUnits = new List<Unit>()
            {
                new Unit()
                {
                    Name = "Base",
                    SourceType = SourceType.System,
                    Description = "Represents the basic layer of the project. The whole architecture is shaped on this project.",
                    Solution = solution
                },
                new Unit()
                {
                    Name = "Libraries",
                    SourceType = SourceType.System,
                    Description = "Stores libraries built on the basic architecture of the project. Entities, data access classes, business and service operations are managed here.",
                    Solution = solution
                },
                new Unit()
                {
                    Name = "Presentations",
                    SourceType = SourceType.System,
                    Description = "Represents the presentation layer of the project. It includes user interfaces, web services and desktop applications.",
                    Solution = solution
                },
                new Unit()
                {
                    Name = "Tests",
                    SourceType = SourceType.System,
                    Description = "It is the layer where the unit tests of the project are collected. Test operations are organized here.",
                    Solution = solution
                }

            };
            foreach (var unit in defaultUnits)
            {
                _unitDal.Add(unit);
            }

            var defaultProjects = new List<Project>()
            {
                new Project
                {
                    Name = "Core",
                    ProjectType = ProjectType.classlib,
                    SourceType = SourceType.System,
                    DirectoryName = solution.CompanyName + ".Core",
                    Unit = _unitDal.Get(u=> u.Solution == solution && u.Name == "Base"  )
                },
                new Project
                {
                    Name = "Business",
                    ProjectType = ProjectType.classlib,
                    SourceType = SourceType.System,
                    DirectoryName = solution.CompanyName +"."+ solution.ProjectName + ".Business",
                    Unit = _unitDal.Get(u=> u.Solution == solution && u.Name == "Libraries")
                },
                new Project
                {
                    Name = "DataAccess",
                    ProjectType = ProjectType.classlib,
                    SourceType = SourceType.System,
                    DirectoryName = solution.CompanyName +"."+ solution.ProjectName + ".DataAccess",
                    Unit = _unitDal.Get(u=> u.Solution == solution && u.Name == "Libraries")
                },
                new Project
                {
                    Name = "Entities",
                    ProjectType = ProjectType.classlib,
                    SourceType = SourceType.System,
                    DirectoryName = solution.CompanyName +"."+ solution.ProjectName + ".Entities",
                    Unit = _unitDal.Get(u=> u.Solution == solution && u.Name == "Libraries")
                },
                new Project
                {
                    Name = "Web.CoreMVC",
                    ProjectType = ProjectType.mvc,
                    SourceType = SourceType.System,
                    DirectoryName = solution.CompanyName +"."+ solution.ProjectName + ".Web.CoreMVC",
                    Unit = _unitDal.Get(u=> u.Solution == solution && u.Name == "Presentations")
                }
            };
            foreach (var project in defaultProjects)
            {
                _projectDal?.Add(project);
            }
        }

        public void CreateFile(int id)
        {
            var solution = GetById(id);
            try
            {
                _fileCreateService.CreateSolution(id);
                solution.IsFileCreated = true;
            }
            catch
            {
                solution.IsFileCreated = false;
            }

            _solutionDal.Update(solution);
        }
    }
}
