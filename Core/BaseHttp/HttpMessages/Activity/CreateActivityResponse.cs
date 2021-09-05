using System;
using Core.BaseHttp;
using Core.Dtos;

public class CreateActivityResponse : ResponseMessage
{
    public CreateActivityResponse(Guid correlationId) : base(correlationId) { }
    public ActivityDto ActivityDto = new ActivityDto();
}