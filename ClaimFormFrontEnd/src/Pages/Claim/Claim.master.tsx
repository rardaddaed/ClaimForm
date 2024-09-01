import {FC, PropsWithChildren} from "react";
import HeaderLogoRed from "../../assets/Images/HeaderLogoRed.png";
import {Form} from "react-hook-form";

interface ClaimMasterProps {
    headerText: string
    onSubmit: () => void
}

export const ClaimMaster: FC<PropsWithChildren<ClaimMasterProps>> = ({children, headerText, onSubmit}) => {

    const handleCancelPressed = () => {

    };

    /*const handleSubmitPressed = () => {
        onSubmit();
    };*/

    return (
        // <form id="ApplicationMainForm" onSubmit={onSubmit} encType="multipart/form-data">
        <Form id="ApplicationMainForm" /*action="http://localhost:5062/ClaimForm"*/ onSubmit={onSubmit} validateStatus={(status) => status >= 200 && status <= 300}>
            <div className="container">
                <div className="row header-container">
                    <div className="form-group col-9 col-sm-9 col-md-6 col-lg-7 col-xl-8">
                        <h1 style={{color: "white"}}>
                            <label id="PageTitleLabel">{headerText}</label>
                        </h1>
                    </div>
                    <div className="float-end d-none d-md-block col-auto">
                        <img src={HeaderLogoRed} alt={"Logo"}/>
                    </div>
                    <div className="float-end d-block d-md-none">
                        <img src="../../assets/Images/HeaderLogoRedNoText.png" alt={"text"}/>
                    </div>
                </div>
                <div className="row pt-3 pb-3">
                    <div className="form-group col-12 d-flex justify-content-end">
                        <button type="button" name="ctl00$CancelLink" value="" onClick={handleCancelPressed} id="ctl00_CancelLink" className="btn btn-danger me-2">
                            <i className="fa fa-times fa-lg text-white"></i>&nbsp;&nbsp;Cancel
                        </button>
                        <button type="button" name="ctl00$SubmitLink" value=""  id="ctl00_SubmitLink" className="btn btn-success">
                            <i className="fa fa-save fa-lg text-white"></i>&nbsp;&nbsp;Save and Submit
                        </button>
                    </div>
                </div>
                <div id="FormSection">
                    <div className="FormContent">
                        {children}
                    </div>
                </div>
                <div className="row pb-3 pt-3">
                    <div className="form-group col-12 d-flex justify-content-end">
                        <button type="button" name="ctl00$CancelLink2" value="" onClick={handleCancelPressed} id="ctl00_CancelLink2" className="btn btn-danger me-2">
                            <i className="fa fa-times fa-lg text-white"></i>&nbsp;&nbsp;Cancel
                        </button>
                        <button type="submit" name="ctl00$SubmitLink2" value="" id="ctl00_SubmitLink2" className="btn btn-success">
                            <i className="fa fa-save fa-lg text-white"></i>&nbsp;&nbsp;Save and Submit
                        </button>
                    </div>
                </div>
            </div>
        </Form>

    );
}
