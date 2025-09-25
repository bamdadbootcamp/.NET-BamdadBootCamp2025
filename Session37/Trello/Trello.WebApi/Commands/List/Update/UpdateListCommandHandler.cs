﻿using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.List.Update
{
    public class UpdateListCommandHandler : IRequestHandler<UpdateListCommand>
    {
        #region [- Fields -]
        private readonly ApplicationDbContext _dbcontext;
        #endregion

        #region [- Ctor -]
        public UpdateListCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        } 
        #endregion

        #region [- Handle -]
        public async Task Handle(UpdateListCommand request, CancellationToken cancellationToken)
        {
            var list = await _dbcontext.FindAsync<Domain.Entities.List>(request.ListId);
            if (list != null)
            {
                list.Update(request.Title);
                await _dbcontext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("The operation can not be done!");
            }
        } 
        #endregion
    }
}
