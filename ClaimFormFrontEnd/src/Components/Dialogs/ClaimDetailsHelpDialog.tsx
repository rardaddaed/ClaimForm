import cancelImage from "../../assets/Images/cancel.gif";
import {DialogProps} from "./OpenDialogButton.tsx";

const ClaimDetailsHelpDialog = ({closeDialog}: DialogProps) => {
    return (
        <div id="ctl00_FullWidthContainer_ClaimDetailsSection_EmployerNotifiedOnHelpLinkContainer" className="ModalDialog" style={{position: "fixed", zIndex: 100001, left: "62px", top: "513px", padding: 0, maxWidth: "94vw"}}>
            <div id="ctl00_FullWidthContainer_ClaimDetailsSection_EmployerNotifiedOnHelpLinkContainer_EmployerNotifiedOnHelpLinkUpdatePanel">

                <div className="HelpTextPopup">
                    <div style={{backgroundColor: "#a51018",color: "white", padding: "5px", fontWeight:"bold", fontSize: "15px"}}>
                        Help
                    </div>
                    <div className="HelpTextContent">
                        <b>Employer -</b> Agency for which you are employed at the time of the injury, e.g. SAPOL, Health etc.
                        <br/>
                        <br/>
                        <b>Employer Notified On -</b> The date when you first became aware of and reported the Illness/Injury to your Supervisor / Manager / Injury Management Unit (IMU), either verbally or by way of an Incident Reporting System, telephone call, or email etc.
                        <br/>
                        <br/>
                        Note:  This field relates to the Early Assessment Performance Measure and maps to the 'First Notified Date' field in SIMS.
                    </div>
                </div>
                <div style={{textAlign:'right'}}>
                    <a onClick={closeDialog} href={"javascript:void(0);"}>
                        <img title={"cancel"} alt={"Cancel Image"} id="CancelImage" src={cancelImage} style={{borderWidth:"0px"}}/>
                        <span id="CancelLabel">Cancel</span>
                    </a>
                </div>
            </div>
        </div>
    );
};

export default ClaimDetailsHelpDialog;
