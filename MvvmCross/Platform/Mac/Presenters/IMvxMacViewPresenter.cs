﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Platform.Mac.Views;
using MvvmCross.Presenters;

namespace MvvmCross.Platform.Mac.Presenters
{
    public interface IMvxMacViewPresenter
        : IMvxViewPresenter, IMvxCanCreateMacView
    {
    }
}
