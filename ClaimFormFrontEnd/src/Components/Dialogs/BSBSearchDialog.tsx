import {CardGroup} from "../CardGroup.tsx";
import {SbcLabel} from "../SbcLabel.tsx";
import {FormTextBox} from "../Forms/FormTextBox.tsx";
import {FormDropDownList} from "../Forms/FormDropDownList.tsx";
import SearchDialog from "./SearchDialog.tsx";

interface BsbSearchDialogProps {
    visible: boolean,
    setVisible: (visible: boolean) => void
    onLinkClicked: (bsbResults: string[]) => void
}

const FORM_NAME = "BSBSearchDialog";
const BsbSearchDialog = ({visible, setVisible, onLinkClicked}: BsbSearchDialogProps) => {

    /*const handleResult = (value: string) => {
        //BSBSearchDialog
    }*/

    return (
        <SearchDialog
            formName={FORM_NAME}
            title="BSB Search"
            visible={visible}
            setVisible={setVisible}
            headerColumns={[
                {text: "BSB Number", fieldName: "BSB", returnFieldsOnClick: ["bsbid"]},
                {text: "Financial Institution", fieldName: "Bank"},
                {text: "Address", fieldName: "Address"},
                {text: "Suburb", fieldName: "Suburb"},
                {text: "State", fieldName: "State"},
                {text: "Postcode", fieldName: "Postcode"}
            ]}
            onLinkClicked={onLinkClicked}
        >
            <CardGroup text="Criteria" marginBottom={10}>
                <div className="row">
                    <div className="form-group col-md-4 pb-2 pt-2">
                        <SbcLabel text={"BSB Number"}/>
                        <div className="d-flex bsb-container">
                            <FormTextBox id={"bsbone"} label={""} className="me-2"/>
                            <FormTextBox id={"Bsbtwo"} label={""}/>
                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="form-group col-md-6 pb-2">
                        <FormDropDownList id={"Institution"} label={"Financial Institution"}/>
                    </div>
                    <div className="form-group col-md-6 pb-2">
                        <FormTextBox id={"Address"} label={"Address"}/>
                    </div>
                </div>
                <div className="row">
                    <div className="form-group col-md-2 pb-2">
                        <FormTextBox id={"Suburb"} label={"Suburb"}/>
                    </div>
                    <div className="form-group col-md-1 pb-2">
                        <FormTextBox id={"State"} label={"State"}/>
                    </div>
                    <div className="form-group col-md-1 pb-2">
                        <FormTextBox id={"Postcode"} label={"Postcode"}/>
                    </div>
                </div>
            </CardGroup>
        </SearchDialog>
    );
};

export default BsbSearchDialog;
