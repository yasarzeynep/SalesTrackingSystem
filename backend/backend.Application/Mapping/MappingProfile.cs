using AutoMapper;
using backend.Application.Features.Customers.CreateCusromer;
using backend.Application.Features.Customers.UpdateCustomer;
using backend.Application.Features.Depots.CreateDepot;
using backend.Application.Features.Depots.UpdateDepot;
using backend.Application.Features.Invoices.CreateInvoice;
using backend.Application.Features.Invoices.UpdateInvoice;
using backend.Application.Features.Orders.CreateOrder;
using backend.Application.Features.Orders.UpdateOrder;
using backend.Application.Features.Productions.CreateProduction;
using backend.Application.Features.Products.CreateProduct;
using backend.Application.Features.Products.UpdateProduct;
using backend.Application.Features.RecipeDetails.CreateRecipeDetail;
using backend.Application.Features.RecipeDetails.UpdateRecipeDetail;
using backend.Domain.Entities;
using backend.Domain.Enums;

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace backend.Application.Mapping;

    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<UpdateCustomerCommand, Customer>();


            CreateMap<CreateDepotCommand, Depot>();
            CreateMap<UpdateDepotCommand, Depot>();


            CreateMap<CreateProductCommand, Product>()
            .ForMember(member => member.Type,
                options =>
                options.MapFrom(p => ProductTypeEnum.FromValue(p.TypeValue)));

            CreateMap<UpdateProductCommand, Product>()
               .ForMember(member => member.Type,
                   options =>
                   options.MapFrom(p => ProductTypeEnum.FromValue(p.TypeValue)));


            CreateMap<CreateRecipeDetailCommand, RecipeDetail>();
            CreateMap<UpdateRecipeDetailCommand, RecipeDetail>();


            CreateMap<CreateOrderCommand, Order>()
           .ForMember(member => member.Details,
           options =>
           options.MapFrom(p => p.Details.Select(s => new OrderDetail
           {
               Price = s.Price,
               ProductId = s.ProductId,
               Quantity = s.Quantity
           }).ToList()));

            CreateMap<UpdateOrderCommand, Order>()
                  .ForMember(member =>
            member.Details,
            options => options.Ignore());


        CreateMap<CreateInvoiceCommand, Invoice>()
            .ForMember(member => member.Type, options =>
            options.MapFrom(p => InvoiceTypeEnum.FromValue(p.TypeValue)))
            .ForMember(member => member.Details,
            options =>
            options.MapFrom(p => p.Details.Select(s => new InvoiceDetail
            {
                Price = s.Price,
                ProductId = s.ProductId,
                DepotId = s.DepotId,
                Quantity = s.Quantity
            }).ToList()));

        CreateMap<UpdateInvoiceCommand, Invoice>()
            .ForMember(member =>
            member.Details,
            options => options.Ignore());

        CreateMap<CreateProductionCommand, Production>();
    }
    }

