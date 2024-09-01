using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEstimateworksheetSa
{
    public int Claimid { get; set; }

    public int Estimateworksheetno { get; set; }

    public decimal? Totalincapacityrate { get; set; }

    public decimal? Totalincapacityweeks { get; set; }

    public decimal? Partialincapacityrate { get; set; }

    public decimal? Partialincapacityweeks { get; set; }

    public decimal? Otherincapacityrate { get; set; }

    public decimal? Otherincapacityweeks { get; set; }

    public decimal? Medicalservicesrate { get; set; }

    public decimal? Medicalservicesyears { get; set; }

    public decimal? Medicalalliedhealthrate { get; set; }

    public decimal? Medicalalliedhealthyears { get; set; }

    public decimal? Medicalothergoodsservicesrate { get; set; }

    public decimal? Medicalothergoodsservicesyears { get; set; }

    public decimal? Hospitalinpatientrate { get; set; }

    public decimal? Hospitalinpatientyears { get; set; }

    public decimal? Hospitaloutpatientrate { get; set; }

    public decimal? Hospitaloutpatientyears { get; set; }

    public decimal? Rehabilitationrate { get; set; }

    public decimal? Rehabilitationyears { get; set; }

    public decimal? Lumpsumnoneconomiclossamount { get; set; }

    public decimal? Lumpsumeconomiclossamount { get; set; }

    public decimal? Redemptionmedexpensesamount { get; set; }

    public decimal? Redemptionincomesupportamount { get; set; }

    public decimal? Commonlawamount { get; set; }

    public decimal? Legalamount { get; set; }

    public decimal? Investigationamount { get; set; }

    public decimal? Othernoncompensationamount { get; set; }

    public decimal? Othergoodsservicesamount { get; set; }

    public decimal? Deedofreleaseamount { get; set; }

    public decimal? Propertydamageamount { get; set; }

    public decimal? Travelamount { get; set; }

    public decimal? Recoveredamount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmEstimateworksheet ClmEstimateworksheet { get; set; } = null!;
}
