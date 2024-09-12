//using SAOCPSEDB.Models;

//namespace SAOCPSEDB.ClaimForm.Logic
//{
//    public class ClmfrmClaimXValidator: LogicValidator<ClmfrmClaimX>
//    {
//        public ClmfrmClaimXValidator(SbcDbContext context, ClmfrmClaimX? data) : base (context, data)
//        {
//            DefineSuburb(x => new { x.Workersuburb, x.Workerstate, x.Workerpostcode });
//            DefineSuburb(x => new { x.Injuryoccurredsuburb, x.Injuryoccurredstate, x.Injuryoccurredpostcode });
//            DefineSuburb(x => new { x.Employmentsuburb, x.Employmentstate, x.Employmentpostcode });

//            // Disabled Always but want it to be in the schema so value can be updated.
//            Enable(x => new { x.Workerbankname, x.Workerbranchname }, false);
            
//            Enable(x => new { x.Whoisenteringclaimform, x.Hasemployerbeennotified, x.Branchsection, x.Occupation, x.Jobtitle, x.Duties });
//            Mandatory(x => new { x.Whoisenteringclaimform, x.Hasemployerbeennotified, x.Branchsection });

//            SetItems(x => x.Whoisenteringclaimform, OptionItems.ClaimFormEnteredByTypes);
//            SetItems(x => x.Hasemployerbeennotified, OptionItems.YesNo);

//            Enable(x => new { x.Workeremployeenumber, x.Workergivennames, x.Workerfamilyname, x.Workerotherpreviousnames, x.Workergender, x.Workerbirthdate, x.Workeraddress1, x.Workeraddress2, x.Workeraddress3, x.Workersuburb, x.Workermobilephone, x.Workerworkphone, x.Workeremail });
//            Mandatory(x => new { x.Workeremployeenumber, x.Workergivennames, x.Workerfamilyname, x.Workergender, x.Workerbirthdate, x.Workeraddress1, x.Workersuburb, x.Workeremail, x.Workermobilephone });

//            MaxLength(x => new { x.Workeremployeenumber, x.Incidentnumber, x.Workermobilephone, x.Workerworkphone }, 25);
//            MaxLength(x => x.Workeremail, 100);
            
//            SetCodeType(x => x.Workergender, "GENDER");

//            /*
//             * Couldn't do yet
//            DefineSuburb(Workersuburb, Workerstate, Workerpostcode);
//            Workermobilephone.BindingType = BindingType.Phone;
//            Workerworkphone.BindingType = BindingType.Phone;
//             */


//            Enable(x => new { x.Injurydutystatus, x.Injurydate, x.Injurytime, x.Hastheworkerstoppedwork, x.Hastheworkerresumedwork, x.Workerposition });
//            Mandatory(x => new { x.Injurydutystatus, x.Injurydate, x.Injurytime, x.Hastheworkerstoppedwork, x.Hastheworkerresumedwork });

//            SetCodeType(x => x.Injurydutystatus, "DUTYSTAT");

//            SetItems(x => x.Hastheworkerstoppedwork, OptionItems.YesNo);
//            SetItems(x => x.Hastheworkerresumedwork, OptionItems.YesNo);
//            SetItems(x => x.Returntohours, OptionItems.ClaimFormReturnToHours);
//            SetItems(x => x.Returntoduties, OptionItems.ClaimFormReturnToDuties);
//            SetItems(x => x.Workerposition, OptionItems.ClaimFormWorkerPosition);
//            SetItems(x => x.Incidentlogged, OptionItems.YesNo);
//            SetItems(x => x.Whatistheclaimfor, OptionItems.WhatIsTheClaimFor);

//            /*
//             * Couldn't do yet
//            Injurytime.BindingType = BindingType.Time;
//            Workerstoppedworktime.BindingType = BindingType.Time;
//            Workerresumedworktime.BindingType = BindingType.Time;

//             */


//            Enable(x => new { x.Injuryoccurredplace, x.Injuryoccurredaddressline1, x.Injuryoccurredaddressline2, x.Injuryoccurredaddressline3, x.Injuryoccurredsuburb });
//            Mandatory(x => new { x.Injuryoccurredplace, x.Injuryoccurredaddressline1, x.Injuryoccurredsuburb });
//            // Couldn't do yet
//            // DefineSuburb(Injuryoccurredsuburb, Injuryoccurredstate, Injuryoccurredpostcode);


//            Enable(x => new { x.Descriptionofinjury, x.Descriptionoftask, x.Descriptionofincident });
//            Mandatory(x => new { x.Descriptionofinjury, x.Descriptionofincident });

//            Enable(x => new { x.Hastheworkerobtainedacertificateofcapacity, x.Istheworkerclaiminglossofwages });
//            Mandatory(x => new { x.Hastheworkerobtainedacertificateofcapacity, x.Istheworkerclaiminglossofwages });
//            SetItems(x => x.Hastheworkerobtainedacertificateofcapacity, OptionItems.YesNo);
//            SetItems(x => x.Istheworkerclaiminglossofwages, OptionItems.YesNo);

