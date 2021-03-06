﻿using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides the basic properties of a PaneButton
    /// </summary>
    public class PaneButton : Button
    {
        public override void EndInit()
        {
            base.EndInit();
            Loaded += PaneIcon.PaneIconBadge_Loaded;
        }

        static PaneButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneButton),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneButton)));
        }
    }
}