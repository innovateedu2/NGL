﻿using System;

namespace NGL.Web.Models
{
    public interface IMapper<in TSource, TTarget>
        where TSource: class
        where TTarget: class
    {
        void Map(TSource source, TTarget target, Action<TTarget> injectProperties);
        void Map(TSource source, TTarget target);
        TTarget Build(TSource source, Action<TTarget> injectProperties);
        TTarget Build(TSource source);
    }
}