//            Enable(x => new { x.Employmentstartdate, x.Employmentaddress1, x.Employmentaddress2, x.Employmentaddress3, x.Employmentsuburb, x.Employmentcontact, x.Employmentphone, x.Employmentemail, x.Employmenttype, x.Employmentclassification, x.Employmentweeklyhours });
//            SetCodeType(x => x.Employmenttype, "SAEMPTYP", 5);
//            SetCodeType(x => x.Employmentclassification, "SAEMPCLS", 5);
//            MaxLength(x => x.Employmentweeklyhours, 5);

//            /*
//             * Couldn't do yet
             
//            DefineSuburb(Employmentsuburb, Employmentstate, Employmentpostcode);
//            Employmentphone.BindingType = BindingType.Phone;
//            Employmentemail.BindingType = BindingType.Email;
//            Employmentweeklyhours.DecimalPlaces = 2;

//             */

//            Enable(x => new { x.Workerbsb1, x.Workerbsb2, x.Workeraccountname, x.Workeraccountnumber });

//            // Couldn't do yet
//            //Workeraccountnumber.BindingType = BindingType.Integer;

//            Enable(x => x.Otherinformation);
//            Enable(x => x.Incidentlogged);
//            Mandatory(x => x.Incidentlogged);

//            /*
//             * Not sure what to do about this... It's conditional so should maybe be in update?
//             Enable(Tuple.Incidentlogged == 1, Incidentnumber);
//             Mandatory(Tuple.Incidentlogged == 1, Incidentnumber);
//             */

//            Enable(x => x.Whatistheclaimfor);
//            Mandatory(x => x.Whatistheclaimfor);


//            /*
//             * Couldn't do yet
//            Returntohours.ClientName = "Has Worker returned to hours";
//            Returntoduties.ClientName = "Has Worker returned to duties";
//            Workerbsb1.ClientName = Workerbsb2.ClientName = "Worker's BSB";

//            Datecertificatefrom.FutureDates = Datecertificateto.FutureDates = true;
//             */
            
//        }

//        public override void Update(bool checkValueChanges = false)
//        {
//            base.Update(checkValueChanges);

//            EnableAndMandatory(x => x.Hasemployerbeennotified, x => x.Whoisenteringclaimform == (int)ClaimFormEnteredBy.Employer || x.Whoisenteringclaimform == (int)ClaimFormEnteredBy.BothWorkerAndEmployer);
//            EnableAndMandatory(x => x.Employernotifiedondate, x => x.Hasemployerbeennotified == (int)YesNoNA.Yes);

//            Enable(x => new { x.Workerstoppedworkdate, x.Workerstoppedworktime, x.Hastheworkerresumedwork }, x => x.Hastheworkerstoppedwork == (int)YesNoNA.Yes);
//            Mandatory(x => new {x.Workerstoppedworkdate, x.Workerstoppedworktime, x.Hastheworkerresumedwork }, x => x.Hastheworkerstoppedwork == (int)YesNoNA.Yes);

//            EnableAndMandatory(x => new {x.Workerresumedworkdate, x.Workerresumedworktime, x.Returntohours, x.Returntoduties }, x => x.Hastheworkerresumedwork == (int)YesNoNA.Yes);

//            Mandatory(x => new {x.Workerbsb1, x.Workerbsb2, x.Workeraccountname, x.Workeraccountnumber }, x =>
//                !string.IsNullOrEmpty(x.Workerbsb1)
//                || !string.IsNullOrEmpty(x.Workerbsb2)
//                || !string.IsNullOrEmpty(x.Workeraccountnumber)
//                || !string.IsNullOrEmpty(x.Workeraccountname)
//            );

//            EnableAndMandatory(x => x.Datecertificatefrom, x => x.Hastheworkerobtainedacertificateofcapacity == (int)YesNoNA.Yes);
            
//            // Should be equivalent:
//            //DisabledAndCleared(x => x.Datecertificateto, x => x.Hastheworkerobtainedacertificateofcapacity != (int)YesNoNA.Yes);
//            Enable(x => x.Datecertificateto, x => x.ObtainedCapacityCertificate);

//            /*
//            // Should be equivalent:
//            Workerconfirm.DisabledAndCleared = !Tuple.WorkerEnterTheForm;
//            Employerconfirm.DisabledAndCleared = !Tuple.EmployerEnterTheForm;
//            Employerdeclarationname.DisabledAndCleared = !Tuple.EmployerEnterTheForm;
//            */
//            Enable(x => x.Workerconfirm, x => x.WorkerEnterTheForm);
//            Enable(x => x.Employerconfirm, x => x.EmployerEnterTheForm);
//            Enable(x => x.Employerdeclarationname, x => x.EmployerEnterTheForm);



//            EnableAndMandatory(x => x.Dateworkerconfirm, x => x.Workerconfirm == (int)YesNoNA.Yes);
//            EnableAndMandatory(x => x.Dateemployerconfirm, x => x.Employerconfirm == (int)YesNoNA.Yes);
//            EnableAndMandatory(x => x.Employerdeclarationname, x => x.Whoisenteringclaimform == (int)ClaimFormEnteredBy.Employer || x.Whoisenteringclaimform == (int)ClaimFormEnteredBy.BothWorkerAndEmployer);


//            EnableAndMandatory(x => x.Incidentnumber, x => x.Incidentlogged == 1);
//        }

//        public override List<ValidationResult> CustomValidate(List<ValidationResult> errors)
//        {
//            return base.CustomValidate(errors);
//        }
//    }

//}
