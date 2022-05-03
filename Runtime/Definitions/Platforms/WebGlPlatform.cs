﻿// Copyright (c) Reality Collective. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace RealityToolkit.ServiceFramework.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the WebGL platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("2EA1714D-E989-488E-B96B-2BA85D00733A")]
    public class WebGlPlatform : BasePlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
#if PLATFORM_WEBGL
                return !UnityEngine.Application.isEditor;
#else
                return false;
#endif
            }
        }

#if UNITY_EDITOR

        /// <inheritdoc />
        public override UnityEditor.BuildTarget[] ValidBuildTargets { get; } = { UnityEditor.BuildTarget.WebGL };

#endif // UNITY_EDITOR
    }
}
