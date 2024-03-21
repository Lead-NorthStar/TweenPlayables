using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [Obsolete]
    [CustomTimelineEditor(typeof(TweenTextMeshProUGUITrack))]
    public sealed class TweenTextMeshProUGUITrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.textMeshProUGUIIcon;
        public override string DefaultTrackName => "Tween TextMeshProUGUI Track";
    }

    [Obsolete]
    [CustomTimelineEditor(typeof(TweenTextMeshProUGUIClip))]
    public sealed class TweenTextMeshProUGUIClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween TextMeshProUGUI";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.textMeshProUGUIIcon;
    }

    [Obsolete]
    [CustomPropertyDrawer(typeof(TweenTextMeshProUGUIBehaviour))]
    public sealed class TweenTextMeshProUGUIBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "fontSize", "characterSpacing", "lineSpacing", "wordSpacing", "paragraphSpacing", "colorGradient", "text"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}