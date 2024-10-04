﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Marines.Lifeboat;

[GenerateTypedNameReferences]
public sealed partial class LifeboatComputerWindow : DefaultWindow
{
    public LifeboatComputerWindow()
    {
        RobustXamlLoader.Load(this);
    }
}