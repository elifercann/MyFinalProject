﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{ 
    //Core katmanı evrensel bir katman bütün .Net projelerimde kullanabilirim anlamına geleyor.
    //***Core katmanı diğer katmanları referans almaz alırsa evrensel olmaz****

    //generic constraint
    //class : referans tip demek
    //IEntity: IEntity olabilir veya IEntity implemente eden bir class olabilir
    //new(): newlenebilen nesne alabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
