// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Toolkit.Uwp.UI.Lottie.IR
{
#if PUBLIC_IR
    public
#endif
    interface IAnimatableVector3 : IAnimatableValue<Vector3>
    {
        AnimatableVector3Type Type { get; }
    }

#if PUBLIC_IR
    public
#endif
    enum AnimatableVector3Type
    {
        Vector3,
        XYZ,
    }
}
