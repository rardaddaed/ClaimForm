import HeaderLogoRed from "../../assets/Images/HeaderLogoRed.png";
import {RecaptchaFake} from "./RecaptchaFake.tsx";

const Default = ({openForm} : {openForm: () => void}) => {

    return (
        <form id="form2">
            <div className="container arrow-ul">
                <div className="row header-container">
                    <div className="form-group col-9 col-sm-9 col-md-6 col-lg-7 col-xl-8">
                        <h2 style={{fontWeight: "bold", color: "white"}}>
                            <label>How to make a claim for compensation</label>
                        </h2>
                    </div>
                    <div className="float-end d-none d-md-block col-auto">
                        <img src={HeaderLogoRed} alt={"Logo"}/>
                    </div>
                    <div className="float-end d-block d-md-none">
                        <img src="../../assets/Images/HeaderLogoRedNoText.png" alt={"text"}/>
                    </div>
                </div>
                <div className="row red-container">
                    <div className="row">
                        <div className="form-group col-12 pb-2">
                            <p>
                                SA Government employees who have suffered an illness / injury at
                                work may be eligible for income support and/or the reimbursement of
                                medical expenses and other return to work services.
                            </p>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col-12 pb-2">
                            <h3>Before making a claim, workers need to</h3>
                            <ul>
                                <li>Notify their employer (Agency) about the illness/injury;</li>
                                <br/>
                                <li>
                                    See a doctor to get a Work Capacity Certificate (please note, your
                                    claim may not be accepted without a Work Capacity Certificate).
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col-12 pb-2">
                            <h3>Important Information for workers</h3>
                            <ul>
                                <li>
                                    Report a work injury to your employer (Agency) as soon as possible
                                    and talk to them about a plan to stay at or return to work.
                                </li>
                                <br/>
                                <li>
                                    Talk to your Doctor about work tasks you can still do and obtain a
                                    Work Capacity Certificate.
                                </li>
                                <br/>
                                <li>
                                    Be actively involved in your treatment, recovery and return to
                                    work, or stay at work plans.
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div className="row" style={{width: "100%"}}>
                        <div className="form-group col-12 text-center">
                            <h2 style={{color: "#A51018"}}>Are you ready to submit a claim?</h2>
                            <div className="row">
                                <div
                                    id="VerificationEmailSection"
                                    className="form-group offset-3 col-md-6"
                                >
                                    <label htmlFor="verificationEmail" className="label" id="verificationEmail:label">Please enter a valid email address to obtain a security code to gain access to the
                                        form</label>
                                    <input name="verificationEmail" type="text" id="verificationEmail" className="form-control auto-grow Mandatory" title=""/>
                                </div>
                            </div>
                            <RecaptchaFake/>
                            <div style={{display: "flex", justifyContent: "center", flexDirection: "row", gap: 5}}>
                                <button
                                    type="button"
                                    name="YesButton"
                                    value=""
                                    onClick={() => {
                                        openForm();
                                    }}
                                    id="YesButton"
                                    className="btn btn-success btn-display"
                                    style={{width: 100, height: 60}}
                                >
                                    YES
                                </button>
                                <button
                                    type="button"
                                    name="NoButton"
                                    value=""
                                    id="NoButton"
                                    className="btn btn-danger btn-display"
                                    style={{width: 100, height: 60}}
                                >
                                    NO
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>

    );

}

export default Default;
