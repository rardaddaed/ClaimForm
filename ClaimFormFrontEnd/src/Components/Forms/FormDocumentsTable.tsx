import {useFormContext} from "react-hook-form";
import {useState} from "react";

interface FormDocumentsTableProps {
    id: string
}

const FormDocumentsTable = ({id}: FormDocumentsTableProps) => {

    const { watch, setValue } = useFormContext();
    const files = Array.from((watch(id) || [])) as File[];
    // console.log("is files array:", Array.isArray(files));
    // console.log("array:", Array.from(files));

    const [selectedIndex, setSelectedIndex] = useState(-1);

    const removeFile = (indexToRemove: number) => {
        setValue(id, files.filter((_, index) => index !== indexToRemove));
    }

    return (
        <div className="GridContainer">
            <div>
                <table className="table table-striped table-hover table-sm" id="ctl00_FullWidthContainer_SupportingDocumentDiv_DocumentGrid" style={{borderWidth: 0, borderCollapse: "collapse"}}>
                    <tbody>
                    <tr className="GridHeader">
                        <th scope="col" style={{width: "5px"}}></th>
                        <th scope="col">File Name</th>
                        <th scope="col">&nbsp;</th>
                    </tr>

                    {files.map((file: File, index: number) => (
                        <tr key={index} className={index % 2 === 0 ? "Even" : "Odd"}>
                            <td className={"RowWidget" + (selectedIndex === index ? " SelectedRowWidget" : "")} onClick={() => setSelectedIndex(index)}>
                                <input name="ctl00$FullWidthContainer$SupportingDocumentDiv$DocumentGrid$ctl02$ctl00" value={"1"} type="hidden"/>
                            </td>
                            <td>
                                <a
                                    id="ctl00_FullWidthContainer_SupportingDocumentDiv_DocumentGrid_ctl02_ViewLink"
                                    href={URL.createObjectURL(file)}
                                    download={file.name}
                                    target="_blank"
                                    rel="noopener noreferrer">
                                    <span className="label">{file.name}</span>
                                </a>
                            </td>
                            <td style={{width: "15%"}}>
                                <div className="text-end">
                                    <button type="button" name="ctl00$FullWidthContainer$SupportingDocumentDiv$DocumentGrid$ctl02$ctl02" onClick={() => removeFile(index)} className="btn btn-danger ms-auto">
                                        <i className="fa fa-times fa-lg text-white"></i>&nbsp;Remove
                                    </button>
                                </div>
                            </td>
                        </tr>
                    ))}


                    </tbody>
                </table>
            </div>
        </div>
    );
};

export default FormDocumentsTable;
