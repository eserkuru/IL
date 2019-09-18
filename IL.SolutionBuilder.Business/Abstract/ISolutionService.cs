using System;
using System.Collections.Generic;
using System.Text;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Business.Abstract
{
    /// <summary>
    /// Represents solution service.
    /// </summary>
    public interface ISolutionService
    {
        /// <summary>
        /// Returns the list of solutions from the database.
        /// </summary>
        List<Solution> GetAll();

        /// <summary>
        /// Adds the given solution object to the database.
        /// </summary>
        void Add(Solution solution);

        void AddWithDefaultProject(Solution solution);

        /// <summary>
        /// Updates the given country object in the database.
        /// </summary>
        void Update(Solution solution);

        /// <summary>
        /// Deletes the database record in the given solution id.
        /// </summary>
        void Delete(int solutionId);

        /// <summary>
        /// Returns the database record in the given solution id.
        /// </summary>
        Solution GetById(int solutionId);

        Solution GetByUnitId(int unitId);
        Solution GetByProjectId(int projectId);
        void CreateFile(int id);

    }
}
