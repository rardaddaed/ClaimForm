import {DetailedHTMLProps, FC, InputHTMLAttributes} from "react";
import {SbcLabel} from "../SbcLabel.tsx";
import {useFormContext} from "react-hook-form";
import {callback, FormContext} from "../../Services/formSchemaService.ts";
import {mergeFormSchema} from "./Utils.ts";

interface FormCheckBoxProps extends DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> {
    id: string
    label: string
    isVisible?: () => boolean
}

export const FormCheckBox: FC<FormCheckBoxProps> = ({id, label, isVisible = () => true, ...rest}) => {

    const methods = useFormContext() as FormContext;
    const {
        register,
        schema,
        formName,
        formState: { errors },
        setValue,
    } = methods;

    const idLowerCase = id.toLowerCase();

    if(!isVisible())
        return null;

    const enabled = schema[idLowerCase]?.enabled ?? false;
    const mandatory = schema[idLowerCase]?.mandatory ?? false;
    const hasError = !!errors[idLowerCase];
    const hasCallback = schema[idLowerCase]?.callback;

    return (
        <span className="form-check">
            <input
                id={idLowerCase}
                type="checkbox"
                disabled={!enabled}
                {...rest}
                {...register(idLowerCase, {
                    required: mandatory,
                    onChange: hasCallback ? async (event) => {
                        const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.checked});
                        mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                    } : undefined
                })}
            />
            <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
        </span>
    )
}
