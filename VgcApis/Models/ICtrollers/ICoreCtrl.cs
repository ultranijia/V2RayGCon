﻿namespace VgcApis.Models.IControllers
{
    public interface ICoreCtrl
    {
        Models.Datas.StatsSample Peek();
        string GetStatus();
        string GetTitle();
        string GetUid();
        string GetConfig();
        string GetName();

        double GetIndex();

        bool IsCoreRunning();
        bool IsSelected();
        bool IsUntrack();

        bool IsSuitableToBeUsedAsSysProxy(
            bool isGlobal,
            out bool isSocks,
            out int port);
    }
}
