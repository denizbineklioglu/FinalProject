using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//CORE KATMANI DİĞER KATMANLARDAN REFERANS ALMAZ! ALIRSA O KATMANA BAĞIMLIDIR DEMEKTİR.
namespace Core.DataAccess
{
    //Generic Constraint
    // class : referans tip olabilir
    //IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı 
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter); // filtre vermediyse tüm datayı istiyor demektir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
