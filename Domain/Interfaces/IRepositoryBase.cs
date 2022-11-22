﻿using System;

namespace Domain.Interfaces
{
    public interface IRepositoryBase { }

    public interface IRepositoryBase<T>
    {
        bool Update(T model);
        T GetById(int id, Guid tenantId);
        bool Delete(int id, Guid tenantId);
        T Insert(T model);
    }

    // TODO: Inserir listar com filtro 
    //public interface IRepositoryBase<T, TFilter> { }
}