﻿using CarProject.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorsQuery:IRequest<List<GetAllBlogsWithAuthorsQueryResults>>
    {
    }
}
