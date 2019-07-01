﻿using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Interfaces;
using MediatR;

namespace FilterLists.Agent.Features.Lists
{
    public static class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IMediator _mediator;
            private readonly IListInfoRepository _repo;

            public Handler(IMediator mediator, IListInfoRepository listInfoRepository)
            {
                _mediator = mediator;
                _repo = listInfoRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var lists = await _repo.GetAllAsync();
                await _mediator.Send(new DownloadLists.Command(lists), cancellationToken);
                await _mediator.Send(new CommitLists.Command(), cancellationToken);
            }
        }
    }
}