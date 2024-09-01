import {MouseEvent, PropsWithChildren, useEffect, useState} from "react";
import Button from "./Button.tsx";
import {FormProvider, useForm} from "react-hook-form";
import {FormContext, FormFieldAttributes, getFormSchema} from "../../Services/formSchemaService.ts";
import axios from "axios";
import {useTransition} from 'react-transition-state';

// TODO: Sorting by columns.
// TODO: Badge is showing the drop down codeValue not display value

type GridHeaderColumn = {
    text: string,
    fieldName?: string
    returnFieldsOnClick?: string[]
}

interface SearchDialogProps {
    title: string
    formName: string
    visible: boolean,
    setVisible: (visible: boolean) => void
    keepDialogResultsOnClose?: boolean
    headerColumns: GridHeaderColumn[]
    onLinkClicked: (result: (string | number | boolean)[]) => void
}

let hasRun = false;

const SearchDialog = ({title, formName, visible, setVisible, headerColumns, onLinkClicked, children, keepDialogResultsOnClose = false}: PropsWithChildren<SearchDialogProps>) => {

    const methods = useForm() as FormContext;
    methods.formName = formName;
    const [schema, setSchema] = useState<Record<string, FormFieldAttributes> | undefined>(undefined);
    const [gridData, setGridData] = useState<Record<string, string | number | boolean>[] | undefined>(undefined);
    const [state, toggle] = useTransition({timeout: 350, preEnter: true, initialEntered: true});

    useEffect(() => {
        if (visible) {
            if (document.getElementsByTagName("body")[0])
                document.getElementsByTagName("body")[0].style["overflow"] = "hidden";
        } else {
            if (document.getElementsByTagName("body")[0])
                document.getElementsByTagName("body")[0].style["overflow"] = "auto";
        }

        return () => {
            if (document.getElementsByTagName("body")[0])
                document.getElementsByTagName("body")[0].style["overflow"] = "auto";
        }
    }, [visible]);

    useEffect(() => {
        const fetchSchema = async () => {
            hasRun = true;
            const data = await getFormSchema(methods.formName);
            setSchema(data);
        };

        if (!hasRun)
            fetchSchema();

    }, []);

    const onSubmit = async (data: Record<string, string | number | boolean>) => {
        if (!data || Object.values(data).every(x => !x)){
            alert("Must fill in at least one criteria");
            return;
        }

        toggle(false);

        const formData = new FormData();
        for (const key in data)
            formData.append(key, data[key].toString());

        const response = await axios.post<Record<string, string | number | boolean>[]>(`http://localhost:5062/${methods.formName}`, formData);
        if (response.data)
            setGridData(response.data);
    };

    const clearCriteria = () => {
        methods.reset();
        setGridData(undefined);
        toggle(true);
    }

    const closeDialog = () => {
        if(!keepDialogResultsOnClose)
            clearCriteria();
        setVisible(false);
    }

    const valueClicked = (e: MouseEvent, row: Record<string, string | number | boolean>, key: string) => {
        e.preventDefault();

        const headerDetails = headerColumns.find(x => x.fieldName?.toLowerCase() === key.toLowerCase() && x.returnFieldsOnClick);
        if(headerDetails && headerDetails.returnFieldsOnClick){
            const result: (string | number | boolean)[] = [];

            for (const returnFieldKey of headerDetails.returnFieldsOnClick)
                result.push(row[returnFieldKey]);

            closeDialog();
            onLinkClicked(result);
            // alert(JSON.stringify(result));
        }
    }

    if (!visible)
        return null;

    if (!schema)
        return <div>Loading...</div>; //TODO: Replace with real loading screen.

    methods.schema = schema;
    methods.setSchema = setSchema;

    return (
        <FormProvider {...methods}>
            <form onSubmit={methods.handleSubmit(onSubmit)} style={{width: "100vw", height: "100vh", position: "fixed", top: 0, left: 0, backgroundColor: "white", zIndex: 2}}>
                <div style={{padding: "2px", display: "flex", flexDirection: "column", height: "100vh", backgroundColor: "white"}}>

                    <div className="DialogBanner pt-1 pb-1 ps-1 pe-1" style={{height: "40px"}}>
                        <span className="label">{title}</span>
                    </div>

                    <div className={`collapser ${state.status}`} style={{zIndex: 1, maxHeight: state.status !== "exiting" && state.status !== "exited" ? "500px" : undefined}}>
                        <div>
                            {children}
                        </div>
                    </div>

                    <div className="row" style={{zIndex: 3, paddingBottom: "3px", backgroundColor: "white"}}>
                        <div className="col-auto">
                            <a onClick={() => toggle()} className="btn btn-outline-dark" data-bs-toggle="collapse"
                               aria-controls="ctl00_FullWidthContainer_CriteriaSection" aria-expanded="true"><i className="fa fa-chevron-circle-down fa-lg" aria-hidden="true"></i>&nbsp;Expand</a>
                        </div>
                        <div className="col">
                            <div>
                                {Object.values(methods.getValues()).map((value: string) => (
                                    <span className="badge bg-info me-1">{value}</span>
                                ))}
                            </div>
                        </div>
                        <div className="form-group col-auto btn-group">
                            <Button label="Search" className="btn-primary" icon="fa-search" role={"search"} type={"submit"} formAction={"submit"}/>
                            <Button label="Clear" className="btn-warning" icon="fa-eraser" onClick={clearCriteria}/>
                            <Button label="Cancel" className="btn-danger" icon="fa-ban" onClick={closeDialog}/>
                        </div>
                    </div>

                    <div className={"grid-container"} style={{overflowY: "hidden", zIndex: 3, backgroundColor: "white", minHeight: "50vh"}}>
                        <div style={{overflowY: "scroll", zIndex: 3, backgroundColor: "white", minHeight: "50vh", height: "100%"}}>
                            <table className="table table-striped table-hover table-sm" cellSpacing="0" cellPadding="0" style={{borderCollapse: "collapse", borderWidth: 0}}>
                                <tbody>
                                <tr className="GridHeader">
                                    {headerColumns.map(x => (
                                        <th key={x.text} scope="col"><a href="javascript:__doPostBack('ctl00$FullWidthContainer$ResultGrid','Sort$' + x.sortByColumn)">{x.text}</a></th>
                                    ))}
                                </tr>
                                {!gridData ? (
                                    <tr>
                                        <td colSpan={6} style={{width: "100%"}}>No records matched the supplied criteria</td>
                                    </tr>
                                ) : null}

                                {gridData?.map((row, rowIndex) => (
                                    <tr key={rowIndex}>
                                        {Object.keys(row).map((key, columnIndex) => columnIndex == 0 ? null : ( // columnIndex == 0 then nul???? I think this is because BSBID so it's not safe
                                            <td key={key}>{headerColumns.some(x => x.fieldName?.toLowerCase() === key.toLowerCase() && x.returnFieldsOnClick) ? (
                                                <a href={""} onClick={e => valueClicked(e, row, key)}>{row[key]}</a>
                                            ) : row[key]}</td>
                                        ))}
                                    </tr>
                                ))}
                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </form>
        </FormProvider>
    );
};

export default SearchDialog;
