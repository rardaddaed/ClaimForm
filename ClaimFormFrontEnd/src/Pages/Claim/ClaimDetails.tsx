import {ClaimMaster} from "./Claim.master.tsx";
import {useEffect, useState} from "react";
import {CardGroup} from "../../Components/CardGroup.tsx";
import {FieldValues, FormProvider, useForm} from "react-hook-form";
import {FormContext, FormFieldAttributes, getFormSchema} from "../../Services/formSchemaService.ts";
import {FormRadioButtonList} from "../../Components/Forms/FormRadioButtonList.tsx";
import {FormDropDownList} from "../../Components/Forms/FormDropDownList.tsx";
import {FormTextBox} from "../../Components/Forms/FormTextBox.tsx";
import {fieldEquals, fieldEqualsThenSetTo, mergeFormSchema} from "../../Components/Forms/Utils.ts";
import {FormCheckBox} from "../../Components/Forms/FormCheckBox.tsx";
import FileUploadButton from "../../Components/Forms/FileUploadButton.tsx";
import FormDocumentsTable from "../../Components/Forms/FormDocumentsTable.tsx";
import ClaimDetailsHelpDialog from "../../Components/Dialogs/ClaimDetailsHelpDialog.tsx";
import OpenDialogButton from "../../Components/Dialogs/OpenDialogButton.tsx";
import Container from "../../Components/Container.tsx";
import Button from "../../Components/Dialogs/Button.tsx";
import BsbSearchDialog from "../../Components/Dialogs/BSBSearchDialog.tsx";
import axios from "axios";

document.title = "Claim Details";
let hasRun = false;

