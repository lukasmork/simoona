﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shrooms.Contracts.DataTransferObjects;
using Shrooms.Premium.DataTransferObjects.Models.Events;
using Shrooms.Premium.Domain.Services.Args;

namespace Shrooms.Premium.Domain.Services.Events.List
{
    public interface IEventListingService
    {
        Task<IEnumerable<EventListItemDto>> GetMyEventsAsync(MyEventsOptionsDto options, int page, int? officeId = null);
        Task<EventOptionsDto> GetEventOptionsAsync(Guid eventId, UserAndOrganizationDto userOrg);
        Task<IEnumerable<EventListItemDto>> GetEventsFilteredAsync(EventsListingFilterArgs args, UserAndOrganizationDto userOrganization);
    }
}
