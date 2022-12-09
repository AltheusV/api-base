using api_base.Data.Dtos.Models;
using api_base.Models;

namespace api_base.Services.Models
{
    public interface IModelService : IService<Model, ModelDto, ModelInsertDto, ModelUpdateDto> { }
}