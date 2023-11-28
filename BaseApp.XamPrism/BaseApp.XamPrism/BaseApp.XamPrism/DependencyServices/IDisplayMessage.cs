﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApp.XamPrism.DependencyServices
{
    public interface IDisplayMessage
    {
        void ShowMessageInfo(string message, double time = 5000);

        void ShowMessageWarning(string message, double time = 5000);

        void ShowMessageError(string message, double time = 5000);

        void ShowMessageSuccess(string message, double time = 5000);

        void ShowToast(string message, double time = 5000);
    }
}
