﻿using System;
using System.Windows;
using System.Windows.Input;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.EditModels;
using GalaSoft.MvvmLight.CommandWpf;

namespace BakeshoppeInventorySystem.Models
{
    public class NetworkModel : ModelBase<Network>
    {
        private IRepository _repository;
        private NetworkEditModel _editModel;

        public NetworkModel(Network model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }

        // For Methods
        // Example of Methods 
        // Mga ana na format kay Methods

        // For Properties
        // Example of properties.
        // SamplePropert{ get; set;}

        // For Commands
        // Example for Commands
        // public ICommand blabla

        // For Conditions
        // Example for Condition
        // From the Command: public ICommand AddCOmmand => new RelayCommand(ProcedureMethod, ConditionMethod)

        //The same for the Modules
        #region Methods



        #endregion

        #region Properties

        public NetworkEditModel EditModel
        {
            get { return _editModel; }
            set
            {
                _editModel = value;
                RaisePropertyChanged(nameof(EditModel));
            }
        }

        #endregion

        #region Commands

        public ICommand SaveEditCommand => new RelayCommand(SaveEditProc, SaveEditCondition);

        #endregion

        #region Proc

        private void SaveEditProc()
        {
            if (EditModel == null) return;
            if (!EditModel.HasChanges) return;

            try
            {
                EditModel.ModelCopy.Name = EditModel.ModelCopy.Name.ToUpper();
                _repository.Networks.Update(EditModel.ModelCopy);
                Model = EditModel.ModelCopy;
                MessageBox.Show("You have successfully updated the information.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to save the information." + e);
            }
        }

        #endregion

        #region Conditions

        private bool SaveEditCondition()
        {
            return (EditModel != null) && EditModel.HasChanges & !EditModel.HasErrors;
        }

        #endregion
    }
}
