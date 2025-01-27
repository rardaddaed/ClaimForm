﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAOCPSEDB.Models;

public class ClmfrmClaimX
{
    public ClmfrmClaimX()
    {
        Dateformentered = DateTime.Today;
    }

    [Key]
    public int Claimformid { get; set; }

    public string? Claimformnumber { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Whoisenteringclaimform { get; set; }

    public int? Hasemployerbeennotified { get; set; }

    public DateTime? Employernotifiedondate { get; set; }

    public int? Orgstructid { get; set; }

    public int? Workerpartyid { get; set; }

    public string? Workeremployeenumber { get; set; }

    public string? Workergivennames { get; set; }

    public string? Workerfamilyname { get; set; }

    public int? Workergender { get; set; }

    public DateTime? Workerbirthdate { get; set; }

    public string? Workeraddress1 { get; set; }

    public string? Workeraddress2 { get; set; }

    public string? Workeraddress3 { get; set; }

    public string? Workersuburb { get; set; }

    public string? Workerstate { get; set; }

    public string? Workerpostcode { get; set; }

    public string? Workermobilephone { get; set; }

    public string? Workerworkphone { get; set; }

    public string? Workeremail { get; set; }

    public string? Injurydutystatus { get; set; }

    public DateTime? Injurydate { get; set; }

    public DateTime? Injurytime { get; set; }

    public int? Hastheworkerstoppedwork { get; set; }

    public DateTime? Workerstoppedworkdate { get; set; }

    public DateTime? Workerstoppedworktime { get; set; }

    public int? Hastheworkerresumedwork { get; set; }

    public DateTime? Workerresumedworkdate { get; set; }

    public DateTime? Workerresumedworktime { get; set; }

    public string? Injuryoccurredplace { get; set; }

    public string? Injuryoccurredaddressline1 { get; set; }

    public string? Injuryoccurredaddressline2 { get; set; }

    public string? Injuryoccurredaddressline3 { get; set; }

    public string? Injuryoccurredsuburb { get; set; }

    public string? Injuryoccurredstate { get; set; }

    public string? Injuryoccurredpostcode { get; set; }

    public string? Descriptionofincident { get; set; }

    public string? Descriptionofinjury { get; set; }

    public string? Descriptionoftask { get; set; }

    public int? Hastheworkerobtainedacertificateofcapacity { get; set; }

    public int? Istheworkerclaiminglossofwages { get; set; }

    public string? Workerbsb1 { get; set; }

    public string? Workerbsb2 { get; set; }

    public string? Workeraccountnumber { get; set; }

    public string? Workeraccountname { get; set; }

    public string? Workerbankname { get; set; }

    public string? Workerbranchname { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Dateformentered { get; set; }

    public int? Claimid { get; set; }

    public int? Overrideresidential { get; set; }

    public string? Workerotherpreviousnames { get; set; }

    public DateTime? Employmentstartdate { get; set; }

    public string? Employmentaddress1 { get; set; }

    public string? Employmentaddress2 { get; set; }

    public string? Employmentaddress3 { get; set; }

    public string? Employmentsuburb { get; set; }

    public string? Employmentstate { get; set; }

    public string? Employmentpostcode { get; set; }

    public string? Employmentcontact { get; set; }

    public string? Employmentemail { get; set; }

    public string? Employmenttype { get; set; }

    public string? Employmentclassification { get; set; }

    public decimal? Employmentweeklyhours { get; set; }

    public string? Employmentphone { get; set; }

    public string? Branchsection { get; set; }

    public string? Jobtitle { get; set; }

    public string? Occupation { get; set; }

    public string? Duties { get; set; }

    public short? Returntohours { get; set; }

    public short? Returntoduties { get; set; }

    public short? Workerposition { get; set; }

    public DateTime? Datecertificatefrom { get; set; }

    public DateTime? Datecertificateto { get; set; }

    public short? Workerconfirm { get; set; }

    public DateTime? Dateworkerconfirm { get; set; }

    public short? Employerconfirm { get; set; }

    public DateTime? Dateemployerconfirm { get; set; }

    public string? Otherinformation { get; set; }

    public short? Incidentlogged { get; set; }

    public string? Incidentnumber { get; set; }

    public short? Whatistheclaimfor { get; set; }

    public string? Employerdeclarationname { get; set; }

    public virtual ICollection<ClmfrmClaimdocumentX> ClmfrmClaimdocumentXes { get; set; } = new List<ClmfrmClaimdocumentX>();

    public virtual OsOrgstructure? Orgstruct { get; set; }

    public virtual ParParty? Workerparty { get; set; }


    #region Tuple / Non DB Helpers. These are not procedures/functions in sql database.

    [NotMapped]
    public bool EmployerEnterTheForm => Whoisenteringclaimform == (int)ClaimFormEnteredBy.Employer || Whoisenteringclaimform == (int)ClaimFormEnteredBy.BothWorkerAndEmployer;

    [NotMapped]
    public bool WorkerEnterTheForm => Whoisenteringclaimform == (int)ClaimFormEnteredBy.Worker || Whoisenteringclaimform == (int)ClaimFormEnteredBy.BothWorkerAndEmployer;

    [NotMapped]
    public bool ObtainedCapacityCertificate => Hastheworkerobtainedacertificateofcapacity == (int)YesNoNA.Yes;

    #endregion
}
