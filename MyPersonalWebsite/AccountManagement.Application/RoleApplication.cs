﻿using System.Collections.Generic;
using _0_Framework.Application;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Domain.Role;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {
        
        private readonly IRoleRepository _roleRepository;

        public RoleApplication(IRoleRepository roleRepository)
        {
            
            _roleRepository = roleRepository;
           
        }

        public OperationResult CreateRole(CreateRole command)
        {
            var operation = new OperationResult();

            if (_roleRepository.Exist(x => x.Name == command.Name))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }

            var role = new Role(command.Name);
            _roleRepository.Create(role);
            _roleRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult EditRole(EditRole command)
        {
            var operation = new OperationResult();
            var role = _roleRepository.Get(command.Id);

            if (_roleRepository == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }
            if (_roleRepository.Exist(x => x.Name == command.Name && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }

            

            role.Edit(command.Name);
            _roleRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditRole GetDetails(long id)
        {
            return _roleRepository.GetDetails(id);
        }

        public List<RoleViewModel> List()
        {
            return _roleRepository.List();
        }
    }
}
