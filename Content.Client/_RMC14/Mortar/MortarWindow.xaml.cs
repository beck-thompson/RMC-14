﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Mortar;

[GenerateTypedNameReferences]
public sealed partial class MortarWindow : DefaultWindow
{
    public MortarWindow()
    {
        RobustXamlLoader.Load(this);
    }
}