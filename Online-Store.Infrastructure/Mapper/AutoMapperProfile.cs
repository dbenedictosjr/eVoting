using Online_Store.Domain.Entities;
using Online_Store.Infrastructure.Models;
using AutoMapper;

namespace Online_Store.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category1Entity, Category1Model>()
                .ForMember(d => d.ID, map => map.MapFrom(s => s.Cat1ID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Cat1Code))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Cat1Desc))
                .ForMember(d => d.Image, map => map.MapFrom(s => s.Cat1Img))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<Category2Entity, Category2Model>()
                .ForMember(d => d.ID, map => map.MapFrom(s => s.Cat2ID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Cat2Code))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Cat2Desc))
                .ForMember(d => d.Image, map => map.MapFrom(s => s.Cat2Img))
                .ForMember(d => d.Cat1ID, map => map.MapFrom(s => s.Cat1ID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<Category3Entity, Category3Model>()
                .ForMember(d => d.ID, map => map.MapFrom(s => s.Cat3ID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.Cat3Code))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.Cat3Desc))
                .ForMember(d => d.Image, map => map.MapFrom(s => s.Cat3Img))
                .ForMember(d => d.Cat2ID, map => map.MapFrom(s => s.Cat2ID))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<UOMEntity, UOMModel>()
                .ForMember(d => d.ID, map => map.MapFrom(s => s.UOMID))
                .ForMember(d => d.Code, map => map.MapFrom(s => s.UOMCode))
                .ForMember(d => d.Description, map => map.MapFrom(s => s.UOMDesc))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();

            CreateMap<ProductEntity, ProductModel>()
                .ForMember(d => d.Product_ID, map => map.MapFrom(s => s.ProdID))
                .ForMember(d => d.Product_Code, map => map.MapFrom(s => s.ProdCode))
                .ForMember(d => d.Short_Description, map => map.MapFrom(s => s.ShortDesc))
                .ForMember(d => d.Long_Description, map => map.MapFrom(s => s.LongDesc))
                .ForMember(d => d.Category_ID, map => map.MapFrom(s => s.Cat3ID))
                .ForMember(d => d.UOM_ID, map => map.MapFrom(s => s.UOMID))
                .ForMember(d => d.Unit_Qty, map => map.MapFrom(s => s.UnitQty))
                .ForMember(d => d.Minimum_tock, map => map.MapFrom(s => s.Mintock))
                .ForMember(d => d.Maximum_Stock, map => map.MapFrom(s => s.MaxStock))
                .ForMember(d => d.Product_Cost, map => map.MapFrom(s => s.Cost))
                .ForMember(d => d.Markup_Amount, map => map.MapFrom(s => s.MarkupAmount))
                .ForMember(d => d.Markup_Percentage, map => map.MapFrom(s => s.MarkupPercent))
                .ForMember(d => d.Product_Price, map => map.MapFrom(s => s.Price))
                .ForMember(d => d.Vatable, map => map.MapFrom(s => s.Vatable))
                .ForMember(d => d.Barcode, map => map.MapFrom(s => s.Barcode))
                .ForMember(d => d.Stock, map => map.MapFrom(s => s.Stock))
                .ForMember(d => d.Active, map => map.MapFrom(s => s.Active))
                .ForMember(d => d.RowVersion, map => map.MapFrom(s => s.RowVersion))
                .ReverseMap();
        }
    }
}