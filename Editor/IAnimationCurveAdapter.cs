﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityToCustomEngineExporter.Editor
{
    public interface IAnimationCurveAdapter<T> : IAnimationCurveAdapter
    {
        T Evaluate(float f);
    }

    public interface IAnimationCurveAdapter
    {
        bool HasTracks { get; }
        bool HasProperty(string propertyName);
        void PickTracks(AnimationClip clip, IEnumerable<EditorCurveBinding> bindings);
    }
}