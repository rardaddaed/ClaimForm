import {DetailedHTMLProps, FC, InputHTMLAttributes} from "react";
import {SbcLabel} from "../SbcLabel.tsx";
import {useFormContext, UseFormReturn} from "react-hook-form";
import {FormFieldAttributes} from "../../Services/formSchemaService.ts";

interface FormDropDownListProps extends DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> {
    id: string
    label: string
}

export const FormDropDownList: FC<FormDropDownListProps> = ({id, label}) => {

    const {
        register,
        schema,
        formState: { errors }
    } = useFormContext() as UseFormReturn & {schema: Record<string, FormFieldAttributes>};

    const idLowerCase = id.toLowerCase();

    const enabled = schema[idLowerCase]?.enabled ?? false;
    const mandatory = schema[idLowerCase]?.mandatory ?? false;
    const items = schema[idLowerCase]?.items ?? [];
    const hasError = !!errors[idLowerCase];

    if(!items)
        return null;

    return (
        <>
            <SbcLabel text={label} associatedControlID={id} hasError={hasError}/>
            <select defaultValue={""} id={id} className={"form-control form-select" + (mandatory ? " Mandatory": "")} title="" {...register(idLowerCase, {required: mandatory})} disabled={!enabled}>
                <option value=""></option>
                {items.map(x => (
                    <option key={x.key} value={x.key}>{x.value}</option>
                ))}

            </select>
        </>
    )
}
