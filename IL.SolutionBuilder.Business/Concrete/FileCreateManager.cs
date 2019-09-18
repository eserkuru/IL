using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.Entities.Concrete;
using IL.SolutionBuilder.Entities.Enums;

namespace IL.SolutionBuilder.Business.Concrete
{
    public class FileCreateManager : IFileCreateService
    {
        private readonly ICommandService _commandService;
        private readonly ISolutionDal _solutionDal;
        private readonly IProjectDal _projectDal;
        public FileCreateManager(ICommandService commandService, ISolutionDal solutionDal, IProjectDal projectDal)
        {
            _commandService = commandService;
            _solutionDal = solutionDal;
            _projectDal = projectDal;
        }

        public void CreateSolution(int id)
        {
            var solution = _solutionDal.Get(s => s.Id == id);
            _commandService.Run(new List<string>()
            {
                "mkdir " + solution.CompanyName,
                @"cd .\" + solution.CompanyName,
                "dotnet new sln -n " + solution.CompanyName
            });
        }

        public void CreateProject(int id)
        {
            var solution = _solutionDal.GetWithProjectId(id);
            var project = _projectDal.Get(p => p.Id == id);
            _commandService.Run(new List<string>()
            {
                @"cd .\" + solution.CompanyName,
                @"dotnet new " + project.ProjectType + " -n " + project.DirectoryName,
                @"dotnet sln add .\" + project.DirectoryName
            });
            switch (project.ProjectType)
            {
                case ProjectType.classlib:
                    _commandService.Run(new List<string>()
                    {
                        @"cd .\" + solution.CompanyName + @"\" + project.DirectoryName,
                        @"del class1.cs"
                    });
                    break;

                case ProjectType.mvc:
                    _commandService.Run(new List<string>()
                    {
                        @"cd .\" + solution.CompanyName + @"\" + project.DirectoryName,
                        @"cd .\Controllers",
                        @"del HomeController.cs",
                        @"cd..",
                        @"cd .\Views",
                        @"del /F /Q .\Home",
                        @"rmdir .\Home",
                        @"cd..",
                        @"del /F /Q .\wwwroot"
                    });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
