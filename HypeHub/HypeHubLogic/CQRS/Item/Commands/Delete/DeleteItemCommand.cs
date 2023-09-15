using HypeHubLogic.DTOs.Item;
using HypeHubLogic.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypeHubLogic.CQRS.Item.Commands.Delete
{
    public class DeleteItemCommand : IRequest<BaseResponse<ItemReadDTO>>
    {
        public Guid ItemId { get; set; }

        public DeleteItemCommand(Guid itemId)
        {
            ItemId = itemId;
        }
    }
}
