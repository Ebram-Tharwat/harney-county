﻿using AutoMapper;
using HarneyCounty.Application.Core;
using HarneyCounty.Application.Core.Contracts.Paging;
using System.Collections.Generic;
//using X.PagedList;


namespace HarneyCounty.Web.Extensions
{
    //public static class PagedListExtensions
    //{
    //    public static IPagedList<TDestination> ToMappedPagedList<TSource, TDestination>(this IPagedList<TSource> list)
    //    {
    //        IEnumerable<TDestination> sourceList = Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(list);
    //        IPagedList<TDestination> pagedResult = new StaticPagedList<TDestination>(sourceList, list.GetMetaData());
    //        return pagedResult;
    //    }

    //    public static IPagedList<TDestination> ToMappedPagedList<TSource, TDestination>(this IEnumerable<TSource> list, PagingInfo pagingInfo)
    //    {
    //        IEnumerable<TDestination> sourceList = Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(list);
    //        IPagedList<TDestination> pagedList = new StaticPagedList<TDestination>(sourceList, pagingInfo.PageNumber, AppSettings.PageSize, pagingInfo.Total);
    //        return pagedList;
    //    }

    //    public static IPagedList<T> ToManualPagedList<T>(this IEnumerable<T> list, PagingInfo pagingInfo)
    //    {
    //        IPagedList<T> pagedList = new StaticPagedList<T>(list, pagingInfo.PageNumber, AppSettings.PageSize, pagingInfo.Total);
    //        return pagedList;
    //    }
    //}
}