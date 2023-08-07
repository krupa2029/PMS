using PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Data
{
    public interface IProjectListDataProvider
    {
        Task<IEnumerable<ProjectListModel>?> GetProjectListAsync();
    }
    class ProjectListDataProvider : IProjectListDataProvider
    {
        public async Task<IEnumerable<ProjectListModel>?> GetProjectListAsync()
        {
            await Task.Delay(100);

            return new List<ProjectListModel>
            {
                new ProjectListModel{ Id=1, Title="OneTeam360"},
                new ProjectListModel{ Id=2, Title="United Way"},
                new ProjectListModel{ Id=3, Title="InnovateNow"},
                new ProjectListModel{ Id=4, Title="TechGurus"},
                new ProjectListModel{ Id=5, Title="VisionXpertise"}
            };
        }
    }

    
}
