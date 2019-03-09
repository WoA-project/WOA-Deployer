﻿namespace Deployer.Gui
{
    public interface ISaveFilePicker
    {
        string Filter { get; set; }
        string FileName { get; set; }
        string DefaultExt { get; set; }
        string PickFile();
    }
}