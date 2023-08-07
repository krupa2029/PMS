using PMS.ViewModel;
using PMS.Data;
using PMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    partial class ProjectListViewModel : ViewModelBase
    {
        private readonly IProjectListDataProvider _projectListDataProvider;

        public ObservableCollection<ProjectListItemViewModel> ProjectList { get; } = new();


        public ProjectListViewModel(IProjectListDataProvider projectListDataProvider)
        {
            _projectListDataProvider = projectListDataProvider;           
        }

        public async Task LoadProjectListAsync()
        {
            if (ProjectList.Any())
            {
                return;
            }

            var projects = await _projectListDataProvider.GetProjectListAsync();
            if (projects is not null)
            {
                foreach (var item in projects)
                {
                    ProjectList.Add(new ProjectListItemViewModel(item));
                }
            }
        }
    }
}
