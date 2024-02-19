using MediatR;
using GenericMonolithWebApplication.Application.Contracts.Persistence;
using AutoMapper;
using GenericMonolithWebApplication.Domain.Entities;
using GenericMonolithWebApplication.Application.ViewModels;
using Microsoft.Extensions.Logging;

namespace GenericMonolithWebApplication.Application.Features.Parts.Queries.GetPartsList
{
    public class GetPartsListQueryHandler : IRequestHandler<GetPartsListQuery, IList<PartsViewModel>>
    {

        private readonly IAsyncRepository<Part> _partRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public GetPartsListQueryHandler(IMapper mapper, IAsyncRepository<Part> partRepository, ILogger<GetPartsListQueryHandler> logger)
        {
            _mapper = mapper;
            _partRepository = partRepository;
            _logger = logger;
        }

        public async Task<IList<PartsViewModel>> Handle(GetPartsListQuery request, CancellationToken cancellationToken)
        {
            var allParts = (await _partRepository.ListAllAsync()).OrderBy(x => x.PartNum);
            return _mapper.Map<List<PartsViewModel>>(allParts);
        }

    }
}