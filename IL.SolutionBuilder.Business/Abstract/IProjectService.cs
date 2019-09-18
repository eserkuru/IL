using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Business.Abstract
{
    /// <summary>
    /// Represents project service.
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// Returns the list of projects from the database.
        /// </summary>
        List<Project> GetAll();

        /// <summary>
        /// Adds the given project object to the database.
        /// </summary>
        void Add(Project project);

        /// <summary>
        /// Updates the given project object in the database.
        /// </summary>
        void Update(Project project);

        /// <summary>
        /// Deletes the database record in the given project id.
        /// </summary>
        void Delete(int projectId);

        /// <summary>
        /// Returns the database record in the given project id.
        /// </summary>
        Project GetById(int projectId);

        List<Project> GetListByUnitId(int unitId);

        List<Project> GetListBySolutionId(int solutionId);

        void CreateFile(int id);
    }
}
