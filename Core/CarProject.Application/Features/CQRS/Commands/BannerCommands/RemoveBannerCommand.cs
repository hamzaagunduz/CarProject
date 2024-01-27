﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Application.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public int Id;

        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}
