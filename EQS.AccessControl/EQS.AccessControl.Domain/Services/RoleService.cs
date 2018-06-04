using System;
using System.Collections.Generic;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.ObjectValue;

namespace EQS.AccessControl.Domain.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public IEnumerable<Role> GetByExpression(SearchObject predicate)
        {
            return _roleRepository.GetByExpression(predicate);
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public Role Create(Role entity)
        {
            if (entity.IsValidForCreate())
                return _roleRepository.Create(entity);
            return entity;
        }

        public Role Update(Role entity)
        {
            if (entity.IsValidForCreate())
                return _roleRepository.Update(entity);
            return entity;
        }

        public Role Delete(int id)
        {
            var role = new Role { Id = id };
            if (role.IsValidForDelete(_roleRepository))
                return _roleRepository.Delete(id);
            return role;
        }

        public void Dispose()
        {
            _roleRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public void CreateExpression()
        {

        }

    }
}
