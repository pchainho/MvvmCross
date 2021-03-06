﻿// MvxFieldSourceBinding.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.Reflection;
using MvvmCross.Binding.Bindings.Source;

namespace MvvmCross.Plugins.FieldBinding
{
    public abstract class MvxFieldSourceBinding
        : MvxSourceBinding
    {
        private readonly FieldInfo _fieldInfo;

        protected FieldInfo FieldInfo => _fieldInfo;

        protected MvxFieldSourceBinding(object source, FieldInfo fieldInfo)
            : base(source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (fieldInfo == null)
                throw new ArgumentNullException(nameof(fieldInfo));
            _fieldInfo = fieldInfo;
        }
    }
}