export const ClaimDetails = () => {
    const methods = useForm() as FormContext;
    methods.formName = "ClaimForm";
    const [schema, setSchema] = useState<Record<string, FormFieldAttributes> | undefined>(undefined);
    const [bsbModalVisible, setBsbModalVisible] = useState(false);

    useEffect(() => {
        const fetchSchema = async () => {
            hasRun = true;
            const data = await getFormSchema(methods.formName);
            setSchema(data);
        };

        if(!hasRun)
            fetchSchema();
    }, [methods.formName]);

    // const onSubmit = async (data: Record<string, string | number | boolean>) => {
    const onSubmit = async ({ formData, data, formDataJson, event } : {data: FieldValues, event?: React.BaseSyntheticEvent, formData: FormData, formDataJson: string, method?: "post" | "put" | "delete" }) => {
        console.log("TYPE OF DATA:", typeof formData)
        console.log("INSTANCE OF FORM DATA:", formData instanceof FormData)
        console.log(formData);

/*


        const images = document.querySelectorAll('img');

        for (const img of images) {
            if (img.src.startsWith('./')) {
                const response = await fetch(img.src);
                const blob = await response.blob();
                const reader = new FileReader();

                reader.onloadend = () => {
                    if(reader.result !== null)
                        img.src = reader.result;
                };

                reader.readAsDataURL(blob);
            }
        }


        const styleSheets = Array.from(document.styleSheets);
        let styles = '';

        for (const sheet of styleSheets) {
            try {
                const rules = sheet.cssRules;
                for (const rule of rules) {
                    styles += rule.cssText;
                }
            } catch (e) {
                console.warn('Could not read stylesheet:', sheet.href);
            }
        }

        const styleTag = `<style>${styles}</style>`;
        const htmlContent = document.documentElement.outerHTML.replace('</head>', `${styleTag}</head>`);
*/


        // const htmlContent = document.documentElement.outerHTML;
        // console.log("HTML CONTENT LENGTH:", htmlContent.length);
        formData.append("html", document.documentElement.outerHTML);
        /*const formData = new FormData();
        for (const key in data){
            console.log("Appending ", key, " to form data:", data[key]?.toString())
            formData.append(key, data[key]?.toString());
        }*/

        /*Object.keys(data).forEach((key, index) => {
            formData.append(`formFields[${index}].FieldName`, key);
            formData.append(`formFields[${index}].Value`, data[key]);
        });*/

        /*for (let pair of formData.entries()) {
            console.log(pair[0], pair[1]);
        }*/

        try {
            const result = await axios.post<Record<string, FormFieldAttributes>>(`http://localhost:5062/${methods.formName}`, formData);
            console.log("SUBMIT FORM RESULT", result.data);
            alert(result.data);
        }
        catch (e) {
            alert(e);
            console.log("SUBMIT FORM ERROR");
            console.log(e);
        }

    };

    if (!schema) return <div>Loading...</div>;

    methods.schema = schema;
    methods.setSchema = setSchema;
    const handleBsbSelected = async (bsbResults: string[]) => {
        const response = await axios.post<Record<string, FormFieldAttributes>>(`http://localhost:5062/${methods.formName}/SelectBsbOperation`, bsbResults[0], {
            headers: {
                'Content-Type': 'application/json'
            }
        });
        console.log("RESPONSE:", response.data);
        mergeFormSchema(response.data, methods.setSchema, methods.setValue);
    };
    return (
        <>
            <FormProvider {...methods}>
                <ClaimMaster onSubmit={onSubmit} headerText={"Worker's Compensation Claim Form"}>
                    <CardGroup text="Incident Details" id={"IncidentDetailsSection"} paddingContainer>
                        <div className="row">
                            <div className="form-group col-md-9">
                                <FormRadioButtonList id="IncidentLogged" label="Has an incident been logged in the Hazard and Incident Reporting System?"/>
                            </div>
                            <div id="IncNumDiv" className="form-group col-md-3">
                                <FormTextBox id={"IncidentNumber"} label={"Incident Number"} isVisible={fieldEquals("IncidentLogged", "1")}/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Claim Details" id={"ClaimDetailsSection"} paddingContainer>
                        <div className="row">
                            <div className="form-group col-md-6">
                                <FormRadioButtonList id="Whoisenteringclaimform" label="Who is entering the claim form?"/>
                            </div>
                            <div className="form-group col-md-6">
                                <FormRadioButtonList id="WhatIsTheClaimFor" label="What is the claim for?"/>
                            </div>
                        </div>

                        <Container className="row" isVisible={fieldEquals("Whoisenteringclaimform", "2")}>
                            <div className="form-group col-md-6">
                                <FormRadioButtonList
                                    id="Hasemployerbeennotified"
                                    label="Has the employer been notified?"
                                    onDependentFieldChanged={fieldEqualsThenSetTo("Whoisenteringclaimform", "2", "1")}
                                />
                            </div>
                            <div className="form-group col-6 col-md-3 pb-2">
                                <FormTextBox id="Employernotifiedondate" label="Employer Notified On" />
                            </div>
                            <div className="form-group col-6 col-md-3 mt-auto btn-group pb-2" >
                                <OpenDialogButton label="Help" className={"btn-primary"} DialogComponent={ClaimDetailsHelpDialog}/>
                            </div>
                        </Container>

                        <div className="row">
                            <div className="form-group col-md-8">
                                <FormDropDownList id={"Agency"} label={"Agency"}/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-8">
                                <FormTextBox id={"BranchSection"} label={"Branch / Section"}/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Worker Details" id="WorkerDetailsSection" paddingContainer>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <p>To populate Employee details, enter either an Employee Number or the Date of Birth and Family Name and select Lookup Employee</p>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 col-lg-3 pb-2">
                                <FormTextBox id="Workeremployeenumber" label="Employee Number"/>
                            </div>
                            <div className="form-group col-6 col-md-4 col-lg-3 offset-lg-3 pb-2">
                                <FormTextBox id="Workerbirthdate" label="Date of Birth"/>
                            </div>
                            <div className="form-group btn-group col-6 col-4 col-lg-3 mt-auto pb-2">
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Workerfamilyname" label="Family Name"/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Workergivennames" label="Given Name(s)"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Workerotherpreviousnames" label="Other Previous Name"/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormRadioButtonList id="Workergender" label="Gender"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Workeraddress1" label="Residential Address"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Workeraddress2" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Workeraddress3" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Workersuburb" label="Suburb"/>
                            </div>
                            <div className="form-group col-6 col-md-3 col-lg-2 pb-2">
                                <FormTextBox id="Workerstate" label="State"/>
                            </div>
                            <div className="form-group col-6 col-md-3 col-lg-2 offset-lg-1 pb-2">
                                <FormTextBox id="Workerpostcode" label="Postcode"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-6 col-md-3 pb-2">
                                <FormTextBox id="Workermobilephone" label="Mobile Phone"/>
                            </div>
                            <div className="form-group col-6 col-md-3 pb-2">
                                <FormTextBox id="Workerworkphone" label="Daytime Phone"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Workeremail" label="Email Address"/>
                            </div>
                        </div>
                    </CardGroup>


                    <CardGroup text="Injury Details" id="InjuryDetailsSection" paddingContainer>
                        <div className="row">
                            <div className="form-group col-md-4 pb-2">
                                <FormTextBox id="Injurydate" label="Date of Injury (or when it was noticed)"/>
                            </div>
                            <div className="form-group col-md-2 pb-2">
                                <FormTextBox id="Injurytime" label="Time of Injury"/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormDropDownList id="Injurydutystatus" label="What was the circumstances in which the injury occurred?"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-4 pb-2">
                                <FormRadioButtonList id="Hastheworkerstoppedwork" label="Has the worker stopped work?"/>
                            </div>
                            <div id="WorkerStoppedWorkSectionA" className="form-group col-md-2 pb-2">
                                <FormTextBox id="Workerstoppedworkdate" label="Date Stopped" isVisible={fieldEquals("Hastheworkerstoppedwork", "1")}/>
                            </div>
                            <div id="WorkerStoppedWorkSectionB" className="form-group col-md-2 pb-2">
                                <FormTextBox id="Workerstoppedworktime" label="Time Stopped" isVisible={fieldEquals("Hastheworkerstoppedwork", "1")}/>
                            </div>
                        </div>
                        <div className="row">
                            <div id="WorkerStoppedWorkSectionC" className="form-group col-md-4 pb-2">
                                <FormRadioButtonList id="Hastheworkerresumedwork" label="Has the worker resumed work?" isVisible={fieldEquals("Hastheworkerstoppedwork", "1")}/>
                            </div>
                            <div id="WorkerResumedWorkSectionA" className="form-group col-6 form-group col-md-2 pb-2">
                                <FormTextBox id="Workerresumedworkdate" label="Date Resumed" isVisible={fieldEquals("Hastheworkerresumedwork", "1")}/>
                            </div>
                            <div id="WorkerResumedWorkSectionB" className="form-group col-6 col-md-2 pb-2">
                                <FormTextBox id="Workerresumedworktime" label="Time Resumed" isVisible={fieldEquals("Hastheworkerresumedwork", "1")}/>
                            </div>
                        </div>
                        <div id="ReturnToWorkDetailsSection">
                            <div className="row">
                                <div className="form-group col-lg-6 pb-2">
                                    <FormRadioButtonList id="Returntohours" label="Has the worker returned to" isVisible={fieldEquals("Hastheworkerresumedwork", "1")}/>
                                </div>
                                <div className="form-group col-lg-6 pb-2">
                                    <FormRadioButtonList id="Returntoduties" label="Has the worker returned to" isVisible={fieldEquals("Hastheworkerresumedwork", "1")}/>
                                </div>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Where did the Injury Occur" id="WhereDidTheInjuryOccurSection" paddingContainer>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Injuryoccurredplace" label="Specific Place"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Injuryoccurredaddressline1" label="Address"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Injuryoccurredaddressline2" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Injuryoccurredaddressline3" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-sm-6 pb-2">
                                <FormTextBox id="Injuryoccurredsuburb" label="Suburb"/>
                            </div>
                            <div className="form-group col-6 col-sm-3 col-lg-2 pb-2">
                                <FormTextBox id="Injuryoccurredstate" label="State"/>
                            </div>
                            <div className="form-group col-6 col-sm-3 col-lg-2 offset-lg-1 pb-2">
                                <FormTextBox id="Injuryoccurredpostcode" label="Postcode"/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Description of Injury" id="DescriptionOfInjurySection" paddingContainer>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Descriptionofinjury" multiline={true} label="What is the injury and part of the body affected?"
                                             placeholder="(e.g. broken left lower leg, dermatitis of the hands, lower back strain)"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Descriptionoftask" multiline={true} label="What were you (the worker) doing at the incident?"
                                             placeholder="(e.g. lifting bags of cement from pallet to trolley)"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Descriptionofincident" multiline={true} label="What happened and how were you (the worker) injured?"
                                             placeholder="(e.g. repeatedly lifting heavy bags causing lower back pain)"/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Employment Details" paddingContainer>
                        <div className="row">
                            <div className="form-group col-5 col-md-4 col-lg-3 pb-2">
                                <FormTextBox id="Employmentstartdate" label="Date worker started employment"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Employmentaddress1" label="Address of worker's usual workplace"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Employmentaddress2" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Employmentaddress3" label=""/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Employmentsuburb" label="Suburb"/>
                            </div>
                            <div className="form-group col-6 col-md-3 col-lg-2 pb-2">
                                <FormTextBox id="Employmentstate" label="State"/>
                            </div>
                            <div className="form-group col-6 col-md-3 col-lg-2 offset-lg-1 pb-2">
                                <FormTextBox id="Employmentpostcode" label="Postcode"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-3 pb-2">
                                <FormTextBox id="Employmentcontact" label="Employer Contact Name"/>
                            </div>
                            <div className="form-group col-md-3 pb-2">
                                <FormTextBox id="Employmentphone" label="Contact phone"/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Employmentemail" label="Contact email"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-lg-4 col-xl-3 pb-2">
                                <FormRadioButtonList id="Employmentclassification" label="Is the worker"/>
                            </div>
                            <div className="form-group col-lg-4 col-xl-3 mt-auto pb-2">
                                <FormRadioButtonList id="Employmenttype" label=""/>
                            </div>
                            <div className="form-group col-xl-6 pb-2">
                                <FormRadioButtonList id="Workerposition" label="Is the worker"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-6 col-lg-3 pb-2">
                                <FormTextBox id="Employmentweeklyhours" label="Normal hours per week"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Occupation" label="Occupation"/>
                                <FormTextBox id="OccupationSearchBox" label="" style={{display: "none"}}/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="Jobtitle" label="Job Title"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Duties" label="Tasks / Duties"/>
                            </div>
                        </div>
                    </CardGroup>


                    <CardGroup text="Capacity Details" id="CapacityDetailsSection" paddingContainer>
                        <div className="row">
                            <div className="form-group col-6 col-md-6 pb-2">
                                <FormRadioButtonList id="Hastheworkerobtainedacertificateofcapacity" label="Have you obtained a certificate of capacity?"/>
                            </div>
                            <div className="form-group col-md-6 pb-2">
                                <FormRadioButtonList id="Istheworkerclaiminglossofwages" label="Are you claiming loss of wages?"/>
                            </div>
                        </div>
                        <div className="row">
                            <div id="CertificateDateSectionA" className="col-md-6">
                                <FormTextBox id="Datecertificatefrom" label="What period does the Workers Capacity Certificate cover?" isVisible={fieldEquals("Hastheworkerobtainedacertificateofcapacity", "1")}/>
                            </div>
                            <div id="CertificateDateSectionB" className="col-md-6">
                                <FormTextBox id="Datecertificateto" label="To" isVisible={fieldEquals("Hastheworkerobtainedacertificateofcapacity", "1")}/>
                            </div>
                        </div>

                    </CardGroup>


                    <CardGroup text="Worker's Bank Account Details" id="WorkerAccountDetails" paddingContainer>
                        <div className="row">
                            <div className="form-group col-md-3 col-lg-2 pb-2">
                                <FormTextBox id="Workerbsb1" label="BSB"/>
                            </div>
                            <div className="form-group col-md-3 col-lg-2 mt-auto pb-2">
                                <FormTextBox id="Workerbsb2" label="BSB"/> {/*OnTextChanged="Workerbsb2_TextChanged"*/}
                            </div>
                            <div className="form-group col-6 col-md-3 col-lg-2 mt-auto btn-group pb-2">
                                <Button className="btn-primary" label="Search" icon="fa-search" onClick={() => setBsbModalVisible(x => !x)}/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-lg-6 pb-2">
                                <FormTextBox id="Workerbankname" label="Bank Name"/>
                            </div>
                            <div className="form-group col-lg-6 pb-2">
                                <FormTextBox id="Workerbranchname" label="Branch Name"/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-lg-6 pb-2">
                                <FormTextBox id="Workeraccountnumber" label="Account Number"/>
                            </div>
                            <div className="form-group col-lg-6 pb-2">
                                <FormTextBox id="Workeraccountname" label="Account Name"/>
                            </div>
                        </div>

                    </CardGroup>

                    <CardGroup text="Other Information" paddingContainer>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormTextBox id="Otherinformation" label="" multiline/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup text="Supporting Documents" id="SupportingDocumentDiv" paddingContainer>
                        <div className="row">
                            <div className="form-group ms-auto btn-group col-auto">
                                <FileUploadButton id={"Documents"}/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormDocumentsTable id={"Documents"}/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup id="MedicalDeclarationSection" text="Medical Authority & Worker Declaration" isVisible={fieldEquals("Whoisenteringclaimform", ["1", "3"])} paddingContainer>
                        <div className="row">
                            <div className="form-group col-12">
                                <p>Only the worker can complete this section.</p>
                                <p>I give permission for:</p>
                                <ul>
                                    <li>my medical experts to provide ReturntoWorkSA, my employer’s claims agent or my self-insured employer with information relating, and/or relevant to my work
                                        injury, condition or illness.
                                    </li>
                                    <li>any of my medical experts to receive x-rays, medical records or reports relating to my claim (including copies) for the purpose of writing a report about my
                                        injury, condition or illness related issue.
                                    </li>
                                    <li>ReturnToWorkSA or my employer’s claims agent, or my self-insured employer to release my personal contact information to an independent medical examiner for
                                        the purpose of an appointment reminder.
                                    </li>
                                </ul>
                                <p>A photocopy of this medical authority is valid.</p>
                                <p>I acknowledge that it is an offence against the Return to Work Act 2014 to make a statement that is false or misleading. The information I have provided is true
                                    and not misleading. I agree to advise ReturnToWorkSA if:</p>
                                <ul>
                                    <li>my circumstances change</li>
                                    <li>I become aware of any matter that would make the above information false or misleading</li>
                                    <li>I undertake any employment (paid or unpaid), including selfemployment, during my claim.</li>
                                </ul>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6">
                                <FormTextBox id="WorkerDeclarationGivenNames" label="Given Name(s)" readOnly/>
                            </div>
                            <div className="form-group col-md-6">
                                <FormTextBox id="WorkerDeclarationFamilyName" label="Family Name" readOnly/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 mt-auto">
                                <FormCheckBox id="Workerconfirm" label="Worker confirms/agrees to the above"/>
                            </div>
                            <div className="form-group col-md-5">
                                <FormTextBox id="Dateworkerconfirm" label="Date" onDependentFieldChanged={fieldEqualsThenSetTo("Workerconfirm", true, new Date().toISOString().split('T')[0])}/>
                            </div>
                        </div>
                    </CardGroup>

                    <CardGroup id="EmployerDeclarationSection" text="Employer Declaration" isVisible={fieldEquals("Whoisenteringclaimform", ["2"])} paddingContainer>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <p>I acknowledge that it is an offence against the Return to Work Act 2014 to make a statement that is false or misleading. The information I have provided is true
                                    and not misleading. I agree to advise ReturnToWorkSA:</p>
                                <ul>
                                    <li>if my circumstances change</li>
                                    <li>if I become aware of any matter that would make the above information false or misleading</li>
                                    <li>of any change in the worker’s return to work status.</li>
                                </ul>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-md-6 pb-2">
                                <FormTextBox id="EmployerDeclarationName" label="Name of Employer and Representative"/>
                            </div>
                            <div className="form-group col-12 col-md-6 pb-2">
                                <FormTextBox id="Dateemployerconfirm" label="Date" onDependentFieldChanged={fieldEqualsThenSetTo("Employerconfirm", true, new Date().toISOString().split('T')[0])}/>
                            </div>
                        </div>
                        <div className="row">
                            <div className="form-group col-12 pb-2">
                                <FormCheckBox id="Employerconfirm" label="Employer confirms/agrees to the above"/>
                            </div>
                        </div>
                    </CardGroup>
                </ClaimMaster>
            </FormProvider>
            <BsbSearchDialog visible={bsbModalVisible} setVisible={setBsbModalVisible} onLinkClicked={handleBsbSelected}/>
        </>
    );
}
