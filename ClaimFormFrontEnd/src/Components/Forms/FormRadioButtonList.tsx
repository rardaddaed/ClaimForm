import {DetailedHTMLProps, FC, InputHTMLAttributes} from "react";
import {SbcLabel} from "../SbcLabel.tsx";
import {SbcRadioButtonList} from "../SbcRadioButtonList.tsx";
import {useFormContext} from "react-hook-form";
import {callback, FormContext} from "../../Services/formSchemaService.ts";
import {mergeFormSchema} from "./Utils.ts";

interface SbcFormRadioButtonListProps extends DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> {
    id: string
    label: string
    isVisible?: () => boolean
    autoCallback?: boolean
    onDependentFieldChanged?: () => (false | {shouldSet: boolean, newValue: string | number | object | boolean})
}

export const FormRadioButtonList: FC<SbcFormRadioButtonListProps> = ({id, label, isVisible = () => true, autoCallback = false, onDependentFieldChanged}) => {

    const methods = useFormContext() as FormContext;
    const {
        register,
        schema,
        formName,
        formState: { errors },
        setValue,
    } = methods;

    const idLowerCase = id.toLowerCase();

    const handleCallback = async (newValue: string | number | object | boolean) => {
        const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: newValue})
        mergeFormSchema(schemaToMerge, methods.setSchema, setValue)
        setValue(idLowerCase, newValue);
    }

    if(onDependentFieldChanged){
        const change = onDependentFieldChanged();
        if(change && change.shouldSet) {
            handleCallback(change.newValue);
        }
    }

    if(!isVisible())
      return null;

    const enabled = schema[idLowerCase]?.enabled ?? false;
    const mandatory = schema[idLowerCase]?.mandatory ?? false;
    const items = schema[idLowerCase]?.items ?? [];
    const hasError = !!errors[idLowerCase];
    const hasCallback = schema[idLowerCase]?.callback ?? autoCallback;

    if(!items || items.length === 0)
      throw new Error(id + " must have items for radio button list")

    return (
        <>
            <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
            <SbcRadioButtonList
                id={idLowerCase}
                isMandatory={mandatory}
                items={items}
                disabled={!enabled}
                {...register(idLowerCase, {
                    required: mandatory,
                    onChange: hasCallback ? async (event) => {
                        const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.value});
                        mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                    } : undefined
                })}
            />
        </>
    )
}
