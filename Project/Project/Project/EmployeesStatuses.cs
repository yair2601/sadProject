// File:    Title.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:27:47
// Purpose: Definition of Enum Title

using System;
using System.ComponentModel;

namespace Project
{
    public enum EmployeesStatuses
    {
        [Description("Lay Off")] LayOff,
        Vacation,
        [Description("Maternuty Leave")] MaternutyLeave,
        [Description("Paternity Leave")] PaternityLeave,
        Work

    }
}