using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Sparrow.Core.Domain.Entities;

namespace Sparrow.Core.Domain.Repositories
{
    public interface ISupportsExplicitLoading<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
        /// <summary>
        /// ȷ��ʵ�弯���Ƿ��Ѿ�����
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="collectionExpression"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task EnsureCollectionLoadedAsync<TProperty>(
            TEntity entity,
            Expression<Func<TEntity, IEnumerable<TProperty>>> collectionExpression,
            CancellationToken cancellationToken)
            where TProperty : class;

        /// <summary>
        /// ȷ�������Ƿ��Ѿ�����
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="propertyExpression"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task EnsurePropertyLoadedAsync<TProperty>(
            TEntity entity,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            CancellationToken cancellationToken)
            where TProperty : class;
    }
}