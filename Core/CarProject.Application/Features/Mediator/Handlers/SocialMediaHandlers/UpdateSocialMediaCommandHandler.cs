﻿using CarProject.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarProject.Application.Interfaces;
using CarProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler:IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.SocialMediaID);
            values.SocialMediaID = request.SocialMediaID;
            values.Url = request.Url;
            values.Icon = request.Icon;
            await _repository.UpdateAsync(values);
        }
    }
}