﻿using MediatR;
using Project.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Events
{
    class ProjectJoinedEvent : INotification
    {
        public ProjectContributor Contributor { get; set; }
    }
}
