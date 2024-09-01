namespace SAOCPSEDB
{
    public enum YesNoNA { Yes = 1, No = 2, Unknown = 3, Undecided = 4, NotApplicable = 5, Possible = 6, DonotKnow = 7, Both = 8, NotKnown = 9, PreviousProvided = 10, Uncertain = 11 };
    public enum ClaimFormEnteredBy { Worker = 1, Employer = 2, BothWorkerAndEmployer = 3, Other = 4 }
    public enum ClaimFormReturnToHoursType { PreInjuryHours = 1, LessThanPreInjuryHours = 2 }
    public enum ClaimFormReturnToDutiesType { Normal = 1, Modified = 2 }
    public enum ClaimFormWorkerPositionType { Apprentice = 1, Trainee = 2, WorkingDirector = 3 }
    public enum WhatIsTheClaimForType { TimeOffWork = 1, MedicalExpenses = 2 }


    public static class OptionItems
    {
        public static List<KeyValuePair<string, string>> YesNo = new()
        {
            new(((int)YesNoNA.Yes).ToString(), "Yes"),
            new(((int)YesNoNA.No).ToString(), "No")
        };

        public static List<KeyValuePair<string, string>> ClaimFormEnteredByTypes = new()
        {
            new(((int)ClaimFormEnteredBy.Worker).ToString(), "Worker"),
            new(((int)ClaimFormEnteredBy.Employer).ToString(), "Employer"),
            new(((int)ClaimFormEnteredBy.BothWorkerAndEmployer).ToString(), "Both Worker and Employer")
        };

        public static List<KeyValuePair<string, string>> WhatIsTheClaimFor = new()
        {
            new(((int)WhatIsTheClaimForType.TimeOffWork).ToString(), "Time Off Work"),
            new(((int)WhatIsTheClaimForType.MedicalExpenses).ToString(), "Medical Expenses"),
        };

        public static List<KeyValuePair<string, string>> ClaimFormReturnToHours = new()
        {
            new(((int)ClaimFormReturnToHoursType.PreInjuryHours).ToString(), "Pre-injury hours"),
            new(((int)ClaimFormReturnToHoursType.LessThanPreInjuryHours).ToString(), "Less than pre-injury hours"),
        };

        public static List<KeyValuePair<string, string>> ClaimFormReturnToDuties = new()
        {
            new(((int)ClaimFormReturnToDutiesType.Normal).ToString(), "Normal duties"),
            new(((int)ClaimFormReturnToDutiesType.Modified).ToString(), "Modified duties"),
        };

        public static List<KeyValuePair<string, string>> ClaimFormWorkerPosition = new()
        {
            new(((int)ClaimFormWorkerPositionType.Apprentice).ToString(), "an apprentice"),
            new(((int)ClaimFormWorkerPositionType.Trainee).ToString(), "a trainee"),
            new(((int)ClaimFormWorkerPositionType.WorkingDirector).ToString(), "a working director"),
        };
    }
}
