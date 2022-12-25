// File:    Title.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:27:47
// Purpose: Definition of Enum Title

using System;
using System.ComponentModel;

namespace Project
{
    public enum EmployeesTypes
    {
        [Description("Business Manager")] BusinessManager,
        Finance,
        [Description("ogistic Manager")] LogisticManager,
        [Description("Pickup Employee")] PickupEmployee,
        [Description("Production Planner")] ProductionPlanner,

    }
}