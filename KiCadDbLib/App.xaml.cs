﻿using Avalonia;
using Avalonia.Markup.Xaml;

namespace KiCadDbLib
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
