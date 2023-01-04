using System.Linq.Expressions;
using AgileObjects.AgileMapper;
using api_base.Data.Dtos;
using api_base.Models;
using api_base.Repositories;

namespace api_base.Services
{
    public abstract class Service<E, D, I, U> : IService<E, D, I, U>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    {
        private readonly IRepository<E> repository;

        public Service(IRepository<E> repository)
        {
            this.repository = repository;
        }

        public virtual void Delete(D dto)
        {
            var entity = Mapper.Map(dto).ToANew<E>();
            repository.Delete(entity);
        }

        public virtual void Delete(IEnumerable<D> dtos)
        {
            var entities = Mapper.Map(dtos).ToANew<IEnumerable<E>>();
            repository.Delete(entities);
        }

        public virtual async Task<D?> ReadAsync(int id, bool track = false, params Expression<Func<E, object>>[] customIncludes)
        {
            var entity = await repository.GetAsync(id, track, customIncludes);
            return Mapper.Map(entity).ToANew<D>();
        }

        public virtual async Task<D[]> ReadAsync(bool track = false, params Expression<Func<E, object>>[] customIncludes)
        {
            var entities = await repository.GetAsync(track, customIncludes);
            return Mapper.Map(entities).ToANew<D[]>();
        }

        public virtual async Task CreateAsync(I insertDto)
        {
            var entity = Mapper.Map(insertDto).ToANew<E>();
            await repository.InsertAsync(entity);
        }

        public virtual async Task CreateAsync(IEnumerable<I> insertDtos)
        {
            var entities = Mapper.Map(insertDtos).ToANew<IEnumerable<E>>();
            await repository.InsertAsync(entities);
        }

        public virtual async Task UpdateAsync(U updateDto)
        {
            var record = await repository.GetAsync(updateDto.Id);
            if (record == default)
                return;

            Mapper.Map(updateDto).Over(record);
            repository.Update(record);
        }

        public virtual void Update(IEnumerable<U> updateDtos)
        {
            var entities = Mapper.Map(updateDtos).ToANew<IEnumerable<E>>();
            repository.Update(entities);
        }

        public virtual async Task SaveChangesAsync()
        {
            await repository.SaveChangesAsync();
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            return await repository.ExistsAsync(id);
        }
    }
}