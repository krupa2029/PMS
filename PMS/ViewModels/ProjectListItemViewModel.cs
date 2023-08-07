using PMS.Models;
using PMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.ViewModels
{
    class ProjectListItemViewModel : ViewModelBase
    {
        private readonly ProjectListModel _model;
        public ProjectListItemViewModel(ProjectListModel model)
        {
            _model = model;

        }

        public int Id => _model.Id;

        public string? Title
        {
            get => _model.Title;
            set
            {
                if (_model.Title != value)
                {
                    _model.Title = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
