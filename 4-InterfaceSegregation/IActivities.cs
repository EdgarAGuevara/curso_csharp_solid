using System;
namespace InterfaceSegregation
{
    public interface IActivities : IWorkTeamActivities, IDesignActivities, IDevelopActivities, ITestActivities
    {
    }
}